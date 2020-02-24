namespace PersonalManager
{
    partial class frmViewTimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTimes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTP = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblElaptime = new System.Windows.Forms.Label();
            this.lblElapTimeSec = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblTotalTH = new System.Windows.Forms.Label();
            this.lblTotTime = new System.Windows.Forms.Label();
            this.lblTimeSpent = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.dataGridLog = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMonthEffort = new System.Windows.Forms.Button();
            this.btnMonthSummary = new System.Windows.Forms.Button();
            this.btnDaySummary = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLog)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.dTP);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dTP
            // 
            resources.ApplyResources(this.dTP, "dTP");
            this.dTP.Name = "dTP";
            this.dTP.ValueChanged += new System.EventHandler(this.dTP_ValueChanged);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.lblRemarks);
            this.groupBox2.Controls.Add(this.lblElaptime);
            this.groupBox2.Controls.Add(this.lblElapTimeSec);
            this.groupBox2.Controls.Add(this.lblMonth);
            this.groupBox2.Controls.Add(this.lblDay);
            this.groupBox2.Controls.Add(this.lblTotalTH);
            this.groupBox2.Controls.Add(this.lblTotTime);
            this.groupBox2.Controls.Add(this.lblTimeSpent);
            this.groupBox2.Controls.Add(this.lblTask);
            this.groupBox2.Controls.Add(this.dataGridLog);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lblRemarks
            // 
            resources.ApplyResources(this.lblRemarks, "lblRemarks");
            this.lblRemarks.Name = "lblRemarks";
            // 
            // lblElaptime
            // 
            resources.ApplyResources(this.lblElaptime, "lblElaptime");
            this.lblElaptime.Name = "lblElaptime";
            // 
            // lblElapTimeSec
            // 
            resources.ApplyResources(this.lblElapTimeSec, "lblElapTimeSec");
            this.lblElapTimeSec.Name = "lblElapTimeSec";
            // 
            // lblMonth
            // 
            resources.ApplyResources(this.lblMonth, "lblMonth");
            this.lblMonth.Name = "lblMonth";
            // 
            // lblDay
            // 
            resources.ApplyResources(this.lblDay, "lblDay");
            this.lblDay.Name = "lblDay";
            // 
            // lblTotalTH
            // 
            resources.ApplyResources(this.lblTotalTH, "lblTotalTH");
            this.lblTotalTH.Name = "lblTotalTH";
            // 
            // lblTotTime
            // 
            resources.ApplyResources(this.lblTotTime, "lblTotTime");
            this.lblTotTime.Name = "lblTotTime";
            // 
            // lblTimeSpent
            // 
            resources.ApplyResources(this.lblTimeSpent, "lblTimeSpent");
            this.lblTimeSpent.Name = "lblTimeSpent";
            // 
            // lblTask
            // 
            resources.ApplyResources(this.lblTask, "lblTask");
            this.lblTask.Name = "lblTask";
            // 
            // dataGridLog
            // 
            resources.ApplyResources(this.dataGridLog, "dataGridLog");
            this.dataGridLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLog.Name = "dataGridLog";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.btnMonthEffort);
            this.groupBox3.Controls.Add(this.btnMonthSummary);
            this.groupBox3.Controls.Add(this.btnDaySummary);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btnMonthEffort
            // 
            resources.ApplyResources(this.btnMonthEffort, "btnMonthEffort");
            this.btnMonthEffort.Name = "btnMonthEffort";
            this.btnMonthEffort.UseVisualStyleBackColor = true;
            this.btnMonthEffort.Click += new System.EventHandler(this.btnMonthEffort_Click);
            // 
            // btnMonthSummary
            // 
            resources.ApplyResources(this.btnMonthSummary, "btnMonthSummary");
            this.btnMonthSummary.Name = "btnMonthSummary";
            this.btnMonthSummary.UseVisualStyleBackColor = true;
            this.btnMonthSummary.Click += new System.EventHandler(this.btnMonthSummary_Click);
            // 
            // btnDaySummary
            // 
            resources.ApplyResources(this.btnDaySummary, "btnDaySummary");
            this.btnDaySummary.Name = "btnDaySummary";
            this.btnDaySummary.UseVisualStyleBackColor = true;
            this.btnDaySummary.Click += new System.EventHandler(this.btnDaySummary_Click);
            // 
            // frmViewTimes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmViewTimes";
            this.Load += new System.EventHandler(this.frmViewTimes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLog)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridLog;
        private System.Windows.Forms.Label lblElapTimeSec;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblElaptime;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMonthSummary;
        private System.Windows.Forms.Button btnDaySummary;
        private System.Windows.Forms.Label lblTimeSpent;
        private System.Windows.Forms.Label lblTotTime;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.DateTimePicker dTP;
        private System.Windows.Forms.Button btnMonthEffort;
        private System.Windows.Forms.Label lblTotalTH;
    }
}