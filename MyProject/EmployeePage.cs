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
    public partial class EmployeePage : Form
    {
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {

        }

        private void changebtn_Click(object sender, EventArgs e)
        {

        }

        private void bookATableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Reservation ");

            dataGridViewmanager.DataSource = dt;
            dataGridViewmanager.Refresh();
            dataGridViewmanager.ClearSelection();
        }

        private void contactUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Reservation ");

            dataGridViewmanager.DataSource = dt;
            dataGridViewmanager.Refresh();
            dataGridViewmanager.ClearSelection();
        }

        private void HOMEstripMenuItem1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
            this.Dispose();
        }

        private void savetxt_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Reservation where Firstname like '%" + fstnameTxt.Text + "%'");

            dataGridViewmanager.DataSource = dt;
            dataGridViewmanager.Refresh();
            dataGridViewmanager.ClearSelection();
        }

        private void contactUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.Show();
            this.Hide();
        }
    }
}
