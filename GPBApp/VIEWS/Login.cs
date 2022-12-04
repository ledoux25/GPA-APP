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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

      
  private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
        }

        private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_mail.text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Voulez vous vraiment quitter l'application ?", "QUITTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(r == DialogResult.Yes)
            {
                Login frm = new Login();
                this.Close();
                Application.Exit();
            }

            
        }

        private void link_new_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp frm = new SignUp();
            frm.ShowDialog();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            user_panel frm = new user_panel();
            frm.ShowDialog();

            this.Hide();

        }
    }
}
