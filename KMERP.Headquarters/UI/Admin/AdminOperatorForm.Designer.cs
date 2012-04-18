namespace KMERP.Headquarters.UI.Admin
{
    partial class AdminOperatorForm
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
            this.qRibbonSeparator1 = new Qios.DevSuite.Components.Ribbon.QRibbonSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qButtonSave = new Qios.DevSuite.Components.QButton();
            this.qButtonCancel = new Qios.DevSuite.Components.QButton();
            this.qButtonDel = new Qios.DevSuite.Components.QButton();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qRibbonCaption1
            // 
            this.qRibbonCaption1.Items.Add(this.qRibbonSeparator1);
            this.qRibbonCaption1.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption1.Name = "qRibbonCaption1";
            this.qRibbonCaption1.Size = new System.Drawing.Size(518, 28);
            this.qRibbonCaption1.TabIndex = 0;
            this.qRibbonCaption1.Text = "操作员管理";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(499, 411);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "usercode";
            this.Column1.HeaderText = "操作员编码";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "fullname";
            this.Column2.HeaderText = "操作员名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "password";
            this.Column3.HeaderText = "密码";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "isadmin";
            this.Column4.HeaderText = "是否为管理员";
            this.Column4.Name = "Column4";
            // 
            // qButtonSave
            // 
            this.qButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.qButtonSave.Image = null;
            this.qButtonSave.Location = new System.Drawing.Point(296, 456);
            this.qButtonSave.Name = "qButtonSave";
            this.qButtonSave.Size = new System.Drawing.Size(95, 34);
            this.qButtonSave.TabIndex = 2;
            this.qButtonSave.Text = "保存";
            this.qButtonSave.Click += new System.EventHandler(this.qButtonSave_Click);
            // 
            // qButtonCancel
            // 
            this.qButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.qButtonCancel.Image = null;
            this.qButtonCancel.Location = new System.Drawing.Point(416, 456);
            this.qButtonCancel.Name = "qButtonCancel";
            this.qButtonCancel.Size = new System.Drawing.Size(95, 34);
            this.qButtonCancel.TabIndex = 3;
            this.qButtonCancel.Text = "取消";
            // 
            // qButtonDel
            // 
            this.qButtonDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.qButtonDel.Image = null;
            this.qButtonDel.Location = new System.Drawing.Point(176, 456);
            this.qButtonDel.Name = "qButtonDel";
            this.qButtonDel.Size = new System.Drawing.Size(95, 34);
            this.qButtonDel.TabIndex = 4;
            this.qButtonDel.Text = "删除";
            this.qButtonDel.Click += new System.EventHandler(this.qButtonDel_Click);
            // 
            // AdminOperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 496);
            this.Controls.Add(this.qButtonDel);
            this.Controls.Add(this.qButtonCancel);
            this.Controls.Add(this.qButtonSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.qRibbonCaption1);
            this.MaximizeBox = false;
            this.Name = "AdminOperatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "操作员管理";
            this.Load += new System.EventHandler(this.AdminOperatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption1;
        private Qios.DevSuite.Components.Ribbon.QRibbonSeparator qRibbonSeparator1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Qios.DevSuite.Components.QButton qButtonSave;
        private Qios.DevSuite.Components.QButton qButtonCancel;
        private Qios.DevSuite.Components.QButton qButtonDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
    }
}