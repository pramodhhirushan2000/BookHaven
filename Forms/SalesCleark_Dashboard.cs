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
    public partial class SalesCleark_Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public SalesCleark_Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panel1.Width;
            isCollapsed = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            login lf = new login();
            lf.Show();

            // Close the current form
            this.Hide(); // Hides the current form instead of disposing of it
        }

        private void btn_cus_manage_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_cus_manage);
            UC_Customer_Manage uccm = new UC_Customer_Manage();
            AddControllsToPanel(uccm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel1.Width = panel1.Width + 10;
                if (panel1.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panel1.Width = panel1.Width - 10;
                if (panel1.Width <= 66)
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
            panelSide2.Top = btn.Top;
            panelSide2.Height = btn.Height;
        }
        private void AddControllsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panel2Controls.Controls.Clear();
            panel2Controls.Controls.Add(c);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
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

      
    }
}
