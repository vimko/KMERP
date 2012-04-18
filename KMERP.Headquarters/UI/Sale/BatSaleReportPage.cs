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
    public partial class BatSaleReportPage : QTabPage
    {
        public BatSaleReportPage()
        {
            InitializeComponent();

            Init();
        }

        public void Init()
        {
            this.dataGridView1.AutoGenerateColumns = false;

            using (HeadquartersDataClassesDataContext context = new HeadquartersDataClassesDataContext())
            {
                var data = from ab in context.batsales
                           join ap in context.ptypes on ab.pid equals ap.id
                           join ac in context.buyerinfos on ab.bid equals ac.id
                           join ast in context.stocks on ab.sid equals ast.id
                           select new { bfullname = ac.fullname, busercode = ac.usercode, pusercode = ap.usercode, pfullname = ap.fullname, count = ab.salecount, price = ab.saleprice, totalmoney = ab.totalmoney, sfullname = ast.fullname, batdate = ab.saledate };

                this.dataGridView1.DataSource = data;

            }
        }
    }
}
