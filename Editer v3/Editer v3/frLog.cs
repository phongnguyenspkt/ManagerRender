using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editer_v3
{
    public partial class frLog : Form
    {
        public frLog()
        {
            InitializeComponent();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            string name = this.txtname.Text;
            if (name == "hacker")
            {
                txtpass.Visible = true;
                txtpass.Focus();
                txtname.Visible = false;
            }
               
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            string pass = this.txtpass.Text;
            if(pass=="pc")
            {
                this.Hide();
                Form a = new frMain();
                a.Show();
            }
        }

        private void frLog_Load(object sender, EventArgs e)
        {

        }
    }
}
