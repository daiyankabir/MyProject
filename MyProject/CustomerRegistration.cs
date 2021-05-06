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
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Idtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void savetxt_Click(object sender, EventArgs e)
        {
            try
            {
                char ch = ' ';
                if (fstnameTxt.Text != "")
                {
                    ch = fstnameTxt.Text[0];
                }
                if ((fstnameTxt.Text == "") || (addresstxt.Text == "") || (phoneNotxt.Text == "") || (combotype.SelectedIndex == -1) || (gmailtxt.Text == ""))
                {
                    MessageBox.Show("Fields all ");
                }
                
                else if (!((gmailtxt.Text.Contains("@")) && (gmailtxt.Text.Contains("."))))
                {
                    MessageBox.Show("Invalid E-mail ID");
                }
                else if ((gmailtxt.Text.IndexOf("@")) > (gmailtxt.Text.LastIndexOf(".")))
                {
                    MessageBox.Show("Invalid E-mail ID");
                }
                

                string query = "";
                query = "INSERT INTO [dbo].[Customer] ([F_name] ,[L_name] ,[Gender] ,[Email],[Phone],[Address]) VALUES('" + fstnameTxt.Text + "','" + scndnameTxt.Text + "','" + combotype.Text + "','" + gmailtxt.Text + "','" + phoneNotxt.Text + "','" + addresstxt.Text + "')";
                int row = DataAccess.ExecuteQuery(query);
                if (row > 0)
                {
                    MessageBox.Show("Registration successful");

                   Manager h = new Manager();
                    h.Show();
                    this.Close();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager m = new Manager();
            m.Show();
            this.Close();
            this.Dispose();
        }
    }
}
