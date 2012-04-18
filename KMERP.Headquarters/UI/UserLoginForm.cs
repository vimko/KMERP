using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Qios.DevSuite.Components;

namespace KMERP.Headquarters.UI
{
    public partial class UserLoginForm : Qios.DevSuite.Components.Ribbon.QRibbonForm
    {
        /// <summary>
        /// 是否成功登录的标志
        /// </summary>
        public bool IsLoginSucess { get; set; }

        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void qButtonLogin_Click(object sender, EventArgs e)
        {
            DAL.UserDataClassesDataContext context = new KMERP.Headquarters.DAL.UserDataClassesDataContext();

            string username = this.qTextBoxUsername.Text.Trim();

            string password = this.qTextBoxPassword.Text.Trim();

            var checku = (from user in context.operators where user.usercode == username && user.password == password select user).FirstOrDefault();

            if (checku == null)
            {
                MessageBox.Show("登录失败\n请输入正确的用户信息","操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.qTextBoxUsername.Focus();
                this.IsLoginSucess = false;
                return;
            }

            this.IsLoginSucess = true;
            this.DialogResult = DialogResult.OK;
        }
    }
}