namespace cur
{
    partial class curP
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
            this.components = new System.ComponentModel.Container();
            this.panelC = new System.Windows.Forms.Panel();
            this.tabCur = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewCur = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewF = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addF = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteF = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelC.SuspendLayout();
            this.tabCur.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCur)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewF)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelC
            // 
            this.panelC.Controls.Add(this.tabCur);
            this.panelC.Controls.Add(this.menuStrip1);
            this.panelC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelC.Location = new System.Drawing.Point(0, 0);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(800, 443);
            this.panelC.TabIndex = 0;
            // 
            // tabCur
            // 
            this.tabCur.Controls.Add(this.tabPage1);
            this.tabCur.Controls.Add(this.tabPage2);
            this.tabCur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCur.Location = new System.Drawing.Point(0, 24);
            this.tabCur.Name = "tabCur";
            this.tabCur.SelectedIndex = 0;
            this.tabCur.Size = new System.Drawing.Size(800, 419);
            this.tabCur.TabIndex = 1;
            this.tabCur.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCur_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewCur);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Валюта";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCur
            // 
            this.dataGridViewCur.AllowUserToAddRows = false;
            this.dataGridViewCur.AllowUserToDeleteRows = false;
            this.dataGridViewCur.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCur.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCur.Name = "dataGridViewCur";
            this.dataGridViewCur.ReadOnly = true;
            this.dataGridViewCur.RowTemplate.Height = 25;
            this.dataGridViewCur.Size = new System.Drawing.Size(786, 385);
            this.dataGridViewCur.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewF);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Избранное";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewF
            // 
            this.dataGridViewF.AllowUserToDeleteRows = false;
            this.dataGridViewF.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewF.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewF.Name = "dataGridViewF";
            this.dataGridViewF.ReadOnly = true;
            this.dataGridViewF.RowTemplate.Height = 25;
            this.dataGridViewF.Size = new System.Drawing.Size(786, 385);
            this.dataGridViewF.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addF,
            this.deleteF});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addF
            // 
            this.addF.Name = "addF";
            this.addF.Size = new System.Drawing.Size(142, 20);
            this.addF.Text = "Добавить в избранное";
            this.addF.Click += new System.EventHandler(this.addF_Click);
            // 
            // deleteF
            // 
            this.deleteF.Enabled = false;
            this.deleteF.Name = "deleteF";
            this.deleteF.Size = new System.Drawing.Size(146, 20);
            this.deleteF.Text = "Удалить из избранного";
            this.deleteF.Click += new System.EventHandler(this.deleteF_Click);
            // 
            // currencyBindingSource1
            // 
            this.currencyBindingSource1.DataSource = typeof(cur.Currency);
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(cur.Currency);
            // 
            // curP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.panelC);
            this.Name = "curP";
            this.Text = "Валюта";
            this.panelC.ResumeLayout(false);
            this.panelC.PerformLayout();
            this.tabCur.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCur)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewF)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Panel panelC;
        public TabControl tabCur;
        public TabPage tabPage1;
        public DataGridView dataGridViewCur;
        public TabPage tabPage2;
        public DataGridView dataGridViewF;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addF;
        private ToolStripMenuItem deleteF;
        private BindingSource currencyBindingSource;
        private BindingSource currencyBindingSource1;
    }
}