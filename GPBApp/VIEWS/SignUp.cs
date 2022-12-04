using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPBApp.VIEWS
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Voulez vous vraiment quitter l'application ?", "QUITTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Login frm = new Login();
                this.Close();
                Application.Exit();
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();

            this.Close();
                 
        }
    }
}
