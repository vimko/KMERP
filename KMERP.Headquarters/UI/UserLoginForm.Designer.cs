namespace KMERP.Headquarters.UI
{
    partial class UserLoginForm
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
            this.qButtonLogin = new Qios.DevSuite.Components.QButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qTextBoxUsername = new Qios.DevSuite.Components.QTextBox();
            this.qTextBoxPassword = new Qios.DevSuite.Components.QTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).BeginInit();
            this.SuspendLayout();
            // 
            // qRibbonCaption1
            // 
            this.qRibbonCaption1.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption1.Name = "qRibbonCaption1";
            this.qRibbonCaption1.Size = new System.Drawing.Size(347, 28);
            this.qRibbonCaption1.TabIndex = 0;
            this.qRibbonCaption1.Text = "操作员登录";
            // 
            // qButtonLogin
            // 
            this.qButtonLogin.Image = null;
            this.qButtonLogin.Location = new System.Drawing.Point(246, 182);
            this.qButtonLogin.Name = "qButtonLogin";
            this.qButtonLogin.Size = new System.Drawing.Size(75, 36);
            this.qButtonLogin.TabIndex = 1;
            this.qButtonLogin.Text = "登录";
            this.qButtonLogin.Click += new System.EventHandler(this.qButtonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密  码：";
            // 
            // qTextBoxUsername
            // 
            this.qTextBoxUsername.Location = new System.Drawing.Point(114, 77);
            this.qTextBoxUsername.Name = "qTextBoxUsername";
            this.qTextBoxUsername.Size = new System.Drawing.Size(207, 18);
            this.qTextBoxUsername.TabIndex = 4;
            // 
            // qTextBoxPassword
            // 
            this.qTextBoxPassword.Location = new System.Drawing.Point(114, 127);
            this.qTextBoxPassword.Name = "qTextBoxPassword";
            this.qTextBoxPassword.PasswordChar = '*';
            this.qTextBoxPassword.Size = new System.Drawing.Size(207, 18);
            this.qTextBoxPassword.TabIndex = 5;
            // 
            // UserLoginForm
            // 
            this.ClientSize = new System.Drawing.Size(347, 230);
            this.Controls.Add(this.qTextBoxPassword);
            this.Controls.Add(this.qTextBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qButtonLogin);
            this.Controls.Add(this.qRibbonCaption1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "操作员登录";
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption1;
        private Qios.DevSuite.Components.QButton qButtonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Qios.DevSuite.Components.QTextBox qTextBoxUsername;
        private Qios.DevSuite.Components.QTextBox qTextBoxPassword;
    }
}