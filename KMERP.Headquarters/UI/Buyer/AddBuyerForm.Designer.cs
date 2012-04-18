namespace KMERP.Headquarters.UI.Buyer
{
    partial class AddBuyerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.qTextBoxUserCode = new Qios.DevSuite.Components.QTextBox();
            this.qTextBoxTel = new Qios.DevSuite.Components.QTextBox();
            this.qTextBoxFullName = new Qios.DevSuite.Components.QTextBox();
            this.qTextBoxDes = new Qios.DevSuite.Components.QTextBox();
            this.qTextBoxAddress = new Qios.DevSuite.Components.QTextBox();
            this.qButtonOk = new Qios.DevSuite.Components.QButton();
            this.qButtonCancel = new Qios.DevSuite.Components.QButton();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).BeginInit();
            this.SuspendLayout();
            // 
            // qRibbonCaption1
            // 
            this.qRibbonCaption1.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption1.Name = "qRibbonCaption1";
            this.qRibbonCaption1.Size = new System.Drawing.Size(504, 28);
            this.qRibbonCaption1.TabIndex = 0;
            this.qRibbonCaption1.Text = "添加客户";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "客户编码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "客户名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "联系方式：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "客户地址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "客户描述：";
            // 
            // qTextBoxUserCode
            // 
            this.qTextBoxUserCode.Location = new System.Drawing.Point(83, 57);
            this.qTextBoxUserCode.Name = "qTextBoxUserCode";
            this.qTextBoxUserCode.Size = new System.Drawing.Size(409, 18);
            this.qTextBoxUserCode.TabIndex = 6;
            // 
            // qTextBoxTel
            // 
            this.qTextBoxTel.Location = new System.Drawing.Point(83, 155);
            this.qTextBoxTel.Name = "qTextBoxTel";
            this.qTextBoxTel.Size = new System.Drawing.Size(409, 18);
            this.qTextBoxTel.TabIndex = 7;
            // 
            // qTextBoxFullName
            // 
            this.qTextBoxFullName.Location = new System.Drawing.Point(83, 106);
            this.qTextBoxFullName.Name = "qTextBoxFullName";
            this.qTextBoxFullName.Size = new System.Drawing.Size(409, 18);
            this.qTextBoxFullName.TabIndex = 8;
            // 
            // qTextBoxDes
            // 
            this.qTextBoxDes.Location = new System.Drawing.Point(83, 253);
            this.qTextBoxDes.Name = "qTextBoxDes";
            this.qTextBoxDes.Size = new System.Drawing.Size(409, 18);
            this.qTextBoxDes.TabIndex = 9;
            // 
            // qTextBoxAddress
            // 
            this.qTextBoxAddress.Location = new System.Drawing.Point(83, 204);
            this.qTextBoxAddress.Name = "qTextBoxAddress";
            this.qTextBoxAddress.Size = new System.Drawing.Size(409, 18);
            this.qTextBoxAddress.TabIndex = 10;
            // 
            // qButtonOk
            // 
            this.qButtonOk.Image = null;
            this.qButtonOk.Location = new System.Drawing.Point(323, 309);
            this.qButtonOk.Name = "qButtonOk";
            this.qButtonOk.Size = new System.Drawing.Size(75, 23);
            this.qButtonOk.TabIndex = 11;
            this.qButtonOk.Text = "确定";
            this.qButtonOk.Click += new System.EventHandler(this.qButtonOk_Click);
            // 
            // qButtonCancel
            // 
            this.qButtonCancel.Image = null;
            this.qButtonCancel.Location = new System.Drawing.Point(417, 309);
            this.qButtonCancel.Name = "qButtonCancel";
            this.qButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.qButtonCancel.TabIndex = 12;
            this.qButtonCancel.Text = "取消";
            this.qButtonCancel.Click += new System.EventHandler(this.qButtonCancel_Click);
            // 
            // AddBuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 342);
            this.Controls.Add(this.qButtonCancel);
            this.Controls.Add(this.qButtonOk);
            this.Controls.Add(this.qTextBoxAddress);
            this.Controls.Add(this.qTextBoxDes);
            this.Controls.Add(this.qTextBoxFullName);
            this.Controls.Add(this.qTextBoxTel);
            this.Controls.Add(this.qTextBoxUserCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qRibbonCaption1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddBuyerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加客户";
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Qios.DevSuite.Components.QTextBox qTextBoxUserCode;
        private Qios.DevSuite.Components.QTextBox qTextBoxTel;
        private Qios.DevSuite.Components.QTextBox qTextBoxFullName;
        private Qios.DevSuite.Components.QTextBox qTextBoxDes;
        private Qios.DevSuite.Components.QTextBox qTextBoxAddress;
        private Qios.DevSuite.Components.QButton qButtonOk;
        private Qios.DevSuite.Components.QButton qButtonCancel;
    }
}