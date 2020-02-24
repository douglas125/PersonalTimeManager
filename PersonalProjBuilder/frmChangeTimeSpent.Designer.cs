namespace PersonalManager
{
    partial class frmChangeTimeSpent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeTimeSpent));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTP = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTasks = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.newTimeSpent = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.curTimeSpent = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.groupBox1.Controls.Add(this.dTP);
            this.groupBox1.Font = null;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dTP
            // 
            this.dTP.AccessibleDescription = null;
            this.dTP.AccessibleName = null;
            resources.ApplyResources(this.dTP, "dTP");
            this.dTP.BackgroundImage = null;
            this.dTP.CalendarFont = null;
            this.dTP.CustomFormat = null;
            this.dTP.Font = null;
            this.dTP.Name = "dTP";
            this.dTP.ValueChanged += new System.EventHandler(this.dTP_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleDescription = null;
            this.groupBox2.AccessibleName = null;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackgroundImage = null;
            this.groupBox2.Controls.Add(this.cmbTasks);
            this.groupBox2.Font = null;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cmbTasks
            // 
            this.cmbTasks.AccessibleDescription = null;
            this.cmbTasks.AccessibleName = null;
            resources.ApplyResources(this.cmbTasks, "cmbTasks");
            this.cmbTasks.BackgroundImage = null;
            this.cmbTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTasks.Font = null;
            this.cmbTasks.FormattingEnabled = true;
            this.cmbTasks.Name = "cmbTasks";
            this.cmbTasks.SelectedIndexChanged += new System.EventHandler(this.cmbTasks_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleDescription = null;
            this.groupBox3.AccessibleName = null;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackgroundImage = null;
            this.groupBox3.Controls.Add(this.txtRemark);
            this.groupBox3.Controls.Add(this.btnChange);
            this.groupBox3.Controls.Add(this.newTimeSpent);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.curTimeSpent);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = null;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // txtRemark
            // 
            this.txtRemark.AccessibleDescription = null;
            this.txtRemark.AccessibleName = null;
            resources.ApplyResources(this.txtRemark, "txtRemark");
            this.txtRemark.BackgroundImage = null;
            this.txtRemark.Font = null;
            this.txtRemark.Name = "txtRemark";
            // 
            // btnChange
            // 
            this.btnChange.AccessibleDescription = null;
            this.btnChange.AccessibleName = null;
            resources.ApplyResources(this.btnChange, "btnChange");
            this.btnChange.BackgroundImage = null;
            this.btnChange.Font = null;
            this.btnChange.Name = "btnChange";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // newTimeSpent
            // 
            this.newTimeSpent.AccessibleDescription = null;
            this.newTimeSpent.AccessibleName = null;
            resources.ApplyResources(this.newTimeSpent, "newTimeSpent");
            this.newTimeSpent.BackgroundImage = null;
            this.newTimeSpent.CalendarFont = null;
            this.newTimeSpent.CustomFormat = null;
            this.newTimeSpent.Font = null;
            this.newTimeSpent.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.newTimeSpent.Name = "newTimeSpent";
            this.newTimeSpent.ShowUpDown = true;
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
            // 
            // curTimeSpent
            // 
            this.curTimeSpent.AccessibleDescription = null;
            this.curTimeSpent.AccessibleName = null;
            resources.ApplyResources(this.curTimeSpent, "curTimeSpent");
            this.curTimeSpent.BackgroundImage = null;
            this.curTimeSpent.CalendarFont = null;
            this.curTimeSpent.CustomFormat = null;
            this.curTimeSpent.Font = null;
            this.curTimeSpent.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.curTimeSpent.Name = "curTimeSpent";
            this.curTimeSpent.ShowUpDown = true;
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Font = null;
            this.label3.Name = "label3";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // frmChangeTimeSpent
            // 
            this.AcceptButton = this.btnChange;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmChangeTimeSpent";
            this.Load += new System.EventHandler(this.frmChangeTimeSpent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dTP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTasks;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.DateTimePicker newTimeSpent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker curTimeSpent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label3;
    }
}