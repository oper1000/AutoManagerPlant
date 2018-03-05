using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using EquipmentResumeMGR.ClassBasket;
using EquipmentResumeMGR.FormBasket;
using EquipmentResumeMGR.Properties;

namespace EquipmentResumeMGR.FormBasket
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool IsCanLogin=false;
        clsComm clscomm = new clsComm();
        clsConnection clsconnection = new clsConnection();

        
         
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                clsconnection.connLocalAccess.Open();
                string sql = string.Format("select UserPWD from Login_UserInfo where UserID ='{0}'", txtUserID.Text);

                OleDbDataAdapter da = new OleDbDataAdapter(sql, clsconnection.connLocalAccess); //创建适配对象
                DataTable dt = new DataTable(); //新建表对象
                da.Fill(dt); //用适配对象填充表对象
                string aa = dt.Rows[0][0].ToString();
                

                if (txtPwd.Text == aa)
                {
                    clsComm.sUser = txtUserID.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！\n请重新检查后再次登陆！:)", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPwd.SelectAll();
                }
            }
            catch (SqlException ss)
            {
                MessageBox.Show(ss.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clsconnection.connERPSql.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //OleDbConnection conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source=" + Application.StartupPath + @"\DTY_Bobbin_info.mdb");
            //conn.Open();
            //string sql = "select Sys_User from Sys_Login";

            //OleDbDataAdapter da = new OleDbDataAdapter(sql, conn); //创建适配对象
            //DataTable dt = new DataTable(); //新建表对象
            //da.Fill(dt); //用适配对象填充表对象

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    cmbUser.Items.Add(dt.Rows[i][0].ToString());
            //}
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPwd.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
