using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using EquipmentResumeMGR.ClassBasket;
using EquipmentResumeMGR.FormBasket;
using EquipmentResumeMGR.Properties;

namespace EquipmentResumeMGR.ClassBasket
{
    class clsConnection
    {
        public Boolean bIsSave=false ;
        IniPath inipath = new IniPath();
        public static string sConnectionInfo;
        public string sDataName, sDataAddress, sDataUser, sDataPwd;

        public OleDbConnection connLocalAccess = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Data.accdb;Persist Security Info=False;");
        public SqlConnection connERPSql = new SqlConnection(sConnectionInfo);

        //从数据库查询单个数据
        public string SingleDataSearch(string sKey, string sTable, string sCondition, string sSearchField)
        {
            //创建连接
            SqlConnection sConn = new SqlConnection(GetDataConnectingInfo());
            string sComm = string.Format("select {0} from {1} where {2} = '{3}'", sSearchField, sTable, sCondition, sKey);
            sConn.Open();
            DataSet myDataset = new DataSet();
            SqlDataAdapter sAdapter = new SqlDataAdapter();
            sAdapter.SelectCommand = new SqlCommand (sComm, sConn);
            sAdapter.Fill(myDataset, "abc");
            return myDataset.Tables[0].Rows[0][0].ToString();
        }

        public string GetDataConnectingInfo()
        {
            string sConnecting;
            sDataName = inipath.IniReadValue("ManagerSettings", "DataName", "");
            sDataAddress = inipath.IniReadValue("ManagerSettings", "DataAddress", "");
            sDataPwd = inipath.IniReadValue("ManagerSettings", "DataPwd", "");
            sDataUser = inipath.IniReadValue("ManagerSettings", "DataUser", "");
            sConnecting = "server=" + sDataAddress + ";Initial Catalog=" + sDataName + ";User ID=" + sDataUser + ";Password=" + sDataPwd;
            return sConnecting;
        }

    }
}
