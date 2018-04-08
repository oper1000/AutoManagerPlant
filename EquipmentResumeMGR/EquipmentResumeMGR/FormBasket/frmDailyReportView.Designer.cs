namespace EquipmentResumeMGR.FormBasket
{
    partial class frmDailyReportView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.basicInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkViewInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dailyReportDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.euipmentHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFiterDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbFiterBanci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.c1XLBook1 = new C1.C1Excel.C1XLBook();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.basicInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkViewInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.euipmentHistoryBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // basicInfoBindingSource
            // 
            this.basicInfoBindingSource.DataSource = typeof(EquipmentResumeMGR.ClassBasket.Dty_Daily_Report.BasicInfo);
            // 
            // checkViewInfoBindingSource
            // 
            this.checkViewInfoBindingSource.DataSource = typeof(EquipmentResumeMGR.ClassBasket.Dty_Daily_Report.CheckViewInfo);
            // 
            // dailyReportDetailsBindingSource
            // 
            this.dailyReportDetailsBindingSource.DataSource = typeof(EquipmentResumeMGR.ClassBasket.Dty_Daily_Report.DailyReportDetails);
            // 
            // euipmentHistoryBindingSource
            // 
            this.euipmentHistoryBindingSource.DataSource = typeof(EquipmentResumeMGR.ClassBasket.Dty_Daily_Report.EuipmentHistory);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "dsBasicInfo";
            reportDataSource5.Value = this.basicInfoBindingSource;
            reportDataSource6.Name = "dsCheckInfo";
            reportDataSource6.Value = this.checkViewInfoBindingSource;
            reportDataSource7.Name = "dsDailyReportDetails";
            reportDataSource7.Value = this.dailyReportDetailsBindingSource;
            reportDataSource8.Name = "dsEquipmentHistory";
            reportDataSource8.Value = this.euipmentHistoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EquipmentResumeMGR.FormBasket.dailyReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(872, 458);
            this.reportViewer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(872, 64);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 458);
            this.panel1.TabIndex = 2;
            // 
            // dtpFiterDate
            // 
            this.dtpFiterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiterDate.Location = new System.Drawing.Point(51, 19);
            this.dtpFiterDate.Name = "dtpFiterDate";
            this.dtpFiterDate.Size = new System.Drawing.Size(125, 21);
            this.dtpFiterDate.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbFiterBanci);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFiterDate);
            this.groupBox1.Controls.Add(this.LblTime);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbFiterBanci
            // 
            this.cmbFiterBanci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiterBanci.FormattingEnabled = true;
            this.cmbFiterBanci.Items.AddRange(new object[] {
            "夜班",
            "早班",
            "中班"});
            this.cmbFiterBanci.Location = new System.Drawing.Point(230, 19);
            this.cmbFiterBanci.Name = "cmbFiterBanci";
            this.cmbFiterBanci.Size = new System.Drawing.Size(93, 20);
            this.cmbFiterBanci.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "班次：";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(13, 23);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(41, 12);
            this.LblTime.TabIndex = 0;
            this.LblTime.Text = "日期：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(472, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 52);
            this.textBox1.TabIndex = 4;
            // 
            // frmDailyReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 522);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDailyReportView";
            this.Text = "日报预览";
            this.Load += new System.EventHandler(this.frmReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basicInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkViewInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.euipmentHistoryBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFiterDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbFiterBanci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.BindingSource basicInfoBindingSource;
        private System.Windows.Forms.BindingSource checkViewInfoBindingSource;
        private System.Windows.Forms.BindingSource dailyReportDetailsBindingSource;
        private System.Windows.Forms.BindingSource euipmentHistoryBindingSource;
        private C1.C1Excel.C1XLBook c1XLBook1;
        private System.Windows.Forms.TextBox textBox1;
    }
}