using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        

        private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logintxt lg = new Logintxt();
            lg.Show();
            this.Hide();
           

            
        }

        private void HOMEstripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();

        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void offerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectDateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablebook tb = new Tablebook();
            tb.Show();
            
        }

      

       /* private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerRegistration cr = new CustomerRegistration();
            cr.Show();
            this.Hide();
        }*/

        private void orderMenuItem_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void contactUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Contact co = new Contact();
            co.Show();
            this.Hide();
        }

        private void bookingCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bookingCostToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void bookingCostToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
