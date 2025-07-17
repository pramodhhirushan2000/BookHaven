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
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label3.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                login lf = new login(); // Replace with your actual login form name
                lf.Show();
                this.Hide(); // Close the splash screen after login is done
            }
        }

        
    }
}
