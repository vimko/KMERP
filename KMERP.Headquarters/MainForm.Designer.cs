namespace KMERP.Headquarters
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.qRibbonCaption1 = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            this.qRibbon1 = new Qios.DevSuite.Components.Ribbon.QRibbon();
            this.qRibbonPageAdminUser = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
            this.qRibbonPanel1 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonPanelAdminOperator = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonItemAdminOperator = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qRibbonPageAdminBuyer = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
            this.qRibbonPanelBuyerBaseInfo = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonItemAddBuyerBaseInfo = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qRibbonSeparator1 = new Qios.DevSuite.Components.Ribbon.QRibbonSeparator();
            this.qRibbonItemBuyerBaseinofList = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qRibbonPageAdminProduct = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
            this.qRibbonPanelAdminProductBaseinfo = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonItemAddProductBaseInfo = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qRibbonSeparator2 = new Qios.DevSuite.Components.Ribbon.QRibbonSeparator();
            this.qRibbonItemProductBaseInfoList = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qRibbonPageAdminStock = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
            this.qRibbonPaneAdminStock = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonItemAdminStock = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qTabControlMainTab = new Qios.DevSuite.Components.QTabControl();
            this.qTabPageIndexPage = new Qios.DevSuite.Components.QTabPage();
            this.qRibbonPanelPInStock = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonItemPInStock = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qRibbonPageSale = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
            this.qRibbonPanel2 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonItemBatSale = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qRibbonPanelSaleReport = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonItemBatSaleReport = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbon1)).BeginInit();
            this.qRibbon1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageAdminUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageAdminBuyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageAdminProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageAdminStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qTabControlMainTab)).BeginInit();
            this.qTabControlMainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageSale)).BeginInit();
            this.SuspendLayout();
            // 
            // qRibbonCaption1
            // 
            this.qRibbonCaption1.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption1.Name = "qRibbonCaption1";
            this.qRibbonCaption1.Size = new System.Drawing.Size(680, 28);
            this.qRibbonCaption1.TabIndex = 1;
            this.qRibbonCaption1.Text = "柯毛服装连锁管理系统-总部版";
            // 
            // qRibbon1
            // 
            this.qRibbon1.ActiveTabPage = this.qRibbonPageAdminBuyer;
            this.qRibbon1.Controls.Add(this.qRibbonPageAdminUser);
            this.qRibbon1.Controls.Add(this.qRibbonPageAdminBuyer);
            this.qRibbon1.Controls.Add(this.qRibbonPageAdminProduct);
            this.qRibbon1.Controls.Add(this.qRibbonPageAdminStock);
            this.qRibbon1.Controls.Add(this.qRibbonPageSale);
            this.qRibbon1.Cursor = System.Windows.Forms.Cursors.Default;
            this.qRibbon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.qRibbon1.Location = new System.Drawing.Point(0, 28);
            this.qRibbon1.Name = "qRibbon1";
            this.qRibbon1.PersistGuid = new System.Guid("03da8e47-f58d-42b2-8ca6-25b82c4253f2");
            this.qRibbon1.Size = new System.Drawing.Size(680, 149);
            this.qRibbon1.TabIndex = 2;
            this.qRibbon1.Text = "Ribbon";
            // 
            // qRibbonPageAdminUser
            // 
            this.qRibbonPageAdminUser.ButtonOrder = 4;
            this.qRibbonPageAdminUser.Items.Add(this.qRibbonPanel1);
            this.qRibbonPageAdminUser.Items.Add(this.qRibbonPanelAdminOperator);
            this.qRibbonPageAdminUser.Location = new System.Drawing.Point(2, 29);
            this.qRibbonPageAdminUser.Name = "qRibbonPageAdminUser";
            this.qRibbonPageAdminUser.PersistGuid = new System.Guid("1bf86119-a1d9-4b77-a223-73fd8e0dd267");
            this.qRibbonPageAdminUser.Size = new System.Drawing.Size(674, 116);
            this.qRibbonPageAdminUser.Text = "系统管理";
            // 
            // qRibbonPanel1
            // 
            this.qRibbonPanel1.Title = "数据库设置管理";
            // 
            // qRibbonPanelAdminOperator
            // 
            this.qRibbonPanelAdminOperator.Items.Add(this.qRibbonItemAdminOperator);
            this.qRibbonPanelAdminOperator.Title = "操作员管理";
            // 
            // qRibbonItemAdminOperator
            // 
            this.qRibbonItemAdminOperator.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemAdminOperator.Configuration.IconConfiguration.ContentAlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered;
            this.qRibbonItemAdminOperator.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(48, 48);
            this.qRibbonItemAdminOperator.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemAdminOperator.Icon")));
            this.qRibbonItemAdminOperator.Title = "操作员管理";
            this.qRibbonItemAdminOperator.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemAdminOperator_ItemActivated);
            // 
            // qRibbonPageAdminBuyer
            // 
            this.qRibbonPageAdminBuyer.ButtonOrder = 0;
            this.qRibbonPageAdminBuyer.Items.Add(this.qRibbonPanelBuyerBaseInfo);
            this.qRibbonPageAdminBuyer.Location = new System.Drawing.Point(2, 29);
            this.qRibbonPageAdminBuyer.Name = "qRibbonPageAdminBuyer";
            this.qRibbonPageAdminBuyer.PersistGuid = new System.Guid("bcde4bed-e1b3-42d6-ab1d-fdd9c2405e96");
            this.qRibbonPageAdminBuyer.Size = new System.Drawing.Size(674, 116);
            this.qRibbonPageAdminBuyer.Text = "客户管理";
            // 
            // qRibbonPanelBuyerBaseInfo
            // 
            this.qRibbonPanelBuyerBaseInfo.Items.Add(this.qRibbonItemAddBuyerBaseInfo);
            this.qRibbonPanelBuyerBaseInfo.Items.Add(this.qRibbonSeparator1);
            this.qRibbonPanelBuyerBaseInfo.Items.Add(this.qRibbonItemBuyerBaseinofList);
            this.qRibbonPanelBuyerBaseInfo.Title = "客户基本信息";
            // 
            // qRibbonItemAddBuyerBaseInfo
            // 
            this.qRibbonItemAddBuyerBaseInfo.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemAddBuyerBaseInfo.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(48, 48);
            this.qRibbonItemAddBuyerBaseInfo.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemAddBuyerBaseInfo.Icon")));
            this.qRibbonItemAddBuyerBaseInfo.Title = "添加客户基本信息";
            this.qRibbonItemAddBuyerBaseInfo.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemAddBuyerBaseInfo_ItemActivated);
            // 
            // qRibbonItemBuyerBaseinofList
            // 
            this.qRibbonItemBuyerBaseinofList.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemBuyerBaseinofList.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(48, 48);
            this.qRibbonItemBuyerBaseinofList.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemBuyerBaseinofList.Icon")));
            this.qRibbonItemBuyerBaseinofList.Title = "客户基本信息列表";
            this.qRibbonItemBuyerBaseinofList.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemBuyerBaseinofList_ItemActivated);
            // 
            // qRibbonPageAdminProduct
            // 
            this.qRibbonPageAdminProduct.ButtonOrder = 1;
            this.qRibbonPageAdminProduct.Items.Add(this.qRibbonPanelAdminProductBaseinfo);
            this.qRibbonPageAdminProduct.Location = new System.Drawing.Point(2, 29);
            this.qRibbonPageAdminProduct.Name = "qRibbonPageAdminProduct";
            this.qRibbonPageAdminProduct.PersistGuid = new System.Guid("246fac61-6eeb-4a80-8d68-d65917b09361");
            this.qRibbonPageAdminProduct.Size = new System.Drawing.Size(674, 116);
            this.qRibbonPageAdminProduct.Text = "商品管理";
            // 
            // qRibbonPanelAdminProductBaseinfo
            // 
            this.qRibbonPanelAdminProductBaseinfo.Items.Add(this.qRibbonItemAddProductBaseInfo);
            this.qRibbonPanelAdminProductBaseinfo.Items.Add(this.qRibbonSeparator2);
            this.qRibbonPanelAdminProductBaseinfo.Items.Add(this.qRibbonItemProductBaseInfoList);
            this.qRibbonPanelAdminProductBaseinfo.Title = "商品基本信息管理";
            // 
            // qRibbonItemAddProductBaseInfo
            // 
            this.qRibbonItemAddProductBaseInfo.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemAddProductBaseInfo.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(48, 48);
            this.qRibbonItemAddProductBaseInfo.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemAddProductBaseInfo.Icon")));
            this.qRibbonItemAddProductBaseInfo.Title = "添加商品";
            this.qRibbonItemAddProductBaseInfo.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemAddProductBaseInfo_ItemActivated);
            // 
            // qRibbonItemProductBaseInfoList
            // 
            this.qRibbonItemProductBaseInfoList.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemProductBaseInfoList.Configuration.IconConfiguration.ContentAlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered;
            this.qRibbonItemProductBaseInfoList.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(48, 48);
            this.qRibbonItemProductBaseInfoList.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemProductBaseInfoList.Icon")));
            this.qRibbonItemProductBaseInfoList.Title = "商品基本信息列表";
            this.qRibbonItemProductBaseInfoList.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemProductBaseInfoList_ItemActivated);
            // 
            // qRibbonPageAdminStock
            // 
            this.qRibbonPageAdminStock.ButtonOrder = 3;
            this.qRibbonPageAdminStock.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonPageAdminStock.Icon")));
            this.qRibbonPageAdminStock.Items.Add(this.qRibbonPaneAdminStock);
            this.qRibbonPageAdminStock.Items.Add(this.qRibbonPanelPInStock);
            this.qRibbonPageAdminStock.Location = new System.Drawing.Point(2, 29);
            this.qRibbonPageAdminStock.Name = "qRibbonPageAdminStock";
            this.qRibbonPageAdminStock.PersistGuid = new System.Guid("27f5a812-0e14-423e-9dbb-22ca2ec5ecdb");
            this.qRibbonPageAdminStock.Size = new System.Drawing.Size(674, 116);
            this.qRibbonPageAdminStock.Text = "仓库管理";
            // 
            // qRibbonPaneAdminStock
            // 
            this.qRibbonPaneAdminStock.Items.Add(this.qRibbonItemAdminStock);
            this.qRibbonPaneAdminStock.Title = "仓库管理";
            // 
            // qRibbonItemAdminStock
            // 
            this.qRibbonItemAdminStock.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemAdminStock.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(48, 48);
            this.qRibbonItemAdminStock.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemAdminStock.Icon")));
            this.qRibbonItemAdminStock.Title = "仓库管理";
            this.qRibbonItemAdminStock.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemAdminStock_ItemActivated);
            // 
            // qTabControlMainTab
            // 
            this.qTabControlMainTab.ActiveTabPage = this.qTabPageIndexPage;
            this.qTabControlMainTab.Controls.Add(this.qTabPageIndexPage);
            this.qTabControlMainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qTabControlMainTab.Location = new System.Drawing.Point(0, 177);
            this.qTabControlMainTab.Name = "qTabControlMainTab";
            this.qTabControlMainTab.PersistGuid = new System.Guid("9f027777-f992-4804-8953-d691f95b3709");
            this.qTabControlMainTab.Size = new System.Drawing.Size(680, 351);
            this.qTabControlMainTab.TabIndex = 3;
            this.qTabControlMainTab.TabStripTopConfiguration.CloseButtonVisible = true;
            this.qTabControlMainTab.Text = "首页";
            this.qTabControlMainTab.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.qTabControlMainTab_ControlRemoved);
            // 
            // qTabPageIndexPage
            // 
            this.qTabPageIndexPage.ButtonOrder = 0;
            this.qTabPageIndexPage.Location = new System.Drawing.Point(0, 28);
            this.qTabPageIndexPage.Name = "qTabPageIndexPage";
            this.qTabPageIndexPage.PersistGuid = new System.Guid("02009c12-bde7-4098-a994-2265d277a5c5");
            this.qTabPageIndexPage.Size = new System.Drawing.Size(678, 321);
            this.qTabPageIndexPage.Text = "首页";
            // 
            // qRibbonPanelPInStock
            // 
            this.qRibbonPanelPInStock.Items.Add(this.qRibbonItemPInStock);
            this.qRibbonPanelPInStock.Title = "商品入库";
            // 
            // qRibbonItemPInStock
            // 
            this.qRibbonItemPInStock.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemPInStock.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(48, 48);
            this.qRibbonItemPInStock.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemPInStock.Icon")));
            this.qRibbonItemPInStock.Title = "商品入库";
            this.qRibbonItemPInStock.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemPInStock_ItemActivated);
            // 
            // qRibbonPageSale
            // 
            this.qRibbonPageSale.ButtonOrder = 2;
            this.qRibbonPageSale.Items.Add(this.qRibbonPanel2);
            this.qRibbonPageSale.Items.Add(this.qRibbonPanelSaleReport);
            this.qRibbonPageSale.Location = new System.Drawing.Point(2, 29);
            this.qRibbonPageSale.Name = "qRibbonPageSale";
            this.qRibbonPageSale.PersistGuid = new System.Guid("2b15bd4b-ef00-4817-adc9-87b9e98bd56d");
            this.qRibbonPageSale.Size = new System.Drawing.Size(674, 116);
            this.qRibbonPageSale.Text = "销售管理";
            // 
            // qRibbonPanel2
            // 
            this.qRibbonPanel2.Items.Add(this.qRibbonItemBatSale);
            this.qRibbonPanel2.Title = "服装批发";
            // 
            // qRibbonItemBatSale
            // 
            this.qRibbonItemBatSale.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemBatSale.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(48, 48);
            this.qRibbonItemBatSale.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemBatSale.Icon")));
            this.qRibbonItemBatSale.Title = "批发发货";
            this.qRibbonItemBatSale.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemBatSale_ItemActivated);
            // 
            // qRibbonPanelSaleReport
            // 
            this.qRibbonPanelSaleReport.Items.Add(this.qRibbonItemBatSaleReport);
            this.qRibbonPanelSaleReport.Title = "销售报表";
            // 
            // qRibbonItemBatSaleReport
            // 
            this.qRibbonItemBatSaleReport.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemBatSaleReport.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(48, 48);
            this.qRibbonItemBatSaleReport.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemBatSaleReport.Icon")));
            this.qRibbonItemBatSaleReport.Title = "销售报表";
            this.qRibbonItemBatSaleReport.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemBatSaleReport_ItemActivated);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 528);
            this.Controls.Add(this.qTabControlMainTab);
            this.Controls.Add(this.qRibbon1);
            this.Controls.Add(this.qRibbonCaption1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "柯毛服装连锁管理系统-总部版";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbon1)).EndInit();
            this.qRibbon1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageAdminUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageAdminBuyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageAdminProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageAdminStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qTabControlMainTab)).EndInit();
            this.qTabControlMainTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption1;
        private Qios.DevSuite.Components.Ribbon.QRibbon qRibbon1;
        private Qios.DevSuite.Components.Ribbon.QRibbonPage qRibbonPageAdminUser;
        private Qios.DevSuite.Components.QTabControl qTabControlMainTab;
        private Qios.DevSuite.Components.QTabPage qTabPageIndexPage;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel1;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanelAdminOperator;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemAdminOperator;
        private Qios.DevSuite.Components.Ribbon.QRibbonPage qRibbonPageAdminBuyer;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanelBuyerBaseInfo;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemAddBuyerBaseInfo;
        private Qios.DevSuite.Components.Ribbon.QRibbonSeparator qRibbonSeparator1;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemBuyerBaseinofList;
        private Qios.DevSuite.Components.Ribbon.QRibbonPage qRibbonPageAdminProduct;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanelAdminProductBaseinfo;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemAddProductBaseInfo;
        private Qios.DevSuite.Components.Ribbon.QRibbonSeparator qRibbonSeparator2;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemProductBaseInfoList;
        private Qios.DevSuite.Components.Ribbon.QRibbonPage qRibbonPageAdminStock;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPaneAdminStock;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemAdminStock;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanelPInStock;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemPInStock;
        private Qios.DevSuite.Components.Ribbon.QRibbonPage qRibbonPageSale;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel2;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemBatSale;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanelSaleReport;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemBatSaleReport;

    }
}

