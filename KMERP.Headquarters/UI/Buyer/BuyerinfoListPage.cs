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
    public partial class BuyerinfoListPage : QTabPage
    {
        private HeadquartersDataClassesDataContext context = null;

        public BuyerinfoListPage()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            this.dataGridView1.AutoGenerateColumns = false;

            context = new HeadquartersDataClassesDataContext();

            this.dataGridView1.DataSource = context.buyerinfos;

        }

        private void qButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                context.SubmitChanges();

                MessageBox.Show("操作成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
    }
}
