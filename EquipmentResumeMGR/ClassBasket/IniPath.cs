using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using EquipmentResumeMGR.ClassBasket;
using EquipmentResumeMGR.FormBasket;
using EquipmentResumeMGR.Properties;

namespace EquipmentResumeMGR.ClassBasket
{
    class IniPath
    {

        private string m_iniPath;
        public string sIniPath = Application.StartupPath + "\\setup.ini";



        //申明读写INI文件的API函数
        [DllImport("Kernel32")]
        private static extern long
        WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int
        GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);


        //public void clsini(string iniPath)
        //{
        //    m_iniPath = iniPath;
        //}

        //写INI文件
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, sIniPath);
        }

        //读取INI文件指定
        public string IniReadValue(string Section, string Key, string Default)
        {
            StringBuilder temp = new
            StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, Default, temp, 255, sIniPath);
            return temp.ToString();
        }


    }
}
