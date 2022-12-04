using ComponentFactory.Krypton.Toolkit;
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
    public partial class user_panel : Form
    {
        bool panelOff = true;
        public user_panel()
        {
            InitializeComponent();
            
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
           
             
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            if (panelOff)
            {
                panel4.Show();
                MemberBlock frm = new MemberBlock();
                frm.TopLevel = false;
                frm.Parent = panel4;
                frm.Top = 0;
                frm.Left = 0;
                frm.Size = panel4.ClientSize;
                frm.Dock = DockStyle.Fill;
                frm.BringToFront();
                frm.Show();
                panelOff = false;
                btn_user.BackColor = Color.DimGray;

            }
                else
                {
                //MemberBlock frm = new MemberBlock();
                //frm.TopLevel = false;
                //frm.Parent = panel4;
                //frm.Top = 0;
                //frm.Left = 0;
                //frm.Size = panel4.ClientSize;
                //frm.Dock = DockStyle.Fill;
                //frm.BringToFront();
                //frm.Hide();
                panel4.Hide();
                    btn_user.BackColor = Color.FromArgb(39,39,39);
                panelOff = true;
            }
            }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProjectBlock frm = new ProjectBlock();
            show_panel(frm);
        }

        public void show_panel(Form form,B)
        {
            if (panelOff)
            {
                panel4.Show();
                Form frm = new Form();
                frm.TopLevel = false;
                frm.Parent = panel4;
                frm.Top = 0;
                frm.Left = 0;
                frm.Size = panel4.ClientSize;
                frm.Dock = DockStyle.Fill;
                frm.BringToFront();
                frm.Show();
                panelOff = false;
                btn_project.BackColor = Color.DimGray;

            }
            else
            {
                //MemberBlock frm = new MemberBlock();
                //frm.TopLevel = false;
                //frm.Parent = panel4;
                //frm.Top = 0;
                //frm.Left = 0;
                //frm.Size = panel4.ClientSize;
                //frm.Dock = DockStyle.Fill;
                //frm.BringToFront();
                //frm.Hide();
                panel4.Hide();
                buttonSpecEventArgs.BackColor = Color.FromArgb(39, 39, 39);
                panelOff = true;
            }
        }
    }

}
