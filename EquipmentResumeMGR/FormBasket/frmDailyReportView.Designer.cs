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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet1 = new EquipmentResumeMGR.DataDataSet();
            this.DailyReport_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dailyReport_CheckViewTableAdapter1 = new EquipmentResumeMGR.DataDataSetTableAdapters.DailyReport_CheckViewTableAdapter();
            this.dailyReport_detailsTableAdapter1 = new EquipmentResumeMGR.DataDataSetTableAdapters.DailyReport_detailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyReport_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDataSet1BindingSource
            // 
            this.dataDataSet1BindingSource.DataSource = this.dataDataSet1;
            this.dataDataSet1BindingSource.Position = 0;
            // 
            // dataDataSet1
            // 
            this.dataDataSet1.DataSetName = "DataDataSet";
            this.dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DailyReport_detailsBindingSource
            // 
            this.DailyReport_detailsBindingSource.DataMember = "DailyReport_details";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataDataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EquipmentResumeMGR.FormBasket.dailyReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(500, 449);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dailyReport_CheckViewTableAdapter1
            // 
            this.dailyReport_CheckViewTableAdapter1.ClearBeforeFill = true;
            // 
            // dailyReport_detailsTableAdapter1
            // 
            this.dailyReport_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // frmDailyReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 449);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmDailyReportView";
            this.Text = "frmReportView";
            this.Load += new System.EventHandler(this.frmReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyReport_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DailyReport_detailsBindingSource;
        private DataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource dataDataSetBindingSource;
        private System.Windows.Forms.BindingSource dataDataSet1BindingSource;
        private DataDataSet dataDataSet1;
        private DataDataSetTableAdapters.DailyReport_CheckViewTableAdapter dailyReport_CheckViewTableAdapter1;
        private DataDataSetTableAdapters.DailyReport_detailsTableAdapter dailyReport_detailsTableAdapter1;
    }
}