﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        #region 日报基本信息表
        /// <summary>
        /// 构建日报表基本信息虚拟表
        /// </summary>
        public class BasicInfo
        {
            private DateTime m_ReportDate;
            private string m_ReportOnWorkPeople;
            private string m_ReportBanci;
            private string m_ReportBanzu;
            public BasicInfo(DateTime reportDate, string reportOnWorkPeople, string reportBanci, string reportBanzu)
            {
                m_ReportDate = reportDate;
                m_ReportOnWorkPeople = reportOnWorkPeople;
                m_ReportBanci = reportBanci;
                m_ReportBanzu = reportBanzu;
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
            
        }
        #endregion

        #region 日报巡检信息
            /// <summary>
            /// 构建日报巡检信息虚拟表
            /// </summary>
        public class CheckViewInfo
        {
            private DateTime m_checkviewdate;
            private string m_checkviewbanci;
            private DateTime m_checkviewtime;
            private string m_checkviewcontent;
            private string m_checkviewresult;
            private string m_checkviewperson;

            public CheckViewInfo(DateTime checkviewdate,
                                 string checkviewbanci,
                                 DateTime checkviewtime,
                                 string checkviewcontent,
                                 string checkviewresult,
                                 string checkviewperson)
            {
                m_checkviewdate = checkviewdate;
                m_checkviewbanci = checkviewbanci;
                m_checkviewtime = checkviewtime;
                m_checkviewcontent = checkviewcontent;
                m_checkviewperson = checkviewperson;
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
            private string m_fixbybanci;   //班次
            private DateTime m_fixstartdate; //开始维修日期
            private DateTime m_fixstarttime; //维修开始时间
            private DateTime  m_fixendtime;  //维修结束时间
            private DateTime m_fixtimetotal; //维修总用时
            private string m_equipmentnumber; //设备编号
            private string m_bugappearance;    //故障现象
            private string m_maintenanceprocedure;  //维修过程及措施
            private string m_failurecause;   //故障原因分析
            private string m_fixresult;  //维修结果
            private string m_fixperson;  //维修人

            public DailyReportDetails(string fixbybanci,
                DateTime fixstartdate,
                DateTime fixstarttime,
                DateTime fixendtime,
                DateTime fixtimetotal,
                string equipmentnumber,
                string bugappearance,
                string maintenanceprocedure,
                string failurecause,
                string fixresult,
                string fixperson)
            {
                m_fixbybanci = fixbybanci;
                m_fixstartdate = fixstartdate;
                m_fixstarttime = fixstarttime;
                m_fixendtime = fixendtime;
                m_fixtimetotal = fixtimetotal;
                m_equipmentnumber = equipmentnumber;
                m_bugappearance = bugappearance;
                m_maintenanceprocedure = maintenanceprocedure;
                m_failurecause = failurecause;
                m_fixresult = fixresult;
                m_fixperson = fixperson;
            }
            public DateTime CheckViewDate
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
            public string CheckViewPerson
            {
                get { return m_checkviewperson; }
            }
        }
        #endregion


        // Define Business Object "Merchant" that provides a 
        // GetProducts method that returns a collection of 
        // Product objects. 
        public class Merchant
        {
            private List<Product> m_products;
            public Merchant()
            {
                m_products = new List<Product>();
                m_products.Add(new Product("Pen", 25));
                m_products.Add(new Product("Pencil", 30));
                m_products.Add(new Product("Notebook", 15));
            }
            public List<Product> GetProducts() { return m_products; }
        }

    }

}