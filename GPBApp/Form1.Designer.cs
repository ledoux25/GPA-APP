namespace GPBApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CircularProgressBar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.status = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CircularProgressBar1
            // 
            this.CircularProgressBar1.animated = false;
            this.CircularProgressBar1.animationIterval = 5;
            this.CircularProgressBar1.animationSpeed = 300;
            this.CircularProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.CircularProgressBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CircularProgressBar1.BackgroundImage")));
            this.CircularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircularProgressBar1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CircularProgressBar1.LabelVisible = true;
            this.CircularProgressBar1.LineProgressThickness = 8;
            this.CircularProgressBar1.LineThickness = 5;
            this.CircularProgressBar1.Location = new System.Drawing.Point(253, 394);
            this.CircularProgressBar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CircularProgressBar1.MaxValue = 100;
            this.CircularProgressBar1.Name = "CircularProgressBar1";
            this.CircularProgressBar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.CircularProgressBar1.ProgressColor = System.Drawing.Color.Gray;
            this.CircularProgressBar1.Size = new System.Drawing.Size(74, 74);
            this.CircularProgressBar1.TabIndex = 1;
            this.CircularProgressBar1.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.status.Location = new System.Drawing.Point(234, 470);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 15);
            this.status.TabIndex = 2;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(111, 337);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(370, 50);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "La gestion simplifée";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(182, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 204);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 501);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.CircularProgressBar1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar CircularProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCustomLabel status;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}

