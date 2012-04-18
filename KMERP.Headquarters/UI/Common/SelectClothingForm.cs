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

namespace KMERP.Headquarters.UI.Common
{
    public partial class SelectClothingForm : QRibbonForm
    {
        private ptypes selectClothing = null;

        private HeadquartersDataClassesDataContext context = null;

        /// <summary>
        /// 选择的服装
        /// </summary>
        public ptypes SelectClothing
        {
            get
            {
                return this.selectClothing;
            }
        }

        public SelectClothingForm()
        {
            InitializeComponent();

            Init();
        }

        /// <summary>
        /// 查询服装
        /// <remarks>codetype,1.usercode,2.pcode</remarks>
        /// </summary>
        /// <param name="usercode"></param>
        /// <param name="codetype"></param>
        public SelectClothingForm(string code,int codetype)
        {
            InitializeComponent();

            this.dataGridView1.AutoGenerateColumns = false;

            InitDataGrid(code, codetype);

        }


        private void InitDataGrid(string usercode, int codetype)
        {
            context = new HeadquartersDataClassesDataContext();

            if (codetype == 1)
            {
                var ps = from ap in context.ptypes
                         where ap.usercode.Contains(usercode)
                         select ap;

                this.dataGridView1.DataSource = ps;
            }
            else if (codetype == 2)
            {
                var ps = from ap in context.ptypes
                         where ap.pcode.Contains(usercode)
                         select ap;

                this.dataGridView1.DataSource = ps;
            }
        }

        private void Init()
        {
            this.dataGridView1.AutoGenerateColumns = false;

            context = new HeadquartersDataClassesDataContext();

            this.dataGridView1.DataSource = context.ptypes;
            
        }

        private void qButtonOk_Click(object sender, EventArgs e)
        {
            DataGridViewRow srow = this.dataGridView1.SelectedRows[0];

            if (srow == null)
            {
                MessageBox.Show("请选择服装!");
                return;
            }

            string uc = srow.Cells["Column1"].Value.ToString();

            this.selectClothing = context.ptypes.Where(p => p.usercode == uc).First();

            this.DialogResult = DialogResult.OK;
        }

        private void qButtonCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
