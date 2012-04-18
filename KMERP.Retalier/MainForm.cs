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

namespace KMERP.Retalier
{
    public partial class MainForm :  QRibbonForm
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
            UI.UserLoginForm form = new KMERP.Retalier.UI.UserLoginForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                //if(form.IsLoginSucess == false)
                   
            }


            InitializeComponent();
        }

        /// <summary>
        /// 添加操作员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemOperatorAdmin_ItemActivated(object sender, QCompositeEventArgs e)
        {
            UI.Admin.AdminOperatorForm form = new KMERP.Retalier.UI.Admin.AdminOperatorForm();

            form.ShowDialog();
        }

        /// <summary>
        /// 添加服装基本信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemAddClothing_ItemActivated(object sender, QCompositeEventArgs e)
        {
            UI.Stock.AddClothingInfoForm form = new KMERP.Retalier.UI.Stock.AddClothingInfoForm();

            form.ShowDialog();
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
        /// 服装基本信息列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemListClothing_ItemActivated(object sender, QCompositeEventArgs e)
        {
            string operationName = "CLOTHINGBASEINFOLIST";

            if (OperationTabPage(operationName))
                return;

            QTabPage tabPage = new UI.Stock.ClothingBaseInfoListPage();

            this.ShowPage(operationName, tabPage);
        }

        /// <summary>
        /// 仓库管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemAdminStock_ItemActivated(object sender, QCompositeEventArgs e)
        {
            UI.Stock.AdminStockForm form = new KMERP.Retalier.UI.Stock.AdminStockForm();

            form.ShowDialog();
        }

        /// <summary>
        /// 采购入库单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemBuyInStock_ItemActivated(object sender, QCompositeEventArgs e)
        {
            string operationName = "CLOTHINGINSTOCK";

            if (OperationTabPage(operationName))
                return;

            QTabPage tabPage = new UI.Stock.InStockForm();

            this.ShowPage(operationName, tabPage);
        }


        /// <summary>
        /// 库存查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemSerarchStock_ItemActivated(object sender, QCompositeEventArgs e)
        {
            string operationName = "FINDCOUTNCLOTHINGINSTOCK";

            if (OperationTabPage(operationName))
                return;

            QTabPage tabPage = new UI.Stock.StockListPage();

            this.ShowPage(operationName, tabPage);
        }

        /// <summary>
        /// 销售商品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemSale_ItemActivated(object sender, QCompositeEventArgs e)
        {
            string operationName = "SALECLOTHING";

            if (OperationTabPage(operationName))
                return;

            QTabPage tabPage = new UI.Sale.SalePage();

            this.ShowPage(operationName, tabPage);
        }

        /// <summary>
        /// 销售退货
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemBackSale_ItemActivated(object sender, QCompositeEventArgs e)
        {
            

            try
            {
                UI.Sale.BackSaleForm form = new KMERP.Retalier.UI.Sale.BackSaleForm();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("数据保存成功！");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }

        }

        /// <summary>
        /// 销售情况报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbonItemSaleReport_ItemActivated(object sender, QCompositeEventArgs e)
        {
            string operationName = "SALEDETAILINFOREPORT";

            if (OperationTabPage(operationName))
                return;

            QTabPage tabPage = new UI.Sale.SaleReportPage();

            this.ShowPage(operationName, tabPage);
        }


        /// <summary>
        /// 加载首页数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qTabPageIndexPage_Activated(object sender, EventArgs e)
        {
            try
            {
                using (StockDataClassesDataContext context = new StockDataClassesDataContext())
                {
                    var today = from asale in context.sales
                                where asale.saledate.Value.Day == DateTime.Now.Day
                                select asale;
                    if (today.Count() < 1)
                        return;

                    long? count = today.Sum(s => s.salecount);

                    decimal? totalMoney = today.Sum(s => s.totalmoney);

                    this.labelTodayMoney.Text = totalMoney.ToString();
                    this.labelTotalCount.Text = count.ToString();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qRibbon1_HelpButtonActivated(object sender, EventArgs e)
        {
            UI.Common.AboutBox box = new KMERP.Retalier.UI.Common.AboutBox();


            box.ShowDialog();
        }




    }
}
