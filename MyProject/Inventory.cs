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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
            this.Dispose();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click_1(object sender, EventArgs e)
        {

            if (combotype.Text == "Rawmaterial")
            {
                DataTable dt = DataAccess.LoadData("select * from Rawmaterial where Name like '%" + textBox1.Text + "%' ");
                CostTxt.Text = " ";
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();

            }
            else if (combotype.Text == "Drinks")
            {
                DataTable dt = DataAccess.LoadData("select * from Drinksinventory where Name like '%" + textBox1.Text + "%'");

                CostTxt.Text = " ";
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();
                dataGridView2.ClearSelection();

            }
        }

        private void addbtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == " ") || (quantityTxt.Text == " ") || (combotype.Text == " "))
                { MessageBox.Show("Fill all"); }
                else if (combotype.Text == "Drinks")
                {
                    int row = DataAccess.ExecuteQuery("update Drinksinverntory   set Quantity=Quantity + " + Convert.ToInt64(quantityTxt.Text) + " where Name='" + textBox1.Text + "'");

                    if (row > 0)
                    {
                        MessageBox.Show("inserted");
                        DataTable dt = DataAccess.LoadData("select * from Drinksinverntory ");

                        CostTxt.Text = quantityTxt.Text = combotype.Text = " ";
                        dataGridView2.AutoGenerateColumns = false;
                        dataGridView2.DataSource = dt;
                        dataGridView2.Refresh();
                        dataGridView2.ClearSelection();

                    }

                }

                else if (combotype.Text == "Rawmaterial")
                {
                    int row = DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity + " + Convert.ToInt64(quantityTxt.Text) + " where Name='" + textBox1.Text + "'");

                    if (row > 0)
                    {
                        MessageBox.Show("inserted");
                        DataTable dt = DataAccess.LoadData("select * from Rawmaterial ");

                        CostTxt.Text = quantityTxt.Text = combotype.Text = " ";
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                        dataGridView1.ClearSelection();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalied");
            }
        }

        private void deletebtn_Click_1(object sender, EventArgs e)
        {
             if (CostTxt.Text == "")
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (combotype.Text == "Drinks")
            {

                int row = DataAccess.ExecuteQuery("DELETE FROM [dbo].[Drinksinverntory] WHERE Name like'" + textBox1.Text + "'");
                if (row > 0)
                {
                    MessageBox.Show("Deleted");
                    
                    DataTable dt = DataAccess.LoadData("select * from Drinksinverntory ");


                    CostTxt.Text = quantityTxt.Text = combotype.Text = " ";
                    dataGridView2.AutoGenerateColumns = false;
                    dataGridView2.DataSource = dt;
                    dataGridView2.Refresh();
                    dataGridView2.ClearSelection();
                }

            }
            else if (combotype.Text == "Rawmaterial")
            {

                int row = DataAccess.ExecuteQuery("DELETE FROM [dbo].[Rawmaterial] WHERE Name like'" + textBox1.Text + "'");
                if (row > 0)
                {
                    MessageBox.Show("Deleted");
                    
                    DataTable dt = DataAccess.LoadData("select * from Rawmaterial ");


                    CostTxt.Text = quantityTxt.Text = combotype.Text = " ";
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    dataGridView1.ClearSelection();
                }

            }

            }

        private void homebtn_Click_1(object sender, EventArgs e)
        {
             Home h = new Home();
            h.Show();
            this.Close();
            this.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            CostTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantityTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            CostTxt.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantityTxt.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void Inventory_Load_1(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Rawmaterial ");
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();

            DataTable dt1 = DataAccess.LoadData("select * from Drinksinverntory ");
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dt1;
            dataGridView2.Refresh();
            dataGridView2.ClearSelection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == " ") || (quantityTxt.Text == " ") || (combotype.Text == " "))
                { MessageBox.Show("Fill all"); }
                else if (combotype.Text == "Drinks")
                {
                    int row = DataAccess.ExecuteQuery("insert into Drinksinverntory ( Name,Quantity) values('" + textBox1.Text + "','" + quantityTxt.Text + "');");

                    if (row > 0)
                    {
                        MessageBox.Show("inserted");
                        DataTable dt = DataAccess.LoadData("select * from Drinksinverntory ");

                        CostTxt.Text = quantityTxt.Text = combotype.Text = " ";
                        dataGridView2.AutoGenerateColumns = false;
                        dataGridView2.DataSource = dt;
                        dataGridView2.Refresh();
                        dataGridView2.ClearSelection();

                    }

                }

                else if (combotype.Text == "Rawmaterial")
                {
                    int row = DataAccess.ExecuteQuery("insert into Rawmaterial  (Name,Quantity) values('" + textBox1.Text + "','" + quantityTxt.Text + "');");

                    if (row > 0)
                    {
                        MessageBox.Show("inserted");
                        DataTable dt = DataAccess.LoadData("select * from Rawmaterial ");

                        CostTxt.Text = quantityTxt.Text = combotype.Text = " ";
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                        dataGridView1.ClearSelection();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalied");
            }
        }
        }
    }



