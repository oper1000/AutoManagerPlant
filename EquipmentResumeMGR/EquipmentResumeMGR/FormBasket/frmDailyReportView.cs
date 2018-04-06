using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EquipmentResumeMGR.ClassBasket;
using EquipmentResumeMGR.FormBasket;
using EquipmentResumeMGR.Properties;

namespace EquipmentResumeMGR.FormBasket
{
    public partial class frmDailyReportView : Form
    {

        //private DefineProduct.Merchant m_merchant = new DefineProduct.Merchant();
        //将故障详情表的数据传给报表读取器。
        private Dty_Daily_Report.Merchant_BugDetails m_merchant = new Dty_Daily_Report.Merchant_BugDetails();

        public frmDailyReportView()
        {
            InitializeComponent();
        }

        private void frmReportView_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            dailyReportDetailsBindingSource.DataSource = m_merchant.GetProducts();
        }

        private void 显示filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void checkViewInfoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
