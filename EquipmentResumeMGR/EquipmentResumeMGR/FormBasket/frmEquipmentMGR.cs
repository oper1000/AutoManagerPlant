using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EquipmentResumeMGR.FormBasket
{
    public partial class frmEquipmentMGR : Form
    {
        public frmEquipmentMGR()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            this.Text = "ThisHeght:" + this.Height.ToString() + 
                        " || ThisWidth:" + this.Width.ToString() +
                        " || Split.2 Height:" + splitContainer1.Panel2.Height + 
                        " || SplitDistance:" + splitContainer1.SplitterDistance +
                        " || BtnCloseTop:" + btnClose.Top + 
                        " || BtnCloseLeft:" + btnClose.Left;
            splitContainer1.SplitterDistance = this.Height - 100;

            //frmEquipmentMGR_Resize(sender, e);
        }

        private void frmEquipmentMGR_Resize(object sender, EventArgs e)
        {
            this.Text = "1:ThisHeght:" + this.Height.ToString() +
                        " || ThisWidth:" + this.Width.ToString() +
                        " || Split.2 Height:" + splitContainer1.Panel2.Height +
                        " || SplitDistance:" + splitContainer1.SplitterDistance +
                        " || BtnCloseTop:" + btnClose.Top +
                        " || BtnCloseLeft:" + btnClose.Left;
            btnClose.Top = (splitContainer1.Panel2.Height - btnClose.Height) / 2;
            btnSave.Top = (splitContainer1.Panel2.Height - btnClose.Height) / 2;
            btnClose.Left = this.Width - btnClose.Width - 20;
            btnSave.Left = this.Width - (btnSave.Width * 2) - 25;
        }

    }
}
