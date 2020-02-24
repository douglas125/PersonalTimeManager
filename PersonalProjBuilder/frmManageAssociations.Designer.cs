namespace PersonalManager
{
    partial class frmManageAssociations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageAssociations));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAssocTasks = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAssocTask = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.groupBox1.Controls.Add(this.cmbAssocTasks);
            this.groupBox1.Font = null;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cmbAssocTasks
            // 
            this.cmbAssocTasks.AccessibleDescription = null;
            this.cmbAssocTasks.AccessibleName = null;
            resources.ApplyResources(this.cmbAssocTasks, "cmbAssocTasks");
            this.cmbAssocTasks.BackgroundImage = null;
            this.cmbAssocTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssocTasks.Font = null;
            this.cmbAssocTasks.FormattingEnabled = true;
            this.cmbAssocTasks.Name = "cmbAssocTasks";
            this.cmbAssocTasks.SelectedIndexChanged += new System.EventHandler(this.cmbAssocTasks_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleDescription = null;
            this.groupBox2.AccessibleName = null;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackgroundImage = null;
            this.groupBox2.Controls.Add(this.lblAssocTask);
            this.groupBox2.Controls.Add(this.dataGrid);
            this.groupBox2.Font = null;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lblAssocTask
            // 
            this.lblAssocTask.AccessibleDescription = null;
            this.lblAssocTask.AccessibleName = null;
            resources.ApplyResources(this.lblAssocTask, "lblAssocTask");
            this.lblAssocTask.Font = null;
            this.lblAssocTask.Name = "lblAssocTask";
            // 
            // dataGrid
            // 
            this.dataGrid.AccessibleDescription = null;
            this.dataGrid.AccessibleName = null;
            resources.ApplyResources(this.dataGrid, "dataGrid");
            this.dataGrid.BackgroundImage = null;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Font = null;
            this.dataGrid.Name = "dataGrid";
            // 
            // frmManageAssociations
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = null;
            this.MaximizeBox = false;
            this.Name = "frmManageAssociations";
            this.Load += new System.EventHandler(this.frmManageAssociations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbAssocTasks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label lblAssocTask;
    }
}