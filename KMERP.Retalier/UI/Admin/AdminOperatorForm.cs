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

namespace KMERP.Retalier.UI.Admin
{
    public partial class AdminOperatorForm : QRibbonForm
    {
        DAL.UserDataClassesDataContext context = null;

        public AdminOperatorForm()
        {
            InitializeComponent();

            Init();
        }


        private void Init()
        {
            this.dataGridView1.AutoGenerateColumns = false;
        }

        private void AdminOperatorForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“kMERPRDataSet.operators”中。您可以根据需要移动或移除它。
            //this.operatorsTableAdapter.Fill(this.kMERPRDataSet.operators);

            context = new KMERP.Retalier.DAL.UserDataClassesDataContext();

            this.dataGridView1.DataSource = context.operators;

        }


        

        /// <summary>
        /// 删除操作员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qButtonDel_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectrow = this.dataGridView1.SelectedRows[0];

            if (selectrow == null)
            {
                MessageBox.Show("请选择要删除的行", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.dataGridView1.Rows.Remove(selectrow);

            try
            {
                //this.operatorsTableAdapter.Update(this.kMERPRDataSet.operators);
                context.SubmitChanges();
                MessageBox.Show("保存成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("保存失败", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            
        }

        private void qButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //this.operatorsTableAdapter.Update(this.kMERPRDataSet.operators);
                context.SubmitChanges();
                MessageBox.Show("保存成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("保存失败", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
