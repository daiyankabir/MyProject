using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyProject
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Menu ");
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();

            DataTable dt1 = DataAccess.LoadData("select * from Drinks ");
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dt1;
            dataGridView2.Refresh();
            dataGridView2.ClearSelection();

           

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Dispose();
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            try {

                if ((dateTimePicker1.Text == " ") || (billtxt.Text == " "))
                {
                    MessageBox.Show("Invalid bill");

                }
                else
                {
                   
                    int row = DataAccess.ExecuteQuery("INSERT INTO [dbo].[Bill] ([Date] ,[Price])  VALUES('" + dateTimePicker1.Text + "','" + billtxt.Text + "')");
                    MessageBox.Show("Transaction successful");
                    DataAccess.ExecuteQuery("DELETE FROM [dbo].[Bill_Details] ");

                    Menu c = new Menu();
                    c.Show();
                    this.Close();
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalied");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            itemNametxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            itemtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            itemPricetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            itemNametxt.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            itemtxt.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantitytxt.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
           
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            itemNametxt.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            itemtxt.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            itemPricetxt.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                if ((itemNametxt.Text == "") || (itemtxt.Text == "") || (itemPricetxt.Text == ""))
                {
                    MessageBox.Show("Please select item");

                }
                else if ((quantitytxt.Text == " "))
                { MessageBox.Show("Please enter Quantity"); }


                else
                {

                    if (itemtxt.Text == "Kacchi")
                    {
                        if (Convert.ToInt64(quantitytxt.Text) >= 10) { MessageBox.Show("Max limit overflow"); }
                        else
                        {
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Rice';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity -" + (Convert.ToInt64(quantitytxt.Text) * 100) + " where Name='Meat'");
                        }
                    }
                    else if (itemtxt.Text == "Fried rice")
                    {
                        if (Convert.ToInt64(quantitytxt.Text) >= 10) { MessageBox.Show("Max limit overflow"); }
                        else
                        {
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Rice';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Chili';");

                        } 
                    }
                    else if (itemtxt.Text == "Chicken Burger")
                    {
                        if (Convert.ToInt64(quantitytxt.Text) >= 10) { MessageBox.Show("Max limit overflow"); }
                        else
                        {
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Meat';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Flour';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Tomato';");
                        }
                    }
                    else if (itemtxt.Text == "Beef Burger")
                    {
                        if (Convert.ToInt64(quantitytxt.Text) >= 10) { MessageBox.Show("Max limit overflow"); }
                        else
                        {

                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Meat';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Flour';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Tomato';");
                        }
                    }

                    else if (itemtxt.Text == "Chicken fry")
                    {
                        if (Convert.ToInt64(quantitytxt.Text) >= 10) { MessageBox.Show("Max limit overflow"); }
                        else
                        {
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Meat';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Flour';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Chili';");

                        }
                    }
                    else if (itemtxt.Text == "Cold Coffee")
                    {
                        if (Convert.ToInt64(quantitytxt.Text) >= 10) { MessageBox.Show("Max limit overflow"); }
                        else
                        {
                            DataAccess.ExecuteQuery("update Drinksinverntory set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 1 + " where Name='Cold Coffee';");
                        }
                    }
                    else if (itemtxt.Text == "Lemon juice")
                    {
                        if (Convert.ToInt64(quantitytxt.Text) >= 10) { MessageBox.Show("Max limit overflow"); }
                        else
                        {
                            DataAccess.ExecuteQuery("update Drinksinverntory set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 1 + " where Name='Lemon Juice';");

                        }
                    }
                    else if (itemtxt.Text == "Mango juice")
                    {
                        if (Convert.ToInt64(quantitytxt.Text) >= 10) { MessageBox.Show("Max limit overflow"); }
                        else
                        {
                            DataAccess.ExecuteQuery("update Drinksinverntory set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 1 + " where Name='Mango Juice';");

                        }
                    }
                    else if (itemtxt.Text == "Apple juice")
                    {
                        if (Convert.ToInt64(quantitytxt.Text) >= 10) { MessageBox.Show("Max limit overflow"); }
                        else
                        {
                            DataAccess.ExecuteQuery("update Drinksinverntory set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 1 + " where Name='Apple Juice';");

                        }
                    }


                    else if (itemtxt.Text == "Coke")
                    {
                        if (Convert.ToInt64(quantitytxt.Text) >= 10) { MessageBox.Show("Max limit overflow"); }
                        else
                        {
                            DataAccess.ExecuteQuery("update Drinksinverntory set Quantity=Quantity-" + Convert.ToInt64(quantitytxt.Text) * 1 + " where Name='Coke';");

                        }
                    }

                    if (Convert.ToInt64(quantitytxt.Text) >= 10) { MessageBox.Show("Max limit overflow"); }
                    else
                    {
                        int row = DataAccess.ExecuteQuery("INSERT INTO [dbo].[Bill_Details] ([Itemname] ,[Quantity] ,[Price] ,[Total]) VALUES ('" + itemtxt.Text + "','" + quantitytxt.Text + "','" + itemPricetxt.Text + "','" + Convert.ToDouble((Convert.ToInt32(this.quantitytxt.Text)) * (Convert.ToInt32(this.itemPricetxt.Text))) + "')  ");

                    }

                    DataTable dt = DataAccess.LoadData("select * from Bill_Details");


                    itemNametxt.Text = itemtxt.Text = itemPricetxt.Text = quantitytxt.Text = "";
                    dataGridView3.AutoGenerateColumns = false;
                    dataGridView3.DataSource = dt;
                    dataGridView3.Refresh();
                    dataGridView3.ClearSelection();
                    int sum = 0;
                    for (int i = 0; i < dataGridView3.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dataGridView3.Rows[i].Cells[4].Value);
                    }
                    CostTxt.Text = sum.ToString();

                  



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalied");
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {


                int row = DataAccess.ExecuteQuery("DELETE FROM [dbo].[Bill_Details] WHERE Itemname like'" + itemtxt.Text + "' and Srlno like '" + itemNametxt.Text + "'");
                if (row > 0)
                {
                    MessageBox.Show("Deleted");
                    if (itemtxt.Text == "Kacchi")
                    {
                        
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Rice';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity+" + (Convert.ToInt64(quantitytxt.Text) * 100) + " where Name='Meat'");
                        
                    }
                    else if (itemtxt.Text == "Fried rice")
                    {
                        
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Rice';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Chili';");

                        
                    }
                    else if (itemtxt.Text == "Chicken Burger")
                    {
                        
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Meat';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Flour';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Tomato';");
                        
                    }
                    else if (itemtxt.Text == "Beef Burger")
                    {
                        

                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Meat';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Flour';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Tomato';");
                        
                    }

                    else if (itemtxt.Text == "Chicken fry")
                    {
                        
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Meat';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Flour';");
                            DataAccess.ExecuteQuery("update Rawmaterial set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 100 + " where Name='Chili';");

                        
                    }
                    else if (itemtxt.Text == "Cold Coffee")
                    {
                        
                            DataAccess.ExecuteQuery("update Drinksinverntory set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 1 + " where Name='Cold Coffee';");
                        
                    }
                    else if (itemtxt.Text == "Lemon juice")
                    {
                        
                            DataAccess.ExecuteQuery("update Drinksinverntory set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 1 + " where Name='Lemon Juice';");

                        
                    }
                    else if (itemtxt.Text == "Mango juice")
                    {
                       
                            DataAccess.ExecuteQuery("update Drinksinverntory set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 1 + " where Name='Mango Juice';");

                        
                    }
                    else if (itemtxt.Text == "Apple juice")
                    {
                        
                            DataAccess.ExecuteQuery("update Drinksinverntory set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 1 + " where Name='Apple Juice';");

                        
                    }


                    else if (itemtxt.Text == "Coke")
                    {
                        
                            DataAccess.ExecuteQuery("update Drinksinverntory set Quantity=Quantity+" + Convert.ToInt64(quantitytxt.Text) * 1 + " where Name='Coke';");

                        
                    }
                  
                    itemNametxt.Text = itemtxt.Text = itemPricetxt.Text = quantitytxt.Text = "";
                    DataTable dt = DataAccess.LoadData("select * from Bill_Details");

                    dataGridView3.AutoGenerateColumns = false;
                    dataGridView3.DataSource = dt;
                    dataGridView3.Refresh();
                    dataGridView3.ClearSelection();
                    int sum = 0;
                    for (int i = 0; i < dataGridView3.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dataGridView3.Rows[i].Cells[4].Value);
                    }
                    CostTxt.Text = sum.ToString();
                    billtxt.Text = CostTxt.Text;
                }
          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalied");
            }
        }

        private void CostTxt_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void returntxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void returntxt_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            int sum = 0;
            sum = (Convert.ToInt32(recivetxt.Text)) - (Convert.ToInt32(CostTxt.Text));
            if (sum < 0) { MessageBox.Show("Pay sufficient amount"); }
            else
            {
                returntxt.Text = sum.ToString();
                billtxt.Text = CostTxt.Text;
            }
        }
    }
}
