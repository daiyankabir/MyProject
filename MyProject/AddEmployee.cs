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
    public partial class AddEmployee: Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Idtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void savetxt_Click(object sender, EventArgs e)
        {
            try
            {
                char ch = ' ';
                if (textusername.Text != "")
                {
                    ch = textusername.Text[0];
                }
                if ((textusername.Text == "") || (textpassword.Text == "") || (fstnameTxt.Text == "") || (scndnameTxt.Text == "") || (addresstxt.Text == "") || (textphone.Text == "") || (combotype.SelectedIndex == -1) || (gmailtxt.Text == ""))
                {
                    MessageBox.Show("Fields all ");
                }
                else if ((textBoxconfirmpassword.Text != textpassword.Text))
                {
                    MessageBox.Show("Invalid Password");
                }
                else if (!((gmailtxt.Text.Contains("@")) && (gmailtxt.Text.Contains("."))))
                {
                    MessageBox.Show("Invalid E-mail ID");
                }
                else if ((gmailtxt.Text.IndexOf("@")) > (gmailtxt.Text.LastIndexOf(".")))
                {
                    MessageBox.Show("Invalid E-mail ID");
                }
                else if (textusername.Text.Contains(" "))
                {
                    MessageBox.Show("Username Cannot Contain Space");
                }
                else if (!(((Convert.ToInt16(ch) >= 65) && (Convert.ToInt16(ch) <= 90)) || ((Convert.ToInt16(ch) >= 97) && (Convert.ToInt16(ch) <= 122))))
                {
                    MessageBox.Show("Username Must starts with an Alphabet");
                }


                else
                {
                    int row = DataAccess.ExecuteQuery("insert into Employee(Username,Password,FName,LName,Address,Gmail,Phone,Type) values('" + textusername.Text + "','" + textpassword.Text + "','" + fstnameTxt.Text + "','" + scndnameTxt.Text + "','" + addresstxt.Text + "','" + gmailtxt.Text + "','" + textphone.Text + "', '" + combotype.Text + "')");
                    
                    if (row > 0)
                    {
                        MessageBox.Show("Registration successful");


                        AddEmployee ad = new AddEmployee();
                        ad.Show();
                        this.Close();
                        this.Dispose();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalied");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Home m = new Home();
            //m.Show();
            this.Close();
            this.Dispose();
        }
    }
}
