namespace KMERP.Retalier
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
            this.qRibbonPageAdmin = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
            this.qRibbonPanel1 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonPanel2 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonItemOperatorAdmin = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qRibbonPageSale = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
            this.qRibbonPanelSale = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonItemSale = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qRibbonPanelBack = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonPanelSaleReport = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonPageStock = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
            this.qRibbonPanelProtuctInfo = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonItemAddClothing = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qRibbonSeparator1 = new Qios.DevSuite.Components.Ribbon.QRibbonSeparator();
            this.qRibbonItemListClothing = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qRibbonPanelStockAdmin = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonItemAdminStock = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qRibbonPanel3 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.qRibbonItemBuyInStock = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qRibbonSeparator2 = new Qios.DevSuite.Components.Ribbon.QRibbonSeparator();
            this.qRibbonItemSerarchStock = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qTabControlMainTab = new Qios.DevSuite.Components.QTabControl();
            this.qTabPageIndexPage = new Qios.DevSuite.Components.QTabPage();
            this.qRibbonItemBackSale = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qRibbonItemSaleReport = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalCount = new System.Windows.Forms.Label();
            this.labelTodayMoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbon1)).BeginInit();
            this.qRibbon1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qTabControlMainTab)).BeginInit();
            this.qTabControlMainTab.SuspendLayout();
            this.qTabPageIndexPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // qRibbonCaption1
            // 
            this.qRibbonCaption1.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption1.Name = "qRibbonCaption1";
            this.qRibbonCaption1.Size = new System.Drawing.Size(726, 28);
            this.qRibbonCaption1.TabIndex = 0;
            this.qRibbonCaption1.Text = "柯毛服装连锁管理系统——门店系统";
            // 
            // qRibbon1
            // 
            this.qRibbon1.ActiveTabPage = this.qRibbonPageSale;
            this.qRibbon1.Controls.Add(this.qRibbonPageAdmin);
            this.qRibbon1.Controls.Add(this.qRibbonPageSale);
            this.qRibbon1.Controls.Add(this.qRibbonPageStock);
            this.qRibbon1.Cursor = System.Windows.Forms.Cursors.Default;
            this.qRibbon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.qRibbon1.Location = new System.Drawing.Point(0, 28);
            this.qRibbon1.Name = "qRibbon1";
            this.qRibbon1.PersistGuid = new System.Guid("852ca3fd-8153-45fd-ac29-2ea7bd2d986a");
            this.qRibbon1.Size = new System.Drawing.Size(726, 152);
            this.qRibbon1.TabIndex = 1;
            this.qRibbon1.Text = "qRibbon1";
            this.qRibbon1.HelpButtonActivated += new System.EventHandler(this.qRibbon1_HelpButtonActivated);
            // 
            // qRibbonPageAdmin
            // 
            this.qRibbonPageAdmin.ButtonOrder = 2;
            this.qRibbonPageAdmin.Items.Add(this.qRibbonPanel1);
            this.qRibbonPageAdmin.Items.Add(this.qRibbonPanel2);
            this.qRibbonPageAdmin.Location = new System.Drawing.Point(2, 29);
            this.qRibbonPageAdmin.Name = "qRibbonPageAdmin";
            this.qRibbonPageAdmin.PersistGuid = new System.Guid("d5618a63-7e06-4ef0-9463-ede4695cf76e");
            this.qRibbonPageAdmin.Size = new System.Drawing.Size(720, 119);
            this.qRibbonPageAdmin.Text = "系统管理";
            // 
            // qRibbonPanel1
            // 
            this.qRibbonPanel1.Title = "数据库连接设置";
            // 
            // qRibbonPanel2
            // 
            this.qRibbonPanel2.Items.Add(this.qRibbonItemOperatorAdmin);
            this.qRibbonPanel2.Title = "操作员管理";
            // 
            // qRibbonItemOperatorAdmin
            // 
            this.qRibbonItemOperatorAdmin.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemOperatorAdmin.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(64, 64);
            this.qRibbonItemOperatorAdmin.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemOperatorAdmin.Icon")));
            this.qRibbonItemOperatorAdmin.Title = "操作员管理";
            this.qRibbonItemOperatorAdmin.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemOperatorAdmin_ItemActivated);
            // 
            // qRibbonPageSale
            // 
            this.qRibbonPageSale.ButtonOrder = 0;
            this.qRibbonPageSale.Items.Add(this.qRibbonPanelSale);
            this.qRibbonPageSale.Items.Add(this.qRibbonPanelBack);
            this.qRibbonPageSale.Items.Add(this.qRibbonPanelSaleReport);
            this.qRibbonPageSale.Location = new System.Drawing.Point(2, 29);
            this.qRibbonPageSale.Name = "qRibbonPageSale";
            this.qRibbonPageSale.PersistGuid = new System.Guid("8565e425-3fa5-41cf-a5cb-09cef78bdc5b");
            this.qRibbonPageSale.Size = new System.Drawing.Size(720, 119);
            this.qRibbonPageSale.Text = "销售管理";
            // 
            // qRibbonPanelSale
            // 
            this.qRibbonPanelSale.Items.Add(this.qRibbonItemSale);
            this.qRibbonPanelSale.Title = "销售收银";
            // 
            // qRibbonItemSale
            // 
            this.qRibbonItemSale.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemSale.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(64, 64);
            this.qRibbonItemSale.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemSale.Icon")));
            this.qRibbonItemSale.Title = "销售";
            this.qRibbonItemSale.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemSale_ItemActivated);
            // 
            // qRibbonPanelBack
            // 
            this.qRibbonPanelBack.Items.Add(this.qRibbonItemBackSale);
            this.qRibbonPanelBack.Title = "退换货";
            // 
            // qRibbonPanelSaleReport
            // 
            this.qRibbonPanelSaleReport.Items.Add(this.qRibbonItemSaleReport);
            this.qRibbonPanelSaleReport.Title = "销售情况报表";
            // 
            // qRibbonPageStock
            // 
            this.qRibbonPageStock.ButtonOrder = 1;
            this.qRibbonPageStock.Items.Add(this.qRibbonPanelProtuctInfo);
            this.qRibbonPageStock.Items.Add(this.qRibbonPanelStockAdmin);
            this.qRibbonPageStock.Items.Add(this.qRibbonPanel3);
            this.qRibbonPageStock.Location = new System.Drawing.Point(2, 29);
            this.qRibbonPageStock.Name = "qRibbonPageStock";
            this.qRibbonPageStock.PersistGuid = new System.Guid("d54698e7-3b6c-4353-b65c-6d56987c9a33");
            this.qRibbonPageStock.Size = new System.Drawing.Size(720, 119);
            this.qRibbonPageStock.Text = "库存管理";
            // 
            // qRibbonPanelProtuctInfo
            // 
            this.qRibbonPanelProtuctInfo.Items.Add(this.qRibbonItemAddClothing);
            this.qRibbonPanelProtuctInfo.Items.Add(this.qRibbonSeparator1);
            this.qRibbonPanelProtuctInfo.Items.Add(this.qRibbonItemListClothing);
            this.qRibbonPanelProtuctInfo.Title = "服装信息";
            // 
            // qRibbonItemAddClothing
            // 
            this.qRibbonItemAddClothing.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemAddClothing.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(64, 64);
            this.qRibbonItemAddClothing.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemAddClothing.Icon")));
            this.qRibbonItemAddClothing.Title = "添加服装基本信息";
            this.qRibbonItemAddClothing.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemAddClothing_ItemActivated);
            // 
            // qRibbonItemListClothing
            // 
            this.qRibbonItemListClothing.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemListClothing.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(64, 64);
            this.qRibbonItemListClothing.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemListClothing.Icon")));
            this.qRibbonItemListClothing.Title = "服装信息列表";
            this.qRibbonItemListClothing.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemListClothing_ItemActivated);
            // 
            // qRibbonPanelStockAdmin
            // 
            this.qRibbonPanelStockAdmin.Items.Add(this.qRibbonItemAdminStock);
            this.qRibbonPanelStockAdmin.Title = "仓库管理";
            // 
            // qRibbonItemAdminStock
            // 
            this.qRibbonItemAdminStock.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemAdminStock.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(64, 64);
            this.qRibbonItemAdminStock.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemAdminStock.Icon")));
            this.qRibbonItemAdminStock.Title = "仓库管理";
            this.qRibbonItemAdminStock.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemAdminStock_ItemActivated);
            // 
            // qRibbonPanel3
            // 
            this.qRibbonPanel3.Items.Add(this.qRibbonItemBuyInStock);
            this.qRibbonPanel3.Items.Add(this.qRibbonSeparator2);
            this.qRibbonPanel3.Items.Add(this.qRibbonItemSerarchStock);
            this.qRibbonPanel3.Title = "服装采购管理";
            // 
            // qRibbonItemBuyInStock
            // 
            this.qRibbonItemBuyInStock.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemBuyInStock.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(64, 64);
            this.qRibbonItemBuyInStock.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemBuyInStock.Icon")));
            this.qRibbonItemBuyInStock.Title = "采采购入库";
            this.qRibbonItemBuyInStock.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemBuyInStock_ItemActivated);
            // 
            // qRibbonItemSerarchStock
            // 
            this.qRibbonItemSerarchStock.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemSerarchStock.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(64, 64);
            this.qRibbonItemSerarchStock.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemSerarchStock.Icon")));
            this.qRibbonItemSerarchStock.Title = "库存查询";
            this.qRibbonItemSerarchStock.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemSerarchStock_ItemActivated);
            // 
            // qTabControlMainTab
            // 
            this.qTabControlMainTab.ActiveTabPage = this.qTabPageIndexPage;
            this.qTabControlMainTab.Controls.Add(this.qTabPageIndexPage);
            this.qTabControlMainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qTabControlMainTab.Location = new System.Drawing.Point(0, 180);
            this.qTabControlMainTab.Name = "qTabControlMainTab";
            this.qTabControlMainTab.PersistGuid = new System.Guid("a998a31c-eded-4842-81fe-753026477cce");
            this.qTabControlMainTab.Size = new System.Drawing.Size(726, 315);
            this.qTabControlMainTab.TabIndex = 2;
            this.qTabControlMainTab.TabStripTopConfiguration.CloseButtonVisible = true;
            this.qTabControlMainTab.Text = "首页";
            this.qTabControlMainTab.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.qTabControlMainTab_ControlRemoved);
            // 
            // qTabPageIndexPage
            // 
            this.qTabPageIndexPage.ButtonOrder = 0;
            this.qTabPageIndexPage.Controls.Add(this.label3);
            this.qTabPageIndexPage.Controls.Add(this.label2);
            this.qTabPageIndexPage.Controls.Add(this.labelTodayMoney);
            this.qTabPageIndexPage.Controls.Add(this.labelTotalCount);
            this.qTabPageIndexPage.Controls.Add(this.label1);
            this.qTabPageIndexPage.Location = new System.Drawing.Point(0, 28);
            this.qTabPageIndexPage.Name = "qTabPageIndexPage";
            this.qTabPageIndexPage.PersistGuid = new System.Guid("229f02a3-3ea9-4887-a58c-073261e6e9f9");
            this.qTabPageIndexPage.Size = new System.Drawing.Size(724, 285);
            this.qTabPageIndexPage.Text = "首页";
            this.qTabPageIndexPage.Activated += new System.EventHandler(this.qTabPageIndexPage_Activated);
            // 
            // qRibbonItemBackSale
            // 
            this.qRibbonItemBackSale.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemBackSale.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(64, 64);
            this.qRibbonItemBackSale.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemBackSale.Icon")));
            this.qRibbonItemBackSale.Title = "销售退货";
            this.qRibbonItemBackSale.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemBackSale_ItemActivated);
            // 
            // qRibbonItemSaleReport
            // 
            this.qRibbonItemSaleReport.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItemSaleReport.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(64, 64);
            this.qRibbonItemSaleReport.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemSaleReport.Icon")));
            this.qRibbonItemSaleReport.Title = "销售报表";
            this.qRibbonItemSaleReport.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemSaleReport_ItemActivated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(75, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "今日销售情况：";
            // 
            // labelTotalCount
            // 
            this.labelTotalCount.AutoSize = true;
            this.labelTotalCount.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalCount.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTotalCount.ForeColor = System.Drawing.Color.Red;
            this.labelTotalCount.Location = new System.Drawing.Point(438, 147);
            this.labelTotalCount.Name = "labelTotalCount";
            this.labelTotalCount.Size = new System.Drawing.Size(53, 56);
            this.labelTotalCount.TabIndex = 1;
            this.labelTotalCount.Text = "0";
            // 
            // labelTodayMoney
            // 
            this.labelTodayMoney.AutoSize = true;
            this.labelTodayMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelTodayMoney.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTodayMoney.ForeColor = System.Drawing.Color.Red;
            this.labelTodayMoney.Location = new System.Drawing.Point(438, 230);
            this.labelTodayMoney.Name = "labelTodayMoney";
            this.labelTodayMoney.Size = new System.Drawing.Size(53, 56);
            this.labelTodayMoney.TabIndex = 2;
            this.labelTodayMoney.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(108, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 56);
            this.label2.TabIndex = 3;
            this.label2.Text = "销售数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(165, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 56);
            this.label3.TabIndex = 4;
            this.label3.Text = "营业额：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 495);
            this.Controls.Add(this.qTabControlMainTab);
            this.Controls.Add(this.qRibbon1);
            this.Controls.Add(this.qRibbonCaption1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "柯毛服装连锁管理系统——门店系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbon1)).EndInit();
            this.qRibbon1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPageStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qTabControlMainTab)).EndInit();
            this.qTabControlMainTab.ResumeLayout(false);
            this.qTabPageIndexPage.ResumeLayout(false);
            this.qTabPageIndexPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption1;
        private Qios.DevSuite.Components.Ribbon.QRibbon qRibbon1;
        private Qios.DevSuite.Components.Ribbon.QRibbonPage qRibbonPageAdmin;
        private Qios.DevSuite.Components.QTabControl qTabControlMainTab;
        private Qios.DevSuite.Components.QTabPage qTabPageIndexPage;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel1;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel2;
        private Qios.DevSuite.Components.Ribbon.QRibbonPage qRibbonPageSale;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanelSale;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanelBack;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanelSaleReport;
        private Qios.DevSuite.Components.Ribbon.QRibbonPage qRibbonPageStock;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemOperatorAdmin;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanelProtuctInfo;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemAddClothing;
        private Qios.DevSuite.Components.Ribbon.QRibbonSeparator qRibbonSeparator1;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemListClothing;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanelStockAdmin;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemAdminStock;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel3;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemBuyInStock;
        private Qios.DevSuite.Components.Ribbon.QRibbonSeparator qRibbonSeparator2;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemSerarchStock;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemSale;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemBackSale;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemSaleReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalCount;
        private System.Windows.Forms.Label labelTodayMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}

