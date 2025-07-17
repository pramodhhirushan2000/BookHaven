using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;
using Document = iTextSharp.text.Document;

namespace BookHaven.User_Controls
{
    public partial class UC_Reports : UserControl
    {
        private const string connectionString = @"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True";

        public UC_Reports()
        {
            InitializeComponent();
        }

        private void LoadDashboardStats()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string dailySalesQuery = "SELECT SUM(TotalAmount) FROM Sales WHERE CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)";
                    string weeklySalesQuery = "SELECT SUM(TotalAmount) FROM Sales WHERE SaleDate >= DATEADD(DAY, -7, GETDATE())";
                    string monthlySalesQuery = "SELECT SUM(TotalAmount) FROM Sales WHERE SaleDate >= DATEADD(DAY, -30, GETDATE())";

                    decimal dailySales = ExecuteScalarQuery(conn, dailySalesQuery);
                    decimal weeklySales = ExecuteScalarQuery(conn, weeklySalesQuery);
                    decimal monthlySales = ExecuteScalarQuery(conn, monthlySalesQuery);

                    // Update UI Labels on the Main UI Thread
                    lblDailySales.Invoke((MethodInvoker)delegate
                    {
                        lblDailySales.Text = $"{dailySales:C}";
                        lblWeeklySales.Text = $"{weeklySales:C}";
                        lblMonthlySales.Text = $"{monthlySales:C}";
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard stats: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal ExecuteScalarQuery(SqlConnection conn, string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();
                return (result != DBNull.Value && result != null) ? Convert.ToDecimal(result) : 0;
            }
        }

        private void LoadSalesReport(string reportType)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = reportType switch
                    {
                        "Daily" => "SELECT SaleID, SaleDate, CustomerID, TotalAmount FROM Sales WHERE CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)",
                        "Weekly" => "SELECT SaleID, SaleDate, CustomerID, TotalAmount FROM Sales WHERE SaleDate >= DATEADD(DAY, -7, GETDATE())",
                        "Monthly" => "SELECT SaleID, SaleDate, CustomerID, TotalAmount FROM Sales WHERE SaleDate >= DATEADD(DAY, -30, GETDATE())",
                        _ => ""
                    };

                    if (!string.IsNullOrEmpty(query))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvSalesReport.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_Reports_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            LoadSalesReport("Daily");
        }

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {
            LoadSalesReport("Weekly");
        }

        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            LoadSalesReport("Monthly");
        }

        private void ExportSalesReportToPDF()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string summaryQuery = @"
                SELECT 'Daily Sales' AS ReportType, ISNULL(SUM(TotalAmount), 0) AS TotalSales 
                FROM Sales WHERE CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)
                UNION ALL
                SELECT 'Weekly Sales', ISNULL(SUM(TotalAmount), 0) 
                FROM Sales WHERE SaleDate >= DATEADD(DAY, -7, GETDATE())
                UNION ALL
                SELECT 'Monthly Sales', ISNULL(SUM(TotalAmount), 0) 
                FROM Sales WHERE SaleDate >= DATEADD(DAY, -30, GETDATE())";

                    string detailsQuery = @"
                SELECT s.SaleID, 
                       s.SaleDate, 
                       COALESCE(CAST(c.CustomerID AS VARCHAR), 'Unknown') AS CustomerID, 
                       s.TotalAmount 
                FROM Sales s
                LEFT JOIN Customers c ON s.CustomerID = c.CustomerID
                WHERE s.SaleDate >= DATEADD(DAY, -30, GETDATE())
                ORDER BY s.SaleDate DESC";

                    using (SqlCommand summaryCmd = new SqlCommand(summaryQuery, conn))
                    using (SqlCommand detailsCmd = new SqlCommand(detailsQuery, conn))
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog
                        {
                            Filter = "PDF Files (*.pdf)|*.pdf",
                            Title = "Save Sales Report",
                            FileName = $"SalesReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
                        };

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                            using (Document doc = new Document(PageSize.A4, 30f, 30f, 40f, 40f))
                            {
                                PdfWriter.GetInstance(doc, fs);
                                doc.Open();

                                // Title & Subtitle
                                Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20f, BaseColor.BLACK);
                                Font subtitleFont = FontFactory.GetFont(FontFactory.HELVETICA, 12f, BaseColor.DARK_GRAY);

                                Paragraph title = new Paragraph("📖 BookHaven Sales Report\n", titleFont)
                                {
                                    Alignment = Element.ALIGN_CENTER,
                                    SpacingAfter = 10f
                                };
                                doc.Add(title);

                                Paragraph subtitle = new Paragraph($"Generated on: {DateTime.Now:MMMM dd, yyyy HH:mm tt}\n\n", subtitleFont)
                                {
                                    Alignment = Element.ALIGN_CENTER
                                };
                                doc.Add(subtitle);

                                // Summary Table
                                PdfPTable summaryTable = new PdfPTable(2)
                                {
                                    WidthPercentage = 100,
                                    SpacingBefore = 20f,
                                    SpacingAfter = 20f
                                };
                                summaryTable.SetWidths(new float[] { 2f, 3f });

                                PdfPCell summaryHeader1 = new PdfPCell(new Phrase("Report Type", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12f, BaseColor.WHITE)))
                                {
                                    BackgroundColor = BaseColor.DARK_GRAY,
                                    Padding = 5,
                                    HorizontalAlignment = Element.ALIGN_CENTER
                                };
                                PdfPCell summaryHeader2 = new PdfPCell(new Phrase("Total Sales", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12f, BaseColor.WHITE)))
                                {
                                    BackgroundColor = BaseColor.DARK_GRAY,
                                    Padding = 5,
                                    HorizontalAlignment = Element.ALIGN_CENTER
                                };

                                summaryTable.AddCell(summaryHeader1);
                                summaryTable.AddCell(summaryHeader2);

                                using (SqlDataReader summaryReader = summaryCmd.ExecuteReader())
                                {
                                    while (summaryReader.Read())
                                    {
                                        summaryTable.AddCell(new PdfPCell(new Phrase(summaryReader["ReportType"].ToString()))
                                        {
                                            Padding = 5,
                                            HorizontalAlignment = Element.ALIGN_CENTER
                                        });

                                        summaryTable.AddCell(new PdfPCell(new Phrase(Convert.ToDecimal(summaryReader["TotalSales"]).ToString("C")))
                                        {
                                            Padding = 5,
                                            HorizontalAlignment = Element.ALIGN_RIGHT
                                        });
                                    }
                                }
                                doc.Add(summaryTable);

                                // Sales Details Table
                                PdfPTable detailsTable = new PdfPTable(4)
                                {
                                    WidthPercentage = 100,
                                    SpacingBefore = 10f
                                };
                                detailsTable.SetWidths(new float[] { 2f, 3f, 4f, 3f });

                                BaseColor headerColor = new BaseColor(50, 50, 50);
                                Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11f, BaseColor.WHITE);

                                string[] columnHeaders = { "Sale ID", "Sale Date", "Customer ID", "Total Amount" };

                                foreach (string header in columnHeaders)
                                {
                                    PdfPCell headerCell = new PdfPCell(new Phrase(header, headerFont))
                                    {
                                        BackgroundColor = headerColor,
                                        Padding = 6,
                                        HorizontalAlignment = Element.ALIGN_CENTER
                                    };
                                    detailsTable.AddCell(headerCell);
                                }

                                using (SqlDataReader detailsReader = detailsCmd.ExecuteReader())
                                {
                                    bool alternateRow = false;
                                    while (detailsReader.Read())
                                    {
                                        BaseColor rowColor = alternateRow ? new BaseColor(240, 240, 240) : BaseColor.WHITE;
                                        alternateRow = !alternateRow;

                                        detailsTable.AddCell(new PdfPCell(new Phrase(detailsReader["SaleID"].ToString()))
                                        {
                                            Padding = 5,
                                            BackgroundColor = rowColor,
                                            HorizontalAlignment = Element.ALIGN_CENTER
                                        });

                                        detailsTable.AddCell(new PdfPCell(new Phrase(Convert.ToDateTime(detailsReader["SaleDate"]).ToString("MMM dd, yyyy HH:mm tt")))
                                        {
                                            Padding = 5,
                                            BackgroundColor = rowColor,
                                            HorizontalAlignment = Element.ALIGN_CENTER
                                        });

                                        detailsTable.AddCell(new PdfPCell(new Phrase(detailsReader["CustomerID"].ToString()))
                                        {
                                            Padding = 5,
                                            BackgroundColor = rowColor,
                                            HorizontalAlignment = Element.ALIGN_CENTER
                                        });

                                        detailsTable.AddCell(new PdfPCell(new Phrase(Convert.ToDecimal(detailsReader["TotalAmount"]).ToString("C")))
                                        {
                                            Padding = 5,
                                            BackgroundColor = rowColor,
                                            HorizontalAlignment = Element.ALIGN_RIGHT
                                        });
                                    }
                                }

                                doc.Add(detailsTable);
                                doc.Close();
                            }

                            MessageBox.Show($"Sales report successfully exported to:\n{saveFileDialog.FileName}", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting sales report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_export_to_pdf_Click(object sender, EventArgs e)
        {
            ExportSalesReportToPDF();
        }

    }
}
