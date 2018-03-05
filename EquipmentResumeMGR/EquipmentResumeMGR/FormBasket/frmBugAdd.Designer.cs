namespace EquipmentResumeMGR.FormBasket
{
    partial class frmBugAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtpFixStart = new System.Windows.Forms.DateTimePicker();
            this.dtpFixEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbEquipmentList = new System.Windows.Forms.ComboBox();
            this.txtBugAppearance = new System.Windows.Forms.TextBox();
            this.txtMaintenanceProcedure = new System.Windows.Forms.TextBox();
            this.txtFailureCause = new System.Windows.Forms.TextBox();
            this.cmbFixResult = new System.Windows.Forms.ComboBox();
            this.cmbFixPersion = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "维修开始：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "维修结束：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "设备名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "故障现象：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "维修过程及措施：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "结果：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "故障原因分析：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "维修人：";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(425, 218);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 37);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtpFixStart
            // 
            this.dtpFixStart.Location = new System.Drawing.Point(82, 16);
            this.dtpFixStart.Name = "dtpFixStart";
            this.dtpFixStart.Size = new System.Drawing.Size(131, 21);
            this.dtpFixStart.TabIndex = 10;
            // 
            // dtpFixEnd
            // 
            this.dtpFixEnd.Location = new System.Drawing.Point(280, 16);
            this.dtpFixEnd.Name = "dtpFixEnd";
            this.dtpFixEnd.Size = new System.Drawing.Size(137, 21);
            this.dtpFixEnd.TabIndex = 11;
            // 
            // cmbEquipmentList
            // 
            this.cmbEquipmentList.FormattingEnabled = true;
            this.cmbEquipmentList.Location = new System.Drawing.Point(483, 16);
            this.cmbEquipmentList.Name = "cmbEquipmentList";
            this.cmbEquipmentList.Size = new System.Drawing.Size(131, 20);
            this.cmbEquipmentList.TabIndex = 12;
            // 
            // txtBugAppearance
            // 
            this.txtBugAppearance.Location = new System.Drawing.Point(82, 55);
            this.txtBugAppearance.Name = "txtBugAppearance";
            this.txtBugAppearance.Size = new System.Drawing.Size(532, 21);
            this.txtBugAppearance.TabIndex = 13;
            // 
            // txtMaintenanceProcedure
            // 
            this.txtMaintenanceProcedure.Location = new System.Drawing.Point(129, 94);
            this.txtMaintenanceProcedure.Name = "txtMaintenanceProcedure";
            this.txtMaintenanceProcedure.Size = new System.Drawing.Size(485, 21);
            this.txtMaintenanceProcedure.TabIndex = 13;
            // 
            // txtFailureCause
            // 
            this.txtFailureCause.Location = new System.Drawing.Point(129, 133);
            this.txtFailureCause.Name = "txtFailureCause";
            this.txtFailureCause.Size = new System.Drawing.Size(485, 21);
            this.txtFailureCause.TabIndex = 13;
            // 
            // cmbFixResult
            // 
            this.cmbFixResult.FormattingEnabled = true;
            this.cmbFixResult.Location = new System.Drawing.Point(60, 172);
            this.cmbFixResult.Name = "cmbFixResult";
            this.cmbFixResult.Size = new System.Drawing.Size(140, 20);
            this.cmbFixResult.TabIndex = 14;
            this.cmbFixResult.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbFixPersion
            // 
            this.cmbFixPersion.FormattingEnabled = true;
            this.cmbFixPersion.Location = new System.Drawing.Point(280, 172);
            this.cmbFixPersion.Name = "cmbFixPersion";
            this.cmbFixPersion.Size = new System.Drawing.Size(121, 20);
            this.cmbFixPersion.TabIndex = 15;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(525, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 37);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(328, 218);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 37);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmBugAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 270);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbFixPersion);
            this.Controls.Add(this.cmbFixResult);
            this.Controls.Add(this.txtFailureCause);
            this.Controls.Add(this.txtMaintenanceProcedure);
            this.Controls.Add(this.txtBugAppearance);
            this.Controls.Add(this.cmbEquipmentList);
            this.Controls.Add(this.dtpFixEnd);
            this.Controls.Add(this.dtpFixStart);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBugAdd";
            this.Text = "故障添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dtpFixStart;
        private System.Windows.Forms.DateTimePicker dtpFixEnd;
        private System.Windows.Forms.ComboBox cmbEquipmentList;
        private System.Windows.Forms.TextBox txtBugAppearance;
        private System.Windows.Forms.TextBox txtMaintenanceProcedure;
        private System.Windows.Forms.TextBox txtFailureCause;
        private System.Windows.Forms.ComboBox cmbFixResult;
        private System.Windows.Forms.ComboBox cmbFixPersion;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
    }
}