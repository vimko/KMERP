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
    public partial class ClothingBaseInfoListPage : QTabPage
    {
        private StockDataClassesDataContext context = null;

        public ClothingBaseInfoListPage()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            this.dataGridView1.AutoGenerateColumns = false;

            context = new StockDataClassesDataContext();

            this.dataGridView1.DataSource = context.ptypes;
        }


        private void qButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                context.SubmitChanges();

                MessageBox.Show("保存成功！","操作提示",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw;
            }
        }
    }
}
