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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
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
            AddEmployee ae = new AddEmployee();
            ae.Show();
            //this.Close();
            //this.Dispose();
        }

       /* private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
           
        }*/

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Booking_list bl = new Booking_list();
            bl.Show();
            this.Close();
            this.Dispose();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
            this.Dispose();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select E_Id as'ID', Username,FName,LName,Address,Phone,Gmail,Type from Employee where Type not like 'Admin' ");
            
            dataGridViewmanager.DataSource = dt;
            dataGridViewmanager.Refresh();
            dataGridViewmanager.ClearSelection();
        }

        /*private void btnsearch_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select  FName as 'Firstname',LName as 'Lastname',Address,Gmail,Phone,Type from Employee where Username like '%" + NameTxt.Text + "%' and Type not like 'Manager'");

            NameTxt.Text = "";
            
            dataGridViewmanager.DataSource = dt;
            dataGridViewmanager.Refresh();
            dataGridViewmanager.ClearSelection();
        }*/

        private void Manager_Load(object sender, EventArgs e)
        {
            
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


                    dataGridViewmanager.DataSource = dt;
                    dataGridViewmanager.Refresh();
                    dataGridViewmanager.ClearSelection();
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


                    dataGridViewmanager.DataSource = dt;
                    dataGridViewmanager.Refresh();
                    dataGridViewmanager.ClearSelection();



                }


            }
        }

        private void dataGridViewmanager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            Idtext.Text = dataGridViewmanager.Rows[e.RowIndex].Cells[0].Value.ToString();
            NameTxt.Text = dataGridViewmanager.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (typecombo.Text =="Customer")
            {
                DataTable dt = DataAccess.LoadData("select * from Customer where F_name like '%" + NameTxt.Text + "%' ");
                Idtext.Text = " ";
            dataGridViewmanager.DataSource = dt;
            dataGridViewmanager.Refresh();
            dataGridViewmanager.ClearSelection();
            
            }
            else if (typecombo.Text == "Employee")
            {
                DataTable dt = DataAccess.LoadData("select Username, FName as 'Firstname',LName as 'Lastname',Address,Gmail,Phone,Type from Employee where Username like '%" + NameTxt.Text + "%' and Type not like 'Admin' ");

                Idtext.Text = " ";

                dataGridViewmanager.DataSource = dt;
                dataGridViewmanager.Refresh();
                dataGridViewmanager.ClearSelection();
            
            }
        }

        private void customerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerRegistration cr = new CustomerRegistration();
            cr.Show();
            this.Hide();
        }

        private void customerListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Customer ");

            dataGridViewmanager.DataSource = dt;
            dataGridViewmanager.Refresh();
            dataGridViewmanager.ClearSelection();
        }

        private void tableBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablebook tb = new Tablebook();
            tb.Show();
            this.Refresh();
        }
    }
}
