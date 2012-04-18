using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using KMERP.Retalier.DAL;

using Qios.DevSuite.Components;
using Qios.DevSuite.Components.Ribbon;

namespace KMERP.Retalier.UI.Stock
{
    public partial class StockListPage : QTabPage
    {
        private StockDataClassesDataContext context = null;

        private ptypes filterClothing = null;

        public StockListPage()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            this.dataGridView1.AutoGenerateColumns = false;

            context = new StockDataClassesDataContext();

            this.qComboBoxStock.DataSource = context.stocks;
            this.qComboBoxStock.DisplayMember = "fullname";
            this.qComboBoxStock.SelectedIndex = 0;

            stocks selectStock = (stocks)this.qComboBoxStock.SelectedItem;

            var scss = from scs in context.clothinginstocks
                       join sc in context.ptypes on scs.pid equals sc.id
                       where scs.sid == selectStock.id && scs.incount - scs.hasoutstock > 0
                       select new { pcode = sc.usercode, pfullname = sc.fullname, sfullname = selectStock.fullname, incount = scs.incount, inprice = scs.inprice, minsaleprice = scs.minsaleprice, willprice = scs.willprice, instockdate = scs.instockdate, hasoutstock = scs.hasoutstock, systock = scs.incount - scs.hasoutstock };

            this.dataGridView1.DataSource = scss;
        }

        private void qTextBoxClothing_Click(object sender, EventArgs e)
        {
            //Common.SelectClothingForm form = new KMERP.Retalier.UI.Common.SelectClothingForm();

            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    this.filterClothing = form.SelectClothing;
            //}

            //this.qTextBoxClothing.Text = this.filterClothing.fullname;
        }

        private void qTextBoxClothing_DoubleClick(object sender, EventArgs e)
        {
            Common.SelectClothingForm form = new KMERP.Retalier.UI.Common.SelectClothingForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.filterClothing = form.SelectClothing;
            }

            this.qTextBoxClothing.Text = this.filterClothing.fullname;
        }

        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qButtonSerach_Click(object sender, EventArgs e)
        {
            if (this.filterClothing == null)
                return;

            stocks selectStock = (stocks)this.qComboBoxStock.SelectedItem;

            var scss = from scs in context.clothinginstocks
                       join sc in context.ptypes on scs.pid equals sc.id
                       where scs.sid == selectStock.id && scs.incount - scs.hasoutstock > 0 && scs.pid == this.filterClothing.id
                       select new { pcode = sc.usercode, pfullname = sc.fullname, sfullname = selectStock.fullname, incount = scs.incount, inprice = scs.inprice, minsaleprice = scs.minsaleprice, willprice = scs.willprice, instockdate = scs.instockdate, hasoutstock = scs.hasoutstock, systock = scs.incount - scs.hasoutstock };

            this.dataGridView1.DataSource = scss;
        }

    }
}
