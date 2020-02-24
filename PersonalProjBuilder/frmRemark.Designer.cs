namespace PersonalManager
{
    partial class frmRemark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemark));
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnAddRemark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTasksFound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
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
            // btnAddRemark
            // 
            this.btnAddRemark.AccessibleDescription = null;
            this.btnAddRemark.AccessibleName = null;
            resources.ApplyResources(this.btnAddRemark, "btnAddRemark");
            this.btnAddRemark.BackgroundImage = null;
            this.btnAddRemark.Font = null;
            this.btnAddRemark.Name = "btnAddRemark";
            this.btnAddRemark.UseVisualStyleBackColor = true;
            this.btnAddRemark.Click += new System.EventHandler(this.btnAddRemark_Click);
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // lblTasksFound
            // 
            this.lblTasksFound.AccessibleDescription = null;
            this.lblTasksFound.AccessibleName = null;
            resources.ApplyResources(this.lblTasksFound, "lblTasksFound");
            this.lblTasksFound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTasksFound.Font = null;
            this.lblTasksFound.Name = "lblTasksFound";
            // 
            // frmRemark
            // 
            this.AcceptButton = this.btnAddRemark;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.ControlBox = false;
            this.Controls.Add(this.btnAddRemark);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblTasksFound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRemark";
            this.Load += new System.EventHandler(this.frmRemark_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnAddRemark;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTasksFound;
    }
}