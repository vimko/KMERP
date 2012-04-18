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

namespace KMERP.Retalier.UI.Sale
{
    public partial class SaleReportPage : QTabPage
    {
        public SaleReportPage()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {

            using (StockDataClassesDataContext context = new StockDataClassesDataContext())
            {
                var allSales = from aSale in context.sales
                               join aPtype in context.ptypes on aSale.cid equals aPtype.id
                               join aStock in context.stocks on aSale.sid equals aStock.id
                               join aSaler in context.salers on aSale.pid equals aSaler.id
                               select new { pusercode = aPtype.usercode,pcode=aPtype.pcode,pfullname=aPtype.fullname,sfullname = aStock.fullname,price = aSale.saleprice,count = aSale.salecount,totalprice = aSale.totalmoney,salerfullname = aSaler.fullname,saledate=aSale.saledate};

                this.dataGridView1.DataSource = allSales;
            }

        }
    }
}
