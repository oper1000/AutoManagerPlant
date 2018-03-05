using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EquipmentResumeMGR.ClassBasket;
using EquipmentResumeMGR.FormBasket;
using EquipmentResumeMGR.Properties;

namespace EquipmentResumeMGR.FormBasket
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //获取ERP连接信息
            clsConnection clsconnection = new clsConnection();
            clsConnection.sConnectionInfo = clsconnection.GetDataConnectingInfo();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            (new frmDailyReportView()).ShowDialog(); ;
            //frmLogin frmlogin = new frmLogin();
            //frmlogin.ShowDialog();
            //if (frmlogin.DialogResult.Equals(DialogResult.OK))
            //{
            //    frmlogin.Close();
            //    Application.Run(new frmMDIMain());
            //}
            
        }
    }
}
