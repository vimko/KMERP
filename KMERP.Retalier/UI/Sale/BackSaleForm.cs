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
    public partial class BackSaleForm :  QRibbonForm
    {

        private StockDataClassesDataContext context = null;

        public BackSaleForm()
        {
            InitializeComponent();

            Init();
        }


        private void Init()
        {
            context = new StockDataClassesDataContext();

            this.qComboBoxStock.DataSource = context.stocks;
            this.qComboBoxStock.DisplayMember = "fullname";
            this.qComboBoxStock.SelectedIndex = 0;
        }

        private void qButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                string bid = this.qTextBoxSaleId.Text.Trim();

                sales hasSale = context.sales.Where(s => s.id == new Guid(bid)).First();

                stocks backStock = this.qComboBoxStock.SelectedItem as stocks;

                backsales backSale = new backsales();

                backSale.id = Guid.NewGuid();
                backSale.saleid = hasSale.id;
                backSale.tosid = backStock.id;
                backSale.cid = hasSale.cid;
                backSale.backmoney = Convert.ToDecimal(this.qTextBoxBackMoney.Text.Trim());
                backSale.backdate = DateTime.Now;

                context.backsales.InsertOnSubmit(backSale);


                //clothinginstocks cInStock = new clothinginstocks();

                clothinginstocks cInStock = (from cs in context.clothinginstocks
                                where cs.pid == hasSale.cid && cs.sid == hasSale.sid
                                select cs).First();

                cInStock.incount += 1;

                context.SubmitChanges();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                //MessageBox.Show(ee.Message, "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void qButtonCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
