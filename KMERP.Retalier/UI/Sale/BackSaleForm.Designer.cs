namespace KMERP.Retalier.UI.Sale
{
    partial class BackSaleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qTextBoxSaleId = new Qios.DevSuite.Components.QTextBox();
            this.qComboBoxStock = new Qios.DevSuite.Components.QComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qTextBoxBackMoney = new Qios.DevSuite.Components.QTextBox();
            this.qButtonOk = new Qios.DevSuite.Components.QButton();
            this.qRibbonCaption1 = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            this.qButtonCancle = new Qios.DevSuite.Components.QButton();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "销售编码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "退入仓库：";
            // 
            // qTextBoxSaleId
            // 
            this.qTextBoxSaleId.Location = new System.Drawing.Point(155, 49);
            this.qTextBoxSaleId.Name = "qTextBoxSaleId";
            this.qTextBoxSaleId.Size = new System.Drawing.Size(335, 18);
            this.qTextBoxSaleId.TabIndex = 2;
            // 
            // qComboBoxStock
            // 
            this.qComboBoxStock.Location = new System.Drawing.Point(155, 110);
            this.qComboBoxStock.Name = "qComboBoxStock";
            this.qComboBoxStock.Size = new System.Drawing.Size(335, 18);
            this.qComboBoxStock.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "退货价格：";
            // 
            // qTextBoxBackMoney
            // 
            this.qTextBoxBackMoney.Location = new System.Drawing.Point(155, 177);
            this.qTextBoxBackMoney.Name = "qTextBoxBackMoney";
            this.qTextBoxBackMoney.Size = new System.Drawing.Size(335, 18);
            this.qTextBoxBackMoney.TabIndex = 5;
            // 
            // qButtonOk
            // 
            this.qButtonOk.Image = null;
            this.qButtonOk.Location = new System.Drawing.Point(319, 246);
            this.qButtonOk.Name = "qButtonOk";
            this.qButtonOk.Size = new System.Drawing.Size(75, 23);
            this.qButtonOk.TabIndex = 6;
            this.qButtonOk.Text = "确定";
            this.qButtonOk.Click += new System.EventHandler(this.qButtonOk_Click);
            // 
            // qRibbonCaption1
            // 
            this.qRibbonCaption1.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption1.Name = "qRibbonCaption1";
            this.qRibbonCaption1.Size = new System.Drawing.Size(519, 28);
            this.qRibbonCaption1.TabIndex = 7;
            this.qRibbonCaption1.Text = "销售退货";
            // 
            // qButtonCancle
            // 
            this.qButtonCancle.Image = null;
            this.qButtonCancle.Location = new System.Drawing.Point(415, 246);
            this.qButtonCancle.Name = "qButtonCancle";
            this.qButtonCancle.Size = new System.Drawing.Size(75, 23);
            this.qButtonCancle.TabIndex = 8;
            this.qButtonCancle.Text = "取消";
            this.qButtonCancle.Click += new System.EventHandler(this.qButtonCancle_Click);
            // 
            // BackSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 300);
            this.Controls.Add(this.qButtonCancle);
            this.Controls.Add(this.qRibbonCaption1);
            this.Controls.Add(this.qButtonOk);
            this.Controls.Add(this.qTextBoxBackMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qComboBoxStock);
            this.Controls.Add(this.qTextBoxSaleId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BackSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售退货";
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Qios.DevSuite.Components.QTextBox qTextBoxSaleId;
        private Qios.DevSuite.Components.QComboBox qComboBoxStock;
        private System.Windows.Forms.Label label3;
        private Qios.DevSuite.Components.QTextBox qTextBoxBackMoney;
        private Qios.DevSuite.Components.QButton qButtonOk;
        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption1;
        private Qios.DevSuite.Components.QButton qButtonCancle;
    }
}