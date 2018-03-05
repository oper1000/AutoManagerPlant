using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.Odbc;
using EquipmentResumeMGR.ClassBasket;
using EquipmentResumeMGR.FormBasket;
using EquipmentResumeMGR.Properties;

namespace EquipmentResumeMGR.FormBasket
{
    public partial class frmMDIMain : Form
    {
        private int childFormNumber = 0;
        clsConnection clsconnection = new clsConnection();

        public frmMDIMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void 价格查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frmmain = new frmMain();
            frmmain.MdiParent = this;
            frmmain.Show();
        }

        public string FindOperator(string sUserNumber)
        {
            string aa="";
            try
            {
                clsconnection.connERPSql.Open();
                string sql = string.Format("select UserName from STUsers where UserID ='{0}'", sUserNumber);
                SqlDataAdapter da = new SqlDataAdapter(sql, clsconnection.connERPSql); //创建适配对象
                DataTable dt = new DataTable(); //新建表对象
                da.Fill(dt); //用适配对象填充表对象
                aa = dt.Rows[0][0].ToString();
            }
            catch (SqlException ss)
            {
                MessageBox.Show(ss.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clsconnection.connERPSql.Close();
            }
            return aa;
        }

        private void frmMDIMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = FindOperator(clsComm.sUser);
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void tspDB_Value_Find_Click(object sender, EventArgs e)
        {
            frmMain frmmain = new frmMain();
            frmmain.MdiParent = this;
            frmmain.WindowState = FormWindowState.Maximized;
            frmmain.Show();
        }

        private void tspMuch_Search_Click(object sender, EventArgs e)
        {
            frmMain frmmain = new frmMain();
            frmmain.MdiParent = this;
            frmmain.WindowState = FormWindowState.Maximized;
            frmmain.Show();
            
        }

        private void tspMiniToNotify_Click(object sender, EventArgs e)
        {
            NotifyIcon notifyicon = new NotifyIcon();
            notifyicon.Visible = true;
            this.notifyIcon1.BalloonTipText = "已最小化到托盘！";
            this.notifyIcon1.ShowBalloonTip(1);

            this.Visible = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void frmMDIMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("确定要退出吗？", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmMDIMain_Resize(object sender, EventArgs e)
        {
            
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmEquipmentMGR frmequipmentmgr = new frmEquipmentMGR();
            frmequipmentmgr.MdiParent = this;
            frmequipmentmgr.WindowState = FormWindowState.Maximized;
            frmequipmentmgr.Show(); 
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 日报查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDailyReportView frmdailyreportview = new frmDailyReportView();
            frmdailyreportview.MdiParent = this;
            frmdailyreportview.WindowState = FormWindowState.Maximized;
            frmdailyreportview.Show();
        }

    }
}
