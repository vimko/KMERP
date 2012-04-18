namespace KMERP.Headquarters.UI.Stock
{
    partial class AdminStockForm
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
            this.qRibbonCaption1 = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qButtonDel = new Qios.DevSuite.Components.QButton();
            this.qButtonSave = new Qios.DevSuite.Components.QButton();
            this.qButtonCancle = new Qios.DevSuite.Components.QButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qRibbonCaption1
            // 
            this.qRibbonCaption1.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption1.Name = "qRibbonCaption1";
            this.qRibbonCaption1.Size = new System.Drawing.Size(537, 28);
            this.qRibbonCaption1.TabIndex = 0;
            this.qRibbonCaption1.Text = "仓库管理";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(512, 403);
            this.dataGridView1.TabIndex = 1;
            // 
            // qButtonDel
            // 
            this.qButtonDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.qButtonDel.Image = null;
            this.qButtonDel.Location = new System.Drawing.Point(265, 464);
            this.qButtonDel.Name = "qButtonDel";
            this.qButtonDel.Size = new System.Drawing.Size(75, 35);
            this.qButtonDel.TabIndex = 2;
            this.qButtonDel.Text = "删除";
            this.qButtonDel.Click += new System.EventHandler(this.qButtonDel_Click);
            // 
            // qButtonSave
            // 
            this.qButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.qButtonSave.Image = null;
            this.qButtonSave.Location = new System.Drawing.Point(357, 464);
            this.qButtonSave.Name = "qButtonSave";
            this.qButtonSave.Size = new System.Drawing.Size(75, 35);
            this.qButtonSave.TabIndex = 3;
            this.qButtonSave.Text = "保存";
            this.qButtonSave.Click += new System.EventHandler(this.qButtonSave_Click);
            // 
            // qButtonCancle
            // 
            this.qButtonCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.qButtonCancle.Image = null;
            this.qButtonCancle.Location = new System.Drawing.Point(449, 464);
            this.qButtonCancle.Name = "qButtonCancle";
            this.qButtonCancle.Size = new System.Drawing.Size(75, 35);
            this.qButtonCancle.TabIndex = 4;
            this.qButtonCancle.Text = "取消";
            this.qButtonCancle.Click += new System.EventHandler(this.qButtonCancle_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "usercode";
            this.Column1.HeaderText = "仓库编码";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "fullname";
            this.Column2.HeaderText = "仓库名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "sdes";
            this.Column3.HeaderText = "仓库描述";
            this.Column3.Name = "Column3";
            // 
            // AdminStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 511);
            this.Controls.Add(this.qButtonCancle);
            this.Controls.Add(this.qButtonSave);
            this.Controls.Add(this.qButtonDel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.qRibbonCaption1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "仓库管理";
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Qios.DevSuite.Components.QButton qButtonDel;
        private Qios.DevSuite.Components.QButton qButtonSave;
        private Qios.DevSuite.Components.QButton qButtonCancle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}