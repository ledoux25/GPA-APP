namespace projetbasic.Views.Direct_Tache
{
    partial class Direct_TacheForm
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
            this.texte_date = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.texteheure = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textedescr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.textid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelnom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // texte_date
            // 
            this.texte_date.Location = new System.Drawing.Point(109, 223);
            this.texte_date.Name = "texte_date";
            this.texte_date.Size = new System.Drawing.Size(583, 27);
            this.texte_date.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "date";
            // 
            // texteheure
            // 
            this.texteheure.Location = new System.Drawing.Point(109, 284);
            this.texteheure.Name = "texteheure";
            this.texteheure.Size = new System.Drawing.Size(583, 27);
            this.texteheure.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "heure";
            // 
            // textedescr
            // 
            this.textedescr.Location = new System.Drawing.Point(109, 170);
            this.textedescr.Name = "textedescr";
            this.textedescr.Size = new System.Drawing.Size(583, 27);
            this.textedescr.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "description";
            // 
            // textenom
            // 
            this.textenom.Location = new System.Drawing.Point(109, 117);
            this.textenom.Name = "textenom";
            this.textenom.Size = new System.Drawing.Size(583, 27);
            this.textenom.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "nom";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(598, 409);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(94, 29);
            this.btn_submit.TabIndex = 16;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(109, 348);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(583, 27);
            this.textid.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "idprojet";
            // 
            // labelnom
            // 
            this.labelnom.AutoSize = true;
            this.labelnom.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelnom.Location = new System.Drawing.Point(228, 27);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(358, 54);
            this.labelnom.TabIndex = 19;
            this.labelnom.Text = "New Direct_Tache";
            // 
            // Direct_TacheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelnom);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.textenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textedescr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texteheure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texte_date);
            this.Controls.Add(this.label10);
            this.Name = "Direct_TacheForm";
            this.Text = "Direct_TacheForm";
            this.Load += new System.EventHandler(this.Direct_TacheForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label10;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelnom;
        public TextBox texte_date;
        public TextBox texteheure;
        public TextBox textedescr;
        public TextBox textenom;
        public Button btn_submit;
        public TextBox textid;
    }
}