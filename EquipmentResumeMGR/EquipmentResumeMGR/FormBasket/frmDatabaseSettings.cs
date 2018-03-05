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
    public partial class frmDatabaseSettings : Form
    {
        
        IniPath inipath = new IniPath();
        clsConnection clsconnection = new clsConnection();
        
        public frmDatabaseSettings()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDatabaseSettings_Load(object sender, EventArgs e)
        {
            txtDataAddress.Text = inipath.IniReadValue("ManagerSettings", "DataAddress", "");
            txtDataName.Text = inipath.IniReadValue("ManagerSettings", "DataName", "");
            txtDataUser.Text = inipath.IniReadValue("ManagerSettings", "DataUser", "");
            txtDataPwd.Text = inipath.IniReadValue("ManagerSettings", "DataPwd", "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                inipath.IniWriteValue("ManagerSettings", "DataAddress", txtDataAddress.Text);
                inipath.IniWriteValue("ManagerSettings", "DataName", txtDataName.Text);
                inipath.IniWriteValue("ManagerSettings", "DataUser", txtDataUser.Text);
                inipath.IniWriteValue("ManagerSettings", "DataPwd", txtDataPwd.Text);
            }
            catch (Exception ss)
            {
                MessageBox.Show("发生故障！\n故障代码：" + ss.Message,Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            finally
            {
                MessageBox.Show("保存成功！\n点击确定后关闭本窗口！", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
}
