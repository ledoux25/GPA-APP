namespace projetbasic
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directTacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directTacheFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directtacheListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directTacheToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.newToolStripMenuItem.Text = "new";
            // 
            // directTacheToolStripMenuItem
            // 
            this.directTacheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directTacheFormToolStripMenuItem,
            this.directtacheListToolStripMenuItem});
            this.directTacheToolStripMenuItem.Name = "directTacheToolStripMenuItem";
            this.directTacheToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.directTacheToolStripMenuItem.Text = "Direct_Tache";
            // 
            // directTacheFormToolStripMenuItem
            // 
            this.directTacheFormToolStripMenuItem.Name = "directTacheFormToolStripMenuItem";
            this.directTacheFormToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.directTacheFormToolStripMenuItem.Text = "Direct_TacheForm";
            this.directTacheFormToolStripMenuItem.Click += new System.EventHandler(this.directTacheFormToolStripMenuItem_Click);
            // 
            // directtacheListToolStripMenuItem
            // 
            this.directtacheListToolStripMenuItem.Name = "directtacheListToolStripMenuItem";
            this.directtacheListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.directtacheListToolStripMenuItem.Text = "Direct_tacheList";
            this.directtacheListToolStripMenuItem.Click += new System.EventHandler(this.directtacheListToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MdiParent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem directTacheToolStripMenuItem;
        private ToolStripMenuItem directTacheFormToolStripMenuItem;
        private ToolStripMenuItem directtacheListToolStripMenuItem;
    }
}