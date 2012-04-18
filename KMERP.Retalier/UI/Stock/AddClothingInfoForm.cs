using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Qios.DevSuite.Components;
using Qios.DevSuite.Components.Ribbon;

using KMERP.Retalier.DAL;

namespace KMERP.Retalier.UI.Stock
{
    public partial class AddClothingInfoForm : QRibbonForm
    {
        //private DAL.StockDataClassesDataContext context = null;

        public AddClothingInfoForm()
        {
            InitializeComponent();

            
        }

        private void qButtonOk_Click(object sender, EventArgs e)
        {
            ptypes clothing = new ptypes();

            if (this.qTextBoxFullName.Text.Trim().Length == 0 || this.qTextBoxUserCode.Text.Trim().Length == 0 || this.qTextBoxPcode.Text.Trim().Length == 0)
            {
                MessageBox.Show("请正确填写信息","操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.qTextBoxFullName.Focus();
                return;
            }

            clothing.fullname = this.qTextBoxFullName.Text.Trim();
            clothing.usercode = this.qTextBoxUserCode.Text.Trim();
            clothing.pcode = this.qTextBoxPcode.Text.Trim();
            clothing.psize = this.qTextBoxsize.Text.Trim();
            clothing.color = this.qTextBoxColor.Text.Trim();
            clothing.seasontype = this.qTextBoxSeason.Text.Trim();
            clothing.manorwoman = this.qComboBoxManWoman.SelectedItem.ToString();
            clothing.cdes = this.richTextBoxDes.Text;

            try
            {
                using (DAL.StockDataClassesDataContext context = new StockDataClassesDataContext())
                {
                    context.ptypes.InsertOnSubmit(clothing);

                    context.SubmitChanges();
                }

                MessageBox.Show("添加成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.qTextBoxFullName.Text = "";
                this.qTextBoxPcode.Text = "";
                this.qTextBoxUserCode.Text = "";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void qButtonCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
