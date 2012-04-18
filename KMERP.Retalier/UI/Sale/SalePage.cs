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

namespace KMERP.Retalier.UI.Sale
{
    public partial class SalePage : QTabPage
    {
        private StockDataClassesDataContext context = null;

        private ptypes willSaleClothingBaseInfo = null;

        private operators saler = null;

        private stocks stock = null;

        public SalePage()
        {
            InitializeComponent();


            Init();
        }


        private void Init()
        {
            context = new StockDataClassesDataContext();


            //初始化销售员
            using (UserDataClassesDataContext ucontext = new UserDataClassesDataContext())
            {
                this.qComboBoxSaler.DataSource = ucontext.operators;
                this.qComboBoxSaler.DisplayMember = "fullname";
                this.qComboBoxSaler.SelectedIndex = 0;

                this.saler = this.qComboBoxSaler.SelectedItem as operators;
            }

            //初始化仓库
            this.qComboBoxStock.DataSource = context.stocks;
            this.qComboBoxStock.DisplayMember = "fullname";
            this.qComboBoxStock.SelectedIndex = 0;
            this.stock = this.qComboBoxStock.SelectedItem as stocks;
        }

        private void qTextBoxUserCode_DoubleClick(object sender, EventArgs e)
        {
            string usercode = this.qTextBoxUserCode.Text.Trim();

            UI.Common.SelectClothingForm form = new KMERP.Retalier.UI.Common.SelectClothingForm(usercode, 1);

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.willSaleClothingBaseInfo = form.SelectClothing;
            }

            if (this.willSaleClothingBaseInfo != null)
            {
                this.SetClothingBaseInfo(this.willSaleClothingBaseInfo);

                if (this.stock != null)
                    SetClothingSaleBasInfo();
            }
        }

        /// <summary>
        /// 设置要销售的服装的基本信息
        /// </summary>
        /// <param name="clothing"></param>
        private void SetClothingBaseInfo(ptypes clothing)
        {
            this.qTextBoxUserCode.Text = clothing.usercode;
            this.qTextBoxsize.Text = clothing.psize;
            this.qTextBoxSeason.Text = clothing.seasontype;
            this.qTextBoxColor.Text = clothing.color;
            this.qTextBoxPcode.Text = clothing.pcode;
            this.qTextBoxmanorwoman.Text = clothing.manorwoman;
            this.richTextBoxDes.Text = clothing.cdes;
        }

        private void SetClothingSaleBasInfo()
        {
            Guid cid = this.willSaleClothingBaseInfo.id;
            Guid sid = this.stock.id;

            var cs = (from acs in context.clothinginstocks
                      where acs.pid == cid && acs.sid == sid
                      select acs).First();

            this.labelMinPrice.Text = cs.minsaleprice.ToString();
            this.labelWillPrice.Text = cs.willprice.ToString();
        }

        private void qTextBoxPcode_DoubleClick(object sender, EventArgs e)
        {
            string usercode = this.qTextBoxPcode.Text.Trim();

            UI.Common.SelectClothingForm form = new KMERP.Retalier.UI.Common.SelectClothingForm(usercode, 2);

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.willSaleClothingBaseInfo = form.SelectClothing;
            }

            if (this.willSaleClothingBaseInfo != null)
            {
                this.SetClothingBaseInfo(this.willSaleClothingBaseInfo);

                if (this.stock != null)
                    SetClothingSaleBasInfo();
            }
        }

        private void qComboBoxStock_SelectedItemChanged(object sender, EventArgs e)
        {
            this.stock = this.qComboBoxStock.SelectedItem as stocks;

            if (this.willSaleClothingBaseInfo != null)
                SetClothingSaleBasInfo();
        }

        private void qButtonOk_Click(object sender, EventArgs e)
        {
            if (this.stock != null && this.willSaleClothingBaseInfo != null && this.saler != null)
            {

                PayMoneyForm pForm = new PayMoneyForm(willSaleClothingBaseInfo, saler, stock, this.qTextBoxSalePrice.Text.Trim(), this.qTextBoxSaleCount.Text.Trim());

                try
                {
                    if (pForm.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("销售成功！", "销售提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("数据保存失败！", "销售提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("请完整填写信息！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void qTextBoxSaleCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (this.stock != null && this.willSaleClothingBaseInfo != null && this.saler != null)
                {

                    PayMoneyForm pForm = new PayMoneyForm(willSaleClothingBaseInfo, saler, stock, this.qTextBoxSalePrice.Text.Trim(), this.qTextBoxSaleCount.Text.Trim());

                    try
                    {
                        if (pForm.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("销售成功！", "销售提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("数据保存失败！", "销售提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }
                else
                {
                    MessageBox.Show("请完整填写信息！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }



    }
}
