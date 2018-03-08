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
    public partial class frmDailyReportView : Form
    {
        

        public frmDailyReportView()
        {
            InitializeComponent();
        }

        private void frmReportView_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void 显示filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
