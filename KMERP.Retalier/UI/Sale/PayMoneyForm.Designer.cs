namespace KMERP.Retalier.UI.Sale
{
    partial class PayMoneyForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qTextBoxSalePrice = new Qios.DevSuite.Components.QTextBox();
            this.qTextBoxGetMoney = new Qios.DevSuite.Components.QTextBox();
            this.qTextBoxToMoney = new Qios.DevSuite.Components.QTextBox();
            this.labelPName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qButtonOk = new Qios.DevSuite.Components.QButton();
            this.label5 = new System.Windows.Forms.Label();
            this.qTextBoxSaleCount = new Qios.DevSuite.Components.QTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSummary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "售价：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "收现：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "找零：";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 2);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // qTextBoxSalePrice
            // 
            this.qTextBoxSalePrice.ColorScheme.TextColor.SetColor("LunaBlue", System.Drawing.Color.Red, false);
            this.qTextBoxSalePrice.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qTextBoxSalePrice.Location = new System.Drawing.Point(63, 93);
            this.qTextBoxSalePrice.Name = "qTextBoxSalePrice";
            this.qTextBoxSalePrice.ReadOnly = true;
            this.qTextBoxSalePrice.Size = new System.Drawing.Size(168, 62);
            this.qTextBoxSalePrice.TabIndex = 5;
            // 
            // qTextBoxGetMoney
            // 
            this.qTextBoxGetMoney.ColorScheme.TextColor.SetColor("LunaBlue", System.Drawing.Color.LightSeaGreen, false);
            this.qTextBoxGetMoney.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qTextBoxGetMoney.Location = new System.Drawing.Point(63, 169);
            this.qTextBoxGetMoney.Name = "qTextBoxGetMoney";
            this.qTextBoxGetMoney.Size = new System.Drawing.Size(355, 62);
            this.qTextBoxGetMoney.TabIndex = 6;
            this.qTextBoxGetMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qTextBoxGetMoney_KeyPress);
            // 
            // qTextBoxToMoney
            // 
            this.qTextBoxToMoney.ColorScheme.TextColor.SetColor("LunaBlue", System.Drawing.Color.Yellow, false);
            this.qTextBoxToMoney.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qTextBoxToMoney.Location = new System.Drawing.Point(63, 245);
            this.qTextBoxToMoney.Name = "qTextBoxToMoney";
            this.qTextBoxToMoney.ReadOnly = true;
            this.qTextBoxToMoney.Size = new System.Drawing.Size(355, 62);
            this.qTextBoxToMoney.TabIndex = 7;
            // 
            // labelPName
            // 
            this.labelPName.AutoSize = true;
            this.labelPName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPName.Location = new System.Drawing.Point(59, 32);
            this.labelPName.Name = "labelPName";
            this.labelPName.Size = new System.Drawing.Size(75, 20);
            this.labelPName.TabIndex = 8;
            this.labelPName.Text = "label5";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(14, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 2);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // qButtonOk
            // 
            this.qButtonOk.Image = null;
            this.qButtonOk.Location = new System.Drawing.Point(286, 350);
            this.qButtonOk.Name = "qButtonOk";
            this.qButtonOk.Size = new System.Drawing.Size(132, 65);
            this.qButtonOk.TabIndex = 9;
            this.qButtonOk.Text = "确定";
            this.qButtonOk.Click += new System.EventHandler(this.qButtonOk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "售价：";
            // 
            // qTextBoxSaleCount
            // 
            this.qTextBoxSaleCount.ColorScheme.TextColor.SetColor("LunaBlue", System.Drawing.Color.Red, false);
            this.qTextBoxSaleCount.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qTextBoxSaleCount.Location = new System.Drawing.Point(284, 93);
            this.qTextBoxSaleCount.Name = "qTextBoxSaleCount";
            this.qTextBoxSaleCount.ReadOnly = true;
            this.qTextBoxSaleCount.Size = new System.Drawing.Size(134, 62);
            this.qTextBoxSaleCount.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(8, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "合计：";
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSummary.ForeColor = System.Drawing.Color.Red;
            this.labelSummary.Location = new System.Drawing.Point(76, 358);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(140, 56);
            this.labelSummary.TabIndex = 13;
            this.labelSummary.Text = "summ";
            // 
            // PayMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 423);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.qTextBoxSaleCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qButtonOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelPName);
            this.Controls.Add(this.qTextBoxToMoney);
            this.Controls.Add(this.qTextBoxGetMoney);
            this.Controls.Add(this.qTextBoxSalePrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PayMoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayMoneyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private Qios.DevSuite.Components.QTextBox qTextBoxSalePrice;
        private Qios.DevSuite.Components.QTextBox qTextBoxGetMoney;
        private Qios.DevSuite.Components.QTextBox qTextBoxToMoney;
        private System.Windows.Forms.Label labelPName;
        private System.Windows.Forms.GroupBox groupBox2;
        private Qios.DevSuite.Components.QButton qButtonOk;
        private System.Windows.Forms.Label label5;
        private Qios.DevSuite.Components.QTextBox qTextBoxSaleCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSummary;
    }
}