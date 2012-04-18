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

namespace KMERP.Headquarters
{
    public partial class MainForm : QRibbonForm
    {
        /// <summary>
        /// 保存所有 tabPage 列表
        /// </summary>
        private Dictionary<string, QTabPage> tabPages = new Dictionary<string, QTabPage>();

        /// <summary>
        /// 保存 操作页面 key 与 页面的 name 匹配
        /// </summary>
        private Dictionary<string, string> tabPagesNameDic = new Dictionary<string, string>();

        public MainForm()
        {

            UI.UserLoginForm loginForm = new KMERP.Headquarters.UI.UserLoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
            }

            InitializeComponent();
        }

        #region 显示页面

        /// <summary>
        /// 检查当前页面是否保存了需要操作的页面
        /// 如果已经存在，则激活此页面，并返回 true
        /// 如果不存在，则返回 false
        /// </summary>
        /// <param name="operationkey"></param>
        /// <returns></returns>
        private bool OperationTabPage(string operationkey)
        {
            if (tabPages.ContainsKey(operationkey))
            {
                QTabPage page = tabPages[operationkey];

                if (page != null)
                {
                    this.qTabControlMainTab.ActivateTabPage(page);
                    return true;
                }
            }

            return false;
        }

        private void ShowPage(string pageflage, QTabPage tabPage)
        {
            this.tabPages.Add(pageflage, tabPage);
            this.tabPagesNameDic.Add(tabPage.Name, pageflage);

            this.qTabControlMainTab.Controls.Add(tabPage);
            this.qTabControlMainTab.ActivateTabPage(tabPage);
        }

        /// <summary>
        /// 在关闭操作页面时的处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qTabControlMainTab_ControlRemoved(object sender, ControlEventArgs e)
        {
            QTabPage page = e.Control as QTabPage;

            if (page == null)
                return;

            string tabname = page.Name;

            if (this.tabPagesNameDic.ContainsKey(tabname))
            {
                string operationkey = this.tabPagesNameDic[tabname];

                if (tabPages.ContainsKey(operationkey))
                    this.tabPages.Remove(operationkey);

                this.tabPagesNameDic.Remove(tabname);
            }
        }

        #endregion


        /// <summary>
        /// 操作员管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemAdminOperator_ItemActivated(object sender, QCompositeEventArgs e)
        {
            UI.Admin.AdminOperatorForm form = new KMERP.Headquarters.UI.Admin.AdminOperatorForm();

            form.ShowDialog();
        }

        /// <summary>
        /// 添加客户基本信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemAddBuyerBaseInfo_ItemActivated(object sender, QCompositeEventArgs e)
        {
            UI.Buyer.AddBuyerForm form = new KMERP.Headquarters.UI.Buyer.AddBuyerForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("操作成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 客户基本信息列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemBuyerBaseinofList_ItemActivated(object sender, QCompositeEventArgs e)
        {
            string operationName = "BUYERBASEINFOLIST";

            if (OperationTabPage(operationName))
                return;

            QTabPage tabPage = new UI.Buyer.BuyerinfoListPage();

            this.ShowPage(operationName, tabPage);
        }

        /// <summary>
        /// 添加商品基本信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemAddProductBaseInfo_ItemActivated(object sender, QCompositeEventArgs e)
        {
            UI.Product.AddClothingInfoForm form = new KMERP.Headquarters.UI.Product.AddClothingInfoForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("操作成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 商品基本信息列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemProductBaseInfoList_ItemActivated(object sender, QCompositeEventArgs e)
        {
            string operationName = "PRODUCTBASEINFOLIST";

            if (OperationTabPage(operationName))
                return;

            QTabPage tabPage = new UI.Product.ClothingBaseInfoListPage();

            this.ShowPage(operationName, tabPage);
        }

        /// <summary>
        /// 仓库管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemAdminStock_ItemActivated(object sender, QCompositeEventArgs e)
        {
            UI.Stock.AdminStockForm form = new KMERP.Headquarters.UI.Stock.AdminStockForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("操作成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 商品入库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemPInStock_ItemActivated(object sender, QCompositeEventArgs e)
        {
            string operationName = "PRODUCTINSTOCK";

            if (OperationTabPage(operationName))
                return;

            QTabPage tabPage = new UI.Stock.InStockForm();

            this.ShowPage(operationName, tabPage);
        }

        /// <summary>
        /// 服装批发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemBatSale_ItemActivated(object sender, QCompositeEventArgs e)
        {
            string operationName = "PRODUCTBATSALE";

            if (OperationTabPage(operationName))
                return;

            QTabPage tabPage = new UI.Sale.BatSaleForm();

            this.ShowPage(operationName, tabPage);
        }

        /// <summary>
        /// 销售情况查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemBatSaleReport_ItemActivated(object sender, QCompositeEventArgs e)
        {
            string operationName = "PRODUCTBATSALEREPORT";

            if (OperationTabPage(operationName))
                return;

            QTabPage tabPage = new UI.Sale.BatSaleReportPage();

            this.ShowPage(operationName, tabPage);
        }
    }
}
