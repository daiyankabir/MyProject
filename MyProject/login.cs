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
    public partial class Logintxt : Form
    {
        public Logintxt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Employee where UserName='" + usertext.Text +
                                              "' and Password='" + passwordtext.Text + "'");

            if (dt.Rows.Count != 1)
            {
                MessageBox.Show("Invalid UserName or Password");
                return;
            }

            string type = dt.Rows[0]["Type"].ToString();
            if (type == "Manager")
            {
                Manager f1 = new Manager();
                f1.Show();
                this.Close();
                this.Dispose();
            }
            else if (type == "Admin")
            {
                Admin ep = new Admin();
                ep.Show();
                this.Close();
                this.Dispose();
            }
            else if (type == "Waiter")
            {
                EmployeePage ep = new EmployeePage();
                ep.Show();
                this.Close();
                this.Dispose();
            }
            else if (type == "Staff")
            {
                EmployeePage ep = new EmployeePage();
                ep.Show();
                this.Close();
                this.Dispose();
            }
        }

        private void Idtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logintxt_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
            this.Dispose();
        }
    }
}
