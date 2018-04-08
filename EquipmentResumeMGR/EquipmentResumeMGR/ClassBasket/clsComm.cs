using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using EquipmentResumeMGR.ClassBasket;
using EquipmentResumeMGR.FormBasket;
using EquipmentResumeMGR.Properties;

namespace EquipmentResumeMGR.ClassBasket
{
    class clsComm
    {
        public static string sUser;
        public static string sDatabaseType = "1";//数据库类型：SQL_SERVER 为 1，ACCESS 为 0



        public static DataSet dsDailyReport = new DataSet();
        public static DataSet dsViewInfo= new DataSet();
        public static DataSet dsBasicInfo= new DataSet();

    }

    class abcc
    {
 
    }
}
