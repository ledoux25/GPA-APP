namespace projetbasic.Views.Direct_Tache
{
    partial class Direct_TacheList
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.refresh = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delate = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.description,
            this.date,
            this.heure,
            this.id,
            this.action,
            this.dataGridViewCheckBoxColumn1});
            this.DataGridView.Location = new System.Drawing.Point(12, 232);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 29;
            this.DataGridView.Size = new System.Drawing.Size(895, 188);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "ID";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // description
            // 
            this.description.Frozen = true;
            this.description.HeaderText = "nom";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 125;
            // 
            // date
            // 
            this.date.Frozen = true;
            this.date.HeaderText = "description";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // heure
            // 
            this.heure.Frozen = true;
            this.heure.HeaderText = "date";
            this.heure.MinimumWidth = 6;
            this.heure.Name = "heure";
            this.heure.Width = 125;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "heure";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // action
            // 
            this.action.HeaderText = "id_projet";
            this.action.MinimumWidth = 6;
            this.action.Name = "action";
            this.action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.action.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "action";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(12, 116);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(119, 29);
            this.refresh.TabIndex = 1;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(205, 116);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(140, 29);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delate
            // 
            this.delate.Location = new System.Drawing.Point(413, 116);
            this.delate.Name = "delate";
            this.delate.Size = new System.Drawing.Size(147, 29);
            this.delate.TabIndex = 3;
            this.delate.Text = "Delate";
            this.delate.UseVisualStyleBackColor = true;
            this.delate.Click += new System.EventHandler(this.delate_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(672, 116);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(219, 29);
            this.print.TabIndex = 4;
            this.print.Text = "print";
            this.print.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(177, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "DIRECT_TACHES";
            // 
            // textBox_Tb
            // 
            this.textBox_Tb.Location = new System.Drawing.Point(12, 181);
            this.textBox_Tb.Name = "textBox_Tb";
            this.textBox_Tb.Size = new System.Drawing.Size(879, 27);
            this.textBox_Tb.TabIndex = 6;
            this.textBox_Tb.Text = "Search....";
            // 
            // Direct_TacheList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.textBox_Tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.print);
            this.Controls.Add(this.delate);
            this.Controls.Add(this.update);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.DataGridView);
            this.Name = "Direct_TacheList";
            this.Text = "Direct_TacheList";
            this.Load += new System.EventHandler(this.Direct_TacheList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button refresh;
        private Button update;
        private Button delate;
        private Button print;
        private Label label1;
        public DataGridView DataGridView;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn heure;
        private DataGridViewTextBoxColumn id;
        private DataGridViewButtonColumn action;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        public TextBox textBox_Tb;
    }
}