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

namespace KMERP.Headquarters.UI.Stock
{
    public partial class InStockForm : QTabPage
    {
        private HeadquartersDataClassesDataContext context = null;

        public InStockForm()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            context = new HeadquartersDataClassesDataContext();

            //仓库列表
            this.qComboBox1.DataSource = context.stocks;
            this.qComboBox1.DisplayMember = "fullname";
            this.qComboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 0)
            //{
            //    UI.Common.SelectClothingForm sForm = new KMERP.Retalier.UI.Common.SelectClothingForm();

            //    if (sForm.ShowDialog() == DialogResult.OK)
            //    {
            //        MessageBox.Show(sForm.SelectClothing.fullname);
            //    }
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 0)
            //{
            //    UI.Common.SelectClothingForm sForm = new KMERP.Retalier.UI.Common.SelectClothingForm();

            //    if (sForm.ShowDialog() == DialogResult.OK)
            //    {
            //        MessageBox.Show(sForm.SelectClothing.fullname);
            //    }
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                UI.Common.SelectClothingForm sForm = new KMERP.Headquarters.UI.Common.SelectClothingForm();

                if (sForm.ShowDialog() == DialogResult.OK)
                {
                    if (sForm.SelectClothing != null)
                    {
                        DataGridViewRow srow = this.dataGridView1.Rows[e.RowIndex];

                        srow.Cells[0].Value = sForm.SelectClothing.usercode;
                        srow.Cells[1].Value = sForm.SelectClothing.fullname;
                        srow.Cells[6].Value = sForm.SelectClothing.id;

                    }
                }
            }
        }

        private void qButtonSave_Click(object sender, EventArgs e)
        {
            object stockname = this.qComboBox1.SelectedItem;

            if (stockname == null)
            {
                MessageBox.Show("请选择仓库！");
                this.qComboBox1.Focus();
                return;
            }

            string stockCode = context.stocks.Where(s=>s.fullname == ((stocks)stockname).fullname).First().usercode;

            Guid stockId = context.stocks.Where(s => s.fullname == ((stocks)stockname).fullname).First().id;

            if (this.dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("请填写要入库数据！");
                return;
            }

            try
            {
                foreach (DataGridViewRow item in this.dataGridView1.Rows)
                {
                    if (item.Cells[0].Value == null || item.Cells[1].Value == null || item.Cells[2].Value == null || item.Cells[3].Value == null || item.Cells[4].Value == null || item.Cells[5].Value == null)
                        break;

                    clothinginstocks cin = new clothinginstocks();

                    cin.pid = new Guid(item.Cells[6].Value.ToString());
                    cin.sid = stockId;
                    cin.incount = Convert.ToInt32(item.Cells[2].Value);
                    cin.inprice = Convert.ToDecimal(item.Cells[3].Value);
                    cin.minsaleprice = Convert.ToDecimal(item.Cells[4].Value);
                    cin.willprice = Convert.ToDecimal(item.Cells[5].Value);

                    context.clothinginstocks.InsertOnSubmit(cin);
                }

                context.SubmitChanges();

                MessageBox.Show("保存成功！");
               
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                //throw;
            }

        }


    }
}