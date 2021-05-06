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
    public partial class Booking_list : Form
    {
        public Booking_list()
        {
            InitializeComponent();
        }

        private void Booking_list_Load(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Reservation ");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Reservation ");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void srcbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Reservation where Phone like '%" + NameTxt.Text + "%'");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "")
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }

            int row = DataAccess.ExecuteQuery("DELETE FROM [dbo].[Reservation] WHERE Phone like'" + NameTxt.Text + "'");
            if (row > 0)
            {
                MessageBox.Show("Deleted");
                NameTxt.Text = "";
                DataTable dt = DataAccess.LoadData("select * from Reservation");


                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Manager m = new Manager();
            m.Show();
            this.Close();
            this.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            NameTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
