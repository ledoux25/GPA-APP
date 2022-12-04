using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPBApp.VIEWS;

namespace GPBApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           user_panel frm = new user_panel();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CircularProgressBar1.Value += 1;
            // circularProgressBar1.Text =circularProgressBar1.Value.ToString() +"%";
            //label_charge.Text = CircularProgressBar1.Value.ToString();

            if (CircularProgressBar1.Value == 100)
            {

                timer1.Enabled = false;

                Login login = new Login();
                login.Show();
                this.Hide();
            }

            if (CircularProgressBar1.Value == 2)
            {
                status.Text = "Lancement des modules...";
            }


            if (CircularProgressBar1.Value == 15)
            {
                status.Text = "Restitution des données...";
            }

            if (CircularProgressBar1.Value == 40)
            {
                status.Text = "Oganisation des interface...";
            }

            if (CircularProgressBar1.Value == 60)
            {
                status.Text = "Creation des graphe...";
            }

            if (CircularProgressBar1.Value == 90)
            {
                status.Text = "LANCEMENT .......";
            }

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
    }

