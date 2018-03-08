using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportViewer
{
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

    public class DefineProduct
    {
        public class Product
        {
            private string m_name;
            private int m_price;
            public Product(string name, int price)
            {
                m_name = name;
                m_price = price;
            }
            public string Name
            {
                get { return m_name; }
            }
            public int Price
            {
                get { return m_price; }
            }
        }

        public class abccc
        {
            private string m_name1;
            private int m_price1;
            public abccc(string name1, int price1)
            {
                m_name1 = name1;
                m_price1 = price1;
            }
            public string Name1
            {
                get { return m_name1; }
            }
            public int Price1
            {
                get { return m_price1; }
            }
        }

        public class abccc111
        {
            private string m_name1111;
            private int m_price1111;
            public abccc111(string name1111, int price1111)
            {
                m_name1111 = name1111;
                m_price1111 = price1111;
            }
            public string Name1111
            {
                get { return m_name1111; }
            }
            public int Price1111
            {
                get { return m_price1111; }
            }
        }


        // Define Business Object "Merchant" that provides a 
        // GetProducts method that returns a collection of 
        // Product objects. 
        public class Merchant1111
        {
            private List<Product> m_products;
            public Merchant1111()
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
