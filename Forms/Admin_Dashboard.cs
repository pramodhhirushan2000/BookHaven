using BookHaven.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Forms
{
    public partial class Admin_Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public Admin_Dashboard()
        {
            InitializeComponent();
            timer2.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 66)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }



        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }
        private void AddControllsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_dashboard);
            UC_Admin_Dashboard ucad = new UC_Admin_Dashboard();
            AddControllsToPanel(ucad);
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_inventory);
            UC_Inventory_Management ucim = new UC_Inventory_Management();
            AddControllsToPanel(ucim);
        }

        private void btn_cus_manage_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_cus_manage);
            UC_Customer_Manage uccm = new UC_Customer_Manage();
            AddControllsToPanel(uccm);
        }

        private void btn_sale_pos_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_sale_pos);
            UC_Sales_Transaction ucst = new UC_Sales_Transaction();
            AddControllsToPanel(ucst);
        }

        private void btn_order_manage_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_order_manage);
            UC_Order_Management ucom = new UC_Order_Management();
            AddControllsToPanel(ucom);
        }

        private void btn_supply_manage_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_supply_manage);
            UC_Supplier_Management ucsm = new UC_Supplier_Management();
            AddControllsToPanel(ucsm);
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_report);
            UC_Reports ucr = new UC_Reports();
            AddControllsToPanel(ucr);
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login lf = new login();
            lf.Show();

            // Close the current form
            this.Hide(); // Hides the current form instead of disposing of it
        }
    }
}
