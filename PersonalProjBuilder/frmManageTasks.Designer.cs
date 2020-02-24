namespace PersonalManager
{
    partial class frmManageTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageTasks));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.txtNewTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.cmbDelTask = new System.Windows.Forms.ComboBox();
            this.btnRemTask = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbRenTask = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.btnCreateTask);
            this.groupBox1.Controls.Add(this.txtNewTask);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = null;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.AccessibleDescription = null;
            this.btnCreateTask.AccessibleName = null;
            resources.ApplyResources(this.btnCreateTask, "btnCreateTask");
            this.btnCreateTask.BackgroundImage = null;
            this.btnCreateTask.Font = null;
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // txtNewTask
            // 
            this.txtNewTask.AccessibleDescription = null;
            this.txtNewTask.AccessibleName = null;
            resources.ApplyResources(this.txtNewTask, "txtNewTask");
            this.txtNewTask.BackgroundImage = null;
            this.txtNewTask.Font = null;
            this.txtNewTask.Name = "txtNewTask";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleDescription = null;
            this.groupBox2.AccessibleName = null;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackgroundImage = null;
            this.groupBox2.Controls.Add(this.lblConfirm);
            this.groupBox2.Controls.Add(this.cmbDelTask);
            this.groupBox2.Controls.Add(this.btnRemTask);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = null;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AccessibleDescription = null;
            this.lblConfirm.AccessibleName = null;
            resources.ApplyResources(this.lblConfirm, "lblConfirm");
            this.lblConfirm.Font = null;
            this.lblConfirm.Name = "lblConfirm";
            // 
            // cmbDelTask
            // 
            this.cmbDelTask.AccessibleDescription = null;
            this.cmbDelTask.AccessibleName = null;
            resources.ApplyResources(this.cmbDelTask, "cmbDelTask");
            this.cmbDelTask.BackgroundImage = null;
            this.cmbDelTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDelTask.Font = null;
            this.cmbDelTask.FormattingEnabled = true;
            this.cmbDelTask.Name = "cmbDelTask";
            // 
            // btnRemTask
            // 
            this.btnRemTask.AccessibleDescription = null;
            this.btnRemTask.AccessibleName = null;
            resources.ApplyResources(this.btnRemTask, "btnRemTask");
            this.btnRemTask.BackgroundImage = null;
            this.btnRemTask.Font = null;
            this.btnRemTask.Name = "btnRemTask";
            this.btnRemTask.UseVisualStyleBackColor = true;
            this.btnRemTask.Click += new System.EventHandler(this.btnRemTask_Click);
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleDescription = null;
            this.groupBox3.AccessibleName = null;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackgroundImage = null;
            this.groupBox3.Controls.Add(this.cmbRenTask);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnRename);
            this.groupBox3.Controls.Add(this.txtNewName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = null;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // cmbRenTask
            // 
            this.cmbRenTask.AccessibleDescription = null;
            this.cmbRenTask.AccessibleName = null;
            resources.ApplyResources(this.cmbRenTask, "cmbRenTask");
            this.cmbRenTask.BackgroundImage = null;
            this.cmbRenTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRenTask.Font = null;
            this.cmbRenTask.FormattingEnabled = true;
            this.cmbRenTask.Name = "cmbRenTask";
            this.cmbRenTask.SelectedIndexChanged += new System.EventHandler(this.cmbRenTask_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Font = null;
            this.label3.Name = "label3";
            // 
            // btnRename
            // 
            this.btnRename.AccessibleDescription = null;
            this.btnRename.AccessibleName = null;
            resources.ApplyResources(this.btnRename, "btnRename");
            this.btnRename.BackgroundImage = null;
            this.btnRename.Font = null;
            this.btnRename.Name = "btnRename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // txtNewName
            // 
            this.txtNewName.AccessibleDescription = null;
            this.txtNewName.AccessibleName = null;
            resources.ApplyResources(this.txtNewName, "txtNewName");
            this.txtNewName.BackgroundImage = null;
            this.txtNewName.Font = null;
            this.txtNewName.Name = "txtNewName";
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Font = null;
            this.label4.Name = "label4";
            // 
            // frmManageTasks
            // 
            this.AcceptButton = this.btnCreateTask;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmManageTasks";
            this.Load += new System.EventHandler(this.frmManageTasks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.TextBox txtNewTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbDelTask;
        private System.Windows.Forms.Button btnRemTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbRenTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label4;
    }
}