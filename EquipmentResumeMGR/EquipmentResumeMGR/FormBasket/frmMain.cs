using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using EquipmentResumeMGR.ClassBasket;
using EquipmentResumeMGR.FormBasket;
using EquipmentResumeMGR.Properties;

namespace EquipmentResumeMGR.FormBasket
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        clsConnection clsconnection = new clsConnection();

        //自定义菜单内容 ***************↓↓↓↓↓

        //const string NodeTree_LookAll = "查看所有物资";
        //const string NodeTree_LookDecUse = "查看已领用物资";
        //const string NodeTree_LookDecUnUse = "查看未领用物资";

        //自定义菜单内容 ***************↑↑↑↑↑

        int iNodeTreeDIY_Number = 0; //自定义菜单的数量(第一行留一个空行)


        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadTreeNodes();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = this.Height - 60;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            btnExit.Top = (splitContainer1.Panel2.Height - btnExit.Height) / 2;
            btnAdd.Top = (splitContainer1.Panel2.Height - btnExit.Height) / 2;
            btnDelete.Top = (splitContainer1.Panel2.Height - btnExit.Height) / 2;
            btnModify.Top = (splitContainer1.Panel2.Height - btnExit.Height) / 2;
            btnExit.Left = this.Width - btnExit.Width - 20;
            btnAdd.Left = this.Width - (btnExit.Width * 2) - 25;
            btnDelete.Left = this.Width - (btnExit.Width * 3) - 30;
            btnModify.Left = this.Width - (btnExit.Width * 4) - 35;
            
        }

        private void frmMain_ResizeEnd(object sender, EventArgs e)
        {
            
        }

        #region 加载左侧树目录
        public void LoadTreeNodes()
        {
            int i = 0, j = 0, k = 0;
            string sql1 = "SELECT distinct EquipmentPos FROM Equipment_INFO", sql2;
            try
            {
                OleDbDataAdapter daTree1 = new OleDbDataAdapter(sql1,clsconnection.connLocalAccess);
                DataSet dsTree1 = new DataSet();
                daTree1.Fill(dsTree1);
                DataTable table1 = dsTree1.Tables[0];
                TreeNode[] nodetree = new TreeNode[dsTree1.Tables[0].Rows.Count + iNodeTreeDIY_Number];

                //开始加载第一级树目录
                //生成自定义菜单
                //nodetree[0] = tvYearDate.Nodes.Add("数据筛选");
                //nodetree[0].Nodes.Add(NodeTree_LookAll);
                //nodetree[0].Nodes.Add(NodeTree_LookDecUse);
                //nodetree[0].Nodes.Add(NodeTree_LookDecUnUse);


                //自动生成菜单
                while (i < dsTree1.Tables[0].Rows.Count)
                {
                    nodetree[i + iNodeTreeDIY_Number] = tvEquipment.Nodes.Add(dsTree1.Tables[0].Rows[i][0].ToString());
                    sql2 = string.Format("SELECT EquipmentName,EquipmentID FROM Equipment_INFO where EquipmentPos='{0}'", dsTree1.Tables[0].Rows[i][0].ToString());
                    OleDbDataAdapter sAdapter2 = new OleDbDataAdapter(sql2, clsconnection.connLocalAccess);
                    DataSet dsTree2 = new DataSet();
                    sAdapter2.Fill(dsTree2);
                    DataTable table2 = dsTree2.Tables[0];
                    //开始加载第二级树目录
                    while (j < dsTree2.Tables[0].Rows.Count)
                    {
                        nodetree[i + iNodeTreeDIY_Number].Nodes.Add(dsTree2.Tables[0].Rows[j][0].ToString() + "(" + dsTree2.Tables[0].Rows[j][1].ToString()+")");
                        //Debug.Print(dsTree2.Tables[0].Rows[j][0].ToString());
                        j += 1;
                    }
                    i += 1;
                    j = 0;
                    dsTree2.Dispose();
                    //Debug.Print("================================");

                }
                dsTree1.Dispose();
            }
            catch (OleDbException ss)
            {
                MessageBox.Show("登录失败！请查看服务器是否打开！\n错误代码：" + ss.Message, "提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统出现故障，请联系管理员！\n" + ex.Message);
            }
            finally
            {

                //conn.Close();
            }
        }
        #endregion

        private void tvEquipment_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " Width:" + splitContainer2.SplitterDistance;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBugAdd frmbugadd = new frmBugAdd();
            frmbugadd.Show();
        }
    }
}
