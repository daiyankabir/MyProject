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
    public partial class Tablebook : Form
    {
        public Tablebook()
        {
            InitializeComponent();
        }

        private void tablebooktxt_Load(object sender, EventArgs e)
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
                if ((fstnameTxt.Text == "") || (phoneNotxt.Text == "") || (gmailtxt.Text == "") || (tablenotxt.Text == "") || (dateTimePicker1.Text==""))
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
                query = "INSERT INTO [dbo].[Reservation] ([Firstname] ,[Lastname] ,[Gmail] ,[Phone],[Date],[TableNo]) VALUES('" + fstnameTxt.Text + "','" + scndnameTxt.Text + "','" + gmailtxt.Text + "','" + phoneNotxt.Text + "','" + dateTimePicker1.Text + "','" + tablenotxt .Text+ "')";
                int row = DataAccess.ExecuteQuery(query);
                if (row > 0)
                {
                    MessageBox.Show("Reservation successful");

                    Tablebook tb = new Tablebook();
                    tb.Show();
                    this.Close();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
