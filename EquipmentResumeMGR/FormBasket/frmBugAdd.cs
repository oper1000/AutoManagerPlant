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
using System.Data.Odbc;
using EquipmentResumeMGR.ClassBasket;

namespace EquipmentResumeMGR.FormBasket
{
    public partial class frmBugAdd : Form
    {
        public frmBugAdd()
        {
            InitializeComponent();
        }

        clsConnection clsconnection = new clsConnection();
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpFixStart.Text = "";
            dtpFixEnd.Text = "";
            cmbEquipmentList.Text = "";
            txtBugAppearance.Text = "";
            txtFailureCause.Text = "";
            txtMaintenanceProcedure.Text = "";
            cmbFixPersion.Text = "";
            cmbFixResult.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            try
            {
                clsconnection.connLocalAccess.Open();
                string sql = string.Format("insert into dailyreport_basicinfo(DailyReportDate,DailyReportOnWorkPeople,DailyReportBanci,DailyReportBanzu) values('2019-1-1','1','1','1')");

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;
                cmd.Connection = clsconnection.connLocalAccess;
                cmd.ExecuteNonQuery();
                //OleDbDataAdapter da = new OleDbDataAdapter(sql, clsconnection.connLocalAccess); //创建适配对象
                //DataTable dt = new DataTable(); //新建表对象
                //da.Fill(dt); //用适配对象填充表对象
                //string aa = dt.Rows[0][0].ToString();


                //if (txtPwd.Text == aa)
                //{
                //    clsComm.sUser = txtUserID.Text;
                //    this.DialogResult = DialogResult.OK;
                //}
                //else
                //{
                //    MessageBox.Show("用户名或密码错误！\n请重新检查后再次登陆！:)", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtPwd.SelectAll();
                //}
            }
            catch (SqlException ss)
            {
                MessageBox.Show(ss.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clsconnection.connLocalAccess.Close();
            }
        }
    }
}
