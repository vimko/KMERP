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

namespace KMERP.Headquarters.UI.Product
{
    public partial class ClothingBaseInfoListPage : QTabPage
    {
        private HeadquartersDataClassesDataContext context = null;

        public ClothingBaseInfoListPage()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            this.dataGridView1.AutoGenerateColumns = false;

            context = new HeadquartersDataClassesDataContext();

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
