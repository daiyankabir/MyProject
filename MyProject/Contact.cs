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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void hmbtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Dispose();

        }
    }
}
