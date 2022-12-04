namespace GPBApp.VIEWS
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_mail = new Bunifu.Framework.UI.BunifuTextbox();
            this.txt_password = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.link_new = new System.Windows.Forms.LinkLabel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_mail
            // 
            this.txt_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txt_mail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_mail.BackgroundImage")));
            this.txt_mail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mail.ForeColor = System.Drawing.Color.Honeydew;
            this.txt_mail.Icon = ((System.Drawing.Image)(resources.GetObject("txt_mail.Icon")));
            this.txt_mail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_mail.Location = new System.Drawing.Point(385, 183);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(274, 45);
            this.txt_mail.TabIndex = 1;
            this.txt_mail.text = "Email";
            this.txt_mail.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            this.txt_mail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuTextbox1_MouseClick);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txt_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_password.BackgroundImage")));
            this.txt_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Icon = ((System.Drawing.Image)(resources.GetObject("txt_password.Icon")));
            this.txt_password.Location = new System.Drawing.Point(385, 261);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(274, 45);
            this.txt_password.TabIndex = 2;
            this.txt_password.text = "Password";
            this.txt_password.OnTextChange += new System.EventHandler(this.bunifuTextbox2_OnTextChange);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 516);
            this.panel1.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.BorderRadius = 5;
            this.btn_login.ButtonText = "           LOGIN";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.DisabledColor = System.Drawing.Color.Gray;
            this.btn_login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_login.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_login.Iconimage")));
            this.btn_login.Iconimage_right = null;
            this.btn_login.Iconimage_right_Selected = null;
            this.btn_login.Iconimage_Selected = null;
            this.btn_login.IconMarginLeft = 0;
            this.btn_login.IconMarginRight = 0;
            this.btn_login.IconRightVisible = true;
            this.btn_login.IconRightZoom = 0D;
            this.btn_login.IconVisible = true;
            this.btn_login.IconZoom = 90D;
            this.btn_login.IsTab = false;
            this.btn_login.Location = new System.Drawing.Point(425, 340);
            this.btn_login.Name = "btn_login";
            this.btn_login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_login.OnHovercolor = System.Drawing.Color.DimGray;
            this.btn_login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_login.selected = false;
            this.btn_login.Size = new System.Drawing.Size(199, 41);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "           LOGIN";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Textcolor = System.Drawing.Color.White;
            this.btn_login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // link_new
            // 
            this.link_new.ActiveLinkColor = System.Drawing.Color.Gray;
            this.link_new.AutoSize = true;
            this.link_new.LinkColor = System.Drawing.Color.White;
            this.link_new.Location = new System.Drawing.Point(491, 392);
            this.link_new.Name = "link_new";
            this.link_new.Size = new System.Drawing.Size(61, 13);
            this.link_new.TabIndex = 5;
            this.link_new.TabStop = true;
            this.link_new.Text = "Not yet in ?";
            this.link_new.VisitedLinkColor = System.Drawing.Color.Gray;
            this.link_new.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_new_LinkClicked);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(675, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 6;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hide.FlatAppearance.BorderSize = 0;
            this.btn_hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hide.Location = new System.Drawing.Point(641, -13);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(30, 43);
            this.btn_hide.TabIndex = 7;
            this.btn_hide.Text = "-";
            this.btn_hide.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(704, 516);
            this.ControlBox = false;
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.link_new);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_mail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTextbox txt_mail;
        private Bunifu.Framework.UI.BunifuTextbox txt_password;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_login;
        private System.Windows.Forms.LinkLabel link_new;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_hide;
    }
}