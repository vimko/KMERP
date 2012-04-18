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

namespace KMERP.Headquarters.UI.Sale
{
    public partial class BatSaleForm : QTabPage
    {
        private HeadquartersDataClassesDataContext context = null;

        public BatSaleForm()
        {
            InitializeComponent();


            Init();
        }

        private void Init()
        {
            this.dataGridView1.AutoGenerateColumns = false;

            context = new HeadquartersDataClassesDataContext();

            this.qComboBoxSStock.DataSource = context.stocks;
            this.qComboBoxSStock.DisplayMember = "fullname";

            this.qComboBoxBCustomers.DataSource = context.buyerinfos;
            this.qComboBoxBCustomers.DisplayMember = "fullname";

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
                        srow.Cells[5].Value = sForm.SelectClothing.id;
                    }
                }
            }
        }

        private void qButtonSave_Click(object sender, EventArgs e)
        {
            object stockname = this.qComboBoxSStock.SelectedItem;
            object buyername = this.qComboBoxBCustomers.SelectedItem;

            if (stockname == null)
            {
                MessageBox.Show("请选择仓库！");
                this.qComboBoxSStock.Focus();
                return;
            }

            if (buyername == null)
            {
                MessageBox.Show("请选择客户！");
                this.qComboBoxBCustomers.Focus();
                return;
            }

            //string stockCode = context.stocks.Where(s => s.fullname == ((stocks)stockname).fullname).First().usercode;

            Guid stockId = ((stocks)stockname).id;
            Guid buyerId = ((buyerinfos)buyername).id;

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

                    batsales cin = new batsales();

                    cin.pid = new Guid(item.Cells[5].Value.ToString());
                    cin.sid = stockId;
                    cin.bid = buyerId;
                    cin.salecount = Convert.ToInt32(item.Cells[2].Value);
                    cin.saleprice = Convert.ToDecimal(item.Cells[3].Value);
                    cin.totalmoney = Convert.ToDecimal(item.Cells[4].Value);
                    cin.saledate = DateTime.Now;

                    context.batsales.InsertOnSubmit(cin);
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                try
                {
                    int count = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    double price = Convert.ToDouble(this.dataGridView1.Rows[e.RowIndex].Cells[3].Value);

                    double money = count * price;

                    this.dataGridView1.Rows[e.RowIndex].Cells[4].Value = money;
                }
                catch (Exception)
                {
                    
                    //throw;
                }
            }
        }
    }
}
