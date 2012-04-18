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
    public partial class AdminStockForm : QRibbonForm
    {
        private StockDataClassesDataContext context = null;

        public AdminStockForm()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            this.dataGridView1.AutoGenerateColumns = false;

            context = new StockDataClassesDataContext();

            this.dataGridView1.DataSource = context.stocks;
        }

        private void qButtonDel_Click(object sender, EventArgs e)
        {
            DataGridViewRow srow = this.dataGridView1.SelectedRows[0];

            if (srow == null)
                return;

            this.dataGridView1.Rows.Remove(srow);
        }

        private void qButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                context.SubmitChanges();

                MessageBox.Show("保存成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
