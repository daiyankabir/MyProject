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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
            this.Dispose();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
            this.Close();
            this.Dispose();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select E_Id as'ID', Username,FName,LName,Address,Phone,Gmail,Type from Employee where Type not like 'Admin' ");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Reservation ");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void customerListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Customer ");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Bill ");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (typecombo.Text == "Customer")
            {
                DataTable dt = DataAccess.LoadData("select * from Customer where F_name like '%" + NameTxt.Text + "%' ");
                Idtext.Text = " ";
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();

            }
            else if (typecombo.Text == "Employee")
            {
                DataTable dt = DataAccess.LoadData("select Username, FName as 'Firstname',LName as 'Lastname',Address,Gmail,Phone,Type from Employee where Username like '%" + NameTxt.Text + "%' and Type not like 'Admin'");

                Idtext.Text = " ";

                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();

            }
            else
            {

                DataTable dt = DataAccess.LoadData("select * from Bill where Date like '" + dateTimePicker1.Text + "' ");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
            
            
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Idtext.Text == "")
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            else if (typecombo.Text == "Employee")
            {

                int row = DataAccess.ExecuteQuery("DELETE FROM [dbo].[Employee] WHERE E_ID like'" + Idtext.Text + "' and Username like'" + NameTxt.Text + "'");
                if (row > 0)
                {
                    MessageBox.Show("Deleted");
                    Idtext.Text = NameTxt.Text = "";
                    DataTable dt = DataAccess.LoadData("select E_Id as'ID', Username,FName,LName,Address,Phone,Gmail,Type from Employee where Type not like 'Admin'");


                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    dataGridView1.ClearSelection();
                }
            }
            else if (typecombo.Text == "Customer")
            {

                int row = DataAccess.ExecuteQuery("DELETE FROM [dbo].[Customer] WHERE C_ID like'" + Idtext.Text + "'");
                if (row > 0)
                {
                    MessageBox.Show("Deleted");
                    Idtext.Text = NameTxt.Text = "";
                    DataTable dt = DataAccess.LoadData("select * from Customer");


                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    dataGridView1.ClearSelection();



                }
            }
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            ae.Show();
            //this.Close();
            //this.Dispose();
        }
    }
}
