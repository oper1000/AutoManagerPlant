using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
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

        public  string sDailyReportDate;  //日报筛选日期
        public  string sDailyReportBanci; //日报筛选班次

        private clsConnection clsconnection = new clsConnection();
        private clsComm clscomm = new clsComm();

        public DataSet dstest = new DataSet();

        public frmDailyReportView()
        {
            InitializeComponent();
        }

        private void frmReportView_Load(object sender, EventArgs e)
        {
            
        }

        private void 显示filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void checkViewInfoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dtpFiterDate.CustomFormat = "yyyy'-'MM'-'dd";
            sDailyReportDate = dtpFiterDate.Value.ToString("yyyy-MM-dd");
            sDailyReportBanci = cmbFiterBanci.Text;

            string sSelectSql = string.Format("select * from t_dailyreport_details where fixstartdate='{0}' and fixbybanci = '{1}'", sDailyReportDate, sDailyReportBanci);
            textBox1.Text = sSelectSql;
            SqlDataAdapter sdaconnGetBugDetails = new SqlDataAdapter(sSelectSql ,clsconnection.connERPSql);
            clsComm.dsDailyReport.Clear();
            sdaconnGetBugDetails.Fill(clsComm.dsDailyReport);

            Dty_Daily_Report.Merchant_BugDetails m_merchantBugDetails = new Dty_Daily_Report.Merchant_BugDetails();
            dailyReportDetailsBindingSource.DataSource = m_merchantBugDetails.GetBugDetails();
            this.reportViewer1.RefreshReport();

            
            
        }
    }
}
