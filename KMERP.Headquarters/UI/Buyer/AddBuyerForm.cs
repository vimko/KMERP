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

using KMERP.Headquarters.DAL;

namespace KMERP.Headquarters.UI.Buyer
{
    public partial class AddBuyerForm : QRibbonForm
    {
        public AddBuyerForm()
        {
            InitializeComponent();
        }

        private void qButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                buyerinfos buyer = new buyerinfos();

                buyer.id = Guid.NewGuid();
                buyer.usercode = this.qTextBoxUserCode.Text.Trim();
                buyer.fullname = this.qTextBoxFullName.Text.Trim();
                buyer.tel = this.qTextBoxTel.Text.Trim();
                buyer.address = this.qTextBoxAddress.Text.Trim();
                buyer.odes = this.qTextBoxDes.Text.Trim();

                using (HeadquartersDataClassesDataContext context = new HeadquartersDataClassesDataContext())
                {
                    context.buyerinfos.InsertOnSubmit(buyer);

                    context.SubmitChanges();
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void qButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
