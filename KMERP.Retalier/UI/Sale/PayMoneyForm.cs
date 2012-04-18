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
    public partial class PayMoneyForm : QRibbonForm
    {
        private ptypes clothing = null;
        private operators saler = null;
        private stocks stock = null;

        private string saleprice = null;
        private string salecount = null;

        private StockDataClassesDataContext context = null;

        public PayMoneyForm(ptypes clothing, operators saler, stocks stock, string saleprice, string salecount)
        {
            InitializeComponent();

            this.clothing = clothing;
            this.saler = saler;
            this.stock = stock;
            this.saleprice = saleprice;
            this.salecount = salecount;



            Init();

            this.qTextBoxGetMoney.Text = "";
            this.qTextBoxGetMoney.Focus();
        }


        private void Init()
        {
            this.labelPName.Text = clothing.fullname;

            this.qTextBoxSalePrice.Text = saleprice;
            this.qTextBoxSaleCount.Text = salecount;

            try
            {
                decimal price = Convert.ToDecimal(saleprice);
                decimal count = Convert.ToDecimal(salecount);

                decimal sum = decimal.Multiply(price, count);

                this.labelSummary.Text = decimal.Round(sum, 2).ToString();
            }
            catch (Exception)
            {
            }

            context = new StockDataClassesDataContext();
        }

        private void qTextBoxGetMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                try
                {
                    decimal sp = Convert.ToDecimal(this.saleprice);
                    decimal sm = Convert.ToDecimal(this.qTextBoxGetMoney.Text.Trim());

                    this.qTextBoxToMoney.Text = decimal.Subtract(sm, sp).ToString();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void qButtonOk_Click(object sender, EventArgs e)
        {
            try
            {

                sales salef = new sales();

                salef.id = Guid.NewGuid();
                salef.cid = this.clothing.id;
                salef.pid = this.saler.id;
                salef.sid = this.stock.id;
                salef.saleprice = Convert.ToDecimal(this.saleprice);
                salef.salecount = Convert.ToInt32(this.salecount);
                salef.totalmoney = decimal.Round(decimal.Multiply(Convert.ToDecimal(this.saleprice), Convert.ToDecimal(this.salecount)));
                salef.saledate = DateTime.Now;

                context.sales.InsertOnSubmit(salef);

                //送去库存数量
                clothinginstocks cInS = (from cs in context.clothinginstocks
                                         where cs.pid == this.clothing.id && cs.sid == this.stock.id
                                         select cs).First();
                cInS.hasoutstock += 1;

                context.SubmitChanges();

                this.DialogResult = DialogResult.OK;

            }
            catch (Exception)
            {
                //this.DialogResult = DialogResult.Cancel;
                throw;
            }


        }
    }
}
