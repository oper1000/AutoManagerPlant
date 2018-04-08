using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EquipmentResumeMGR.ClassBasket
{
    /*
    /// <summary>
    /// 用户
    /// </summary>
    public class Customer
    {
        
        public string strCustomerID;//用户ID
        private string strCompanyName;//用户姓名
        private string strContactName;
        private string strCountry;    //所在城市

        #region　封装字段
        public string CustomerID//封装用户ID
        {
            get
            {
                return strCustomerID;
            }
            set
            {
                strCustomerID = value;
            }
        }

        public string CompanyName//封装用户姓名
        {
            get { return strCompanyName; }
            set { strCompanyName = value; }
        }

        public string ContactName//
        {
            get { return strContactName; }
            set { strContactName = value; }
        }

        public string Country
        {
            get { return strCountry; }
            set { strCountry = value; }
        }
        #endregion

        /// <summary>
        /// 为报表赋值 
        /// </summary>
        /// <param name="country">某一个国家</param>
        /// <returns>某一个国家所有顾客信息</returns>
        public static List<Customer> GetCustomerForCountry(string country)
        {
            SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString);//链接语句 需要引用指定DLL

            SqlCommand cmd = new SqlCommand();             //
            cmd.Connection = con;
            cmd.CommandText = "select CustomerID,CompanyName,ContactName,Country from customers where country=@country";
            SqlParameter p = new SqlParameter("@country", country);//参数
            cmd.Parameters.Add(p);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Customer> list = new List<Customer>();
            while (reader.Read())
            {
                Customer c = new Customer();
                c.CustomerID = reader.GetString(0);
                c.CompanyName = reader.GetString(1);
                c.ContactName = reader.GetString(2);
                c.Country = reader.GetString(3);
                list.Add(c);
            }
            con.Close();//关闭数据库链接
            return list;
        }
        /// <summary>
        /// 获取所有顾客信息
        /// </summary>
        /// <returns>顾客信息</returns>
        public static List<Customer> GetAllCustomers()
        {
            SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select CustomerID,CompanyName,ContactName,Country from customers";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Customer> list = new List<Customer>();
            while (reader.Read())
            {
                Customer c = new Customer();
                c.CustomerID = reader.GetString(0);
                c.CompanyName = reader.GetString(1);
                c.ContactName = reader.GetString(2);
                c.Country = reader.GetString(3);
                list.Add(c);
            }
            con.Close();
            return list;
        }
    }
     */

    

    public class Dty_Daily_Report
    {
        private clsConnection clsconnection = new clsConnection();

        #region 日报基本信息表
        /// <summary>
        /// 构建日报表基本信息虚拟表
        /// </summary>
        public class BasicInfo
        {
            private DateTime m_ReportDate;    //日报日期
            private string m_ReportOnWorkPeople;  //当班人员
            private string m_ReportBanci;   //班次
            private string m_ReportBanzu;   //班别
            private string m_ReportOther;   //其他信息
            public BasicInfo(DateTime reportDate, 
                string reportOnWorkPeople, 
                string reportBanci, 
                string reportBanzu,
                string reportOther)
            {
                m_ReportDate = reportDate;
                m_ReportOnWorkPeople = reportOnWorkPeople;
                m_ReportBanci = reportBanci;
                m_ReportBanzu = reportBanzu;
                m_ReportOther = reportOther;
            }
            public DateTime  ReportDate
            {
                get { return m_ReportDate; }
            }
            public string ReportOnWorkPeople
            {
                get { return m_ReportOnWorkPeople; }
            }
            public string ReportBanCi
            {
                get { return m_ReportBanci; }
            }
            public string ReportBanzu
            {
                get { return m_ReportBanzu; }
            }
            public string ReportOther
            {
                get { return m_ReportOther; }
            }
        }
        #endregion

        #region 日报巡检信息
            /// <summary>
            /// 构建日报巡检信息虚拟表
            /// </summary>
        public class CheckViewInfo
        {
            private string m_checkviewid;      //序号
            private DateTime m_checkviewdate;  //巡检日期
            private string m_checkviewbanci;   //巡检班次
            private DateTime m_checkviewtime;  //巡检时间
            private string m_checkviewcontent; //巡检内容
            private string m_checkviewresult;  //巡检结果
            private string m_checkviewperson;  //巡检人

            public CheckViewInfo(string checkviewid,
                                 DateTime checkviewdate,
                                 string checkviewbanci,
                                 DateTime checkviewtime,
                                 string checkviewcontent,
                                 string checkviewresult,
                                 string checkviewperson)
            {
                m_checkviewid = checkviewid;
                m_checkviewdate = checkviewdate;
                m_checkviewbanci = checkviewbanci;
                m_checkviewtime = checkviewtime;
                m_checkviewcontent = checkviewcontent;
                m_checkviewresult = checkviewresult;
                m_checkviewperson = checkviewperson;
            }
            public string CheckViewID
            {
                get { return m_checkviewid; }
            }
            public DateTime  CheckViewDate
            {
                get { return m_checkviewdate; }
            }
            public string CheckViewBanCi
            {
                get { return m_checkviewbanci; }
            }
            public DateTime CheckViewTime
            {
                get { return m_checkviewtime; }
            }
            public string CheckViewContent
            {
                get { return m_checkviewcontent; }
            }
            public string CheckViewResult
            {
                get { return m_checkviewresult; }
            }
            public string CheckViewPerson
            {
                get { return m_checkviewperson; }
            }
        }
        #endregion

        #region 日报维修信息
        /// <summary>
        /// 构建日报维修信息虚拟表
        /// </summary>
        public class DailyReportDetails
        {
            private string m_fixid;        //序号
            private string m_fixbybanci;   //班次
            private string m_fixstartdate; //开始维修日期
            private string m_fixstarttime; //维修开始时间
            private string m_fixendtime;  //维修结束时间
            private string m_fixtimetotal; //维修总用时
            private string m_equipmentnumber; //设备编号
            private string m_equipmentname;   //设备名称
            private string m_bugappearance;    //故障现象
            private string m_maintenanceprocedure;  //维修过程及措施
            private string m_failurecause;   //故障原因分析
            private string m_fixresult;  //维修结果
            private string m_fixperson;  //维修人

            public DailyReportDetails(string fixid,
                string fixbybanci,
                string fixstartdate,
                string fixstarttime,
                string fixendtime,
                string fixtimetotal,
                string equipmentnumber,
                string equipmentname,
                string bugappearance,
                string maintenanceprocedure,
                string failurecause,
                string fixresult,
                string fixperson)
            {
                m_fixid = fixid;
                m_fixbybanci = fixbybanci;
                m_fixstartdate = fixstartdate;
                m_fixstarttime = fixstarttime;
                m_fixendtime = fixendtime;
                m_fixtimetotal = fixtimetotal;
                m_equipmentnumber = equipmentnumber;
                m_equipmentname = equipmentname;
                m_bugappearance = bugappearance;
                m_maintenanceprocedure = maintenanceprocedure;
                m_failurecause = failurecause;
                m_fixresult = fixresult;
                m_fixperson = fixperson;
            }
            public string FixID
            {
                get { return m_fixid; }
            }
            public string FixStartDate
            {
                get { return m_fixstartdate; }
            }
            public string FixByBanCi
            {
                get { return m_fixbybanci; }
            }
            public string FixStartTime
            {
                get { return m_fixstarttime; }
            }
            public string FixEndTime
            {
                get { return m_fixendtime; }
            }
            public string FixTimeTotal
            {
                get { return m_fixtimetotal; }
            }
            public string EquipmentNumber
            {
                get { return m_equipmentnumber; }
            }
            public string EquipmentName
            {
                get { return m_equipmentname; }
            }
            public string BugAppearance
            {
                get { return m_bugappearance; }
            }
            public string MaintenanceProcedure
            {
                get { return m_maintenanceprocedure; }
            }
            public string FailureCause
            {
                get { return m_failurecause; }
            }
            public string FixResult
            {
                get { return m_fixresult; }
            }
            public string FixPerson
            {
                get { return m_fixperson; }
            }
        }
        #endregion

        #region 设备履历信息
        /// <summary>
        /// 构建设备履历信息虚拟表
        /// </summary>
        public class EuipmentHistory
        {
            private string m_equipmentname;   //设备名称
            private DateTime m_hisstartdate;  //履历开始日期
            private DateTime m_hisstarttime;  //履历开始时间
            private DateTime m_hisendtime;    //履历结束时间
            private string m_histype;         //区分：维修或保养
            private string m_hiscontent;      //内容
            private string m_hisresult;       //结果


            public EuipmentHistory(string equipmentname,
                DateTime hisstartdate,
                DateTime hisstarttime,
                DateTime hisendtime,
                string histype,
                string hiscontent,
                string hisresult)
            {
                m_equipmentname = equipmentname;
                m_hisstartdate = hisstartdate;
                m_hisstarttime = hisstarttime;
                m_hisendtime = hisendtime;
                m_histype = histype;
                m_hiscontent = hiscontent;
                m_hisresult = hisresult;
            }
            public string EquipmentName
            {
                get { return m_equipmentname; }
            }
            public DateTime HisStartDate
            {
                get { return m_hisstartdate; }
            }
            public DateTime HisStartTime
            {
                get { return m_hisstarttime; }
            }
            public DateTime HisEndTime
            {
                get { return HisEndTime;}
            }
            public string HisType
            {
                get { return m_histype; }
            }
            public string HisContent
            {
                get { return m_hiscontent; }
            }
            public string HisResult
            {
                get { return m_hisresult; }
            }

        }
        #endregion

        #region 读取故障详情信息到报表DataSource
        // Define Business Object "Merchant" that provides a 
        // GetProducts method that returns a collection of 
        // Product objects. 
        
        public class Merchant_BugDetails
        {
            //private string m_fixbybanci;   //班次
            //private DateTime m_fixstartdate; //开始维修日期
            //private DateTime m_fixstarttime; //维修开始时间
            //private DateTime m_fixendtime;  //维修结束时间
            //private DateTime m_fixtimetotal; //维修总用时
            //private string m_equipmentnumber; //设备编号
            //private string m_bugappearance;    //故障现象
            //private string m_maintenanceprocedure;  //维修过程及措施
            //private string m_failurecause;   //故障原因分析
            //private string m_fixresult;  //维修结果
            //private string m_fixperson;  //维修人

            
            

            private List<DailyReportDetails> m_BugDetails;
            public Merchant_BugDetails()
            {
                DateTimeFormatInfo dtFormatTime = new DateTimeFormatInfo();
                DateTimeFormatInfo dtFormatDate = new DateTimeFormatInfo();

                DateTime dtFixStartDate, dtFixStartTime, dtFixEndTime, dtFixTimeTotal;

                //dtFormatTime.ShortTimePattern;
                m_BugDetails = new List<DailyReportDetails>();
                for (int i = 0; i < clsComm.dsDailyReport.Tables[0].Rows.Count; i++)
                {
                    dtFixStartDate=Convert.ToDateTime(clsComm.dsDailyReport.Tables[0].Rows[i]["FixStartDate"], dtFormatDate);
                    //dtFixStartTime=Convert.ToDateTime(clsComm.dsDailyReport.Tables[0].Rows[i]["FixStartTime"], dtFormatTime);
                    //dtFixEndTime=Convert.ToDateTime(clsComm.dsDailyReport.Tables[0].Rows[i]["FixEndTime"], dtFormatTime);
                    //dtFixTimeTotal=Convert.ToDateTime(clsComm.dsDailyReport.Tables[0].Rows[i]["FixTimeTotal"], dtFormatTime);
                    m_BugDetails.Add(new DailyReportDetails(
                        (i + 1).ToString(),
                         clsComm.dsDailyReport.Tables[0].Rows[i]["FixByBanCi"].ToString(),
                         dtFixStartDate.ToString("yyyy-MM-dd"),
                         clsComm.dsDailyReport.Tables[0].Rows[i]["FixStartTime"].ToString(),//dtFixStartTime.ToString("hh:mm:ss"),
                         clsComm.dsDailyReport.Tables[0].Rows[i]["FixEndTime"].ToString(),//dtFixEndTime.ToString("hh:mm:ss"),
                         clsComm.dsDailyReport.Tables[0].Rows[i]["FixTimeTotal"].ToString(),//dtFixTimeTotal.ToString("hh:mm:ss"),
                         clsComm.dsDailyReport.Tables[0].Rows[i]["EquipmentNumber"].ToString(),
                         clsComm.dsDailyReport.Tables[0].Rows[i]["EquipmentName"].ToString(),
                         clsComm.dsDailyReport.Tables[0].Rows[i]["BugAppearance"].ToString(),
                         clsComm.dsDailyReport.Tables[0].Rows[i]["MaintenanceProcedure"].ToString(),
                         clsComm.dsDailyReport.Tables[0].Rows[i]["FailureCause"].ToString(),
                         clsComm.dsDailyReport.Tables[0].Rows[i]["FixResult"].ToString(),
                         clsComm.dsDailyReport.Tables[0].Rows[i]["FixPerson"].ToString()
                    ));
                }
            }
            public List<DailyReportDetails> GetBugDetails() { return m_BugDetails; }
        }
        #endregion

        //#region 读取基本信息到报表DataSource
        //public class Merchant_BasicInfo
        //{
        //    //private DateTime m_ReportDate;    //日报日期
        //    //private string m_ReportOnWorkPeople;  //当班人员
        //    //private string m_ReportBanci;   //班次
        //    //private string m_ReportBanzu;   //班别
        //    //private string m_ReportOther;   //其他信息

        //    private List<BasicInfo> m_BasicInfo;
        //    public Merchant_BasicInfo()
        //    {
        //        DateTimeFormatInfo dtFormatTime = new DateTimeFormatInfo();
        //        DateTimeFormatInfo dtFormatDate = new DateTimeFormatInfo();
        //        dtFormatDate.ShortDatePattern = "yyyy-MM-DD";
        //        //dtFormatTime.ShortTimePattern;
        //        m_BasicInfo = new List<BasicInfo>();
        //        m_BasicInfo.Add(new BasicInfo(
        //            "1",
        //            "班次",
        //           Convert.ToDateTime(Convert.ToDateTime("2016-9-8").ToShortTimeString()),
        //            Convert.ToDateTime("9:08:00", dtFormatTime),
        //            Convert.ToDateTime("9:58:00", dtFormatTime),
        //            Convert.ToDateTime("00:50:00", dtFormatTime),
        //            "FB101",
        //            "裹膜机",
        //            "断膜频繁",
        //            "重新封膜",
        //            "膜质量差",
        //            "正常",
        //            "曲继辉"
        //        ));
        //    }
        //    public List<BasicInfo> GetBasicInfo() { return m_BasicInfo; }
            
        //}
        //#endregion

        //#region 读取巡检信息到报表DataSource
        //public class Merchant_CheckViewInfo
        //{
        //    //private string m_checkviewid;      //序号
        //    //private DateTime m_checkviewdate;  //巡检日期
        //    //private string m_checkviewbanci;   //巡检班次
        //    //private DateTime m_checkviewtime;  //巡检时间
        //    //private string m_checkviewcontent; //巡检内容
        //    //private string m_checkviewresult;  //巡检结果
        //    //private string m_checkviewperson;  //巡检人

        //    private List<CheckViewInfo> m_CheckViewInfo;
        //    public Merchant_CheckViewInfo()
        //    {
        //        DateTimeFormatInfo dtFormatTime = new DateTimeFormatInfo();
        //        DateTimeFormatInfo dtFormatDate = new DateTimeFormatInfo();
        //        dtFormatDate.ShortDatePattern = "yyyy-MM-DD";
        //        //dtFormatTime.ShortTimePattern;
        //        m_CheckViewInfo = new List<CheckViewInfo>();
        //        m_CheckViewInfo.Add(new CheckViewInfo(
        //            "1",
        //            "班次",
        //           Convert.ToDateTime(Convert.ToDateTime("2016-9-8").ToShortTimeString()),
        //            Convert.ToDateTime("9:08:00", dtFormatTime),
        //            Convert.ToDateTime("9:58:00", dtFormatTime),
        //            Convert.ToDateTime("00:50:00", dtFormatTime),
        //            "FB101",
        //            "裹膜机",
        //            "断膜频繁",
        //            "重新封膜",
        //            "膜质量差",
        //            "正常",
        //            "曲继辉"
        //        ));
        //    }
        //    public List<CheckViewInfo> GetCheckViewInfo() { return m_CheckViewInfo; }
           
        //}
        //#endregion


    }

}
