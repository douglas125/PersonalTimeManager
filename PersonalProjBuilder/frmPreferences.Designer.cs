namespace PersonalManager
{
    partial class frmPreferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreferences));
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnPickFolder = new System.Windows.Forms.Button();
            this.chkSaveCopy = new System.Windows.Forms.CheckBox();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.txtIntUpdateTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDailyBackups = new System.Windows.Forms.CheckBox();
            this.chkShowNotifs = new System.Windows.Forms.CheckBox();
            this.chkStartOnStartUp = new System.Windows.Forms.CheckBox();
            this.chkOnTop = new System.Windows.Forms.CheckBox();
            this.gbInfo.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.AccessibleDescription = null;
            this.gbInfo.AccessibleName = null;
            resources.ApplyResources(this.gbInfo, "gbInfo");
            this.gbInfo.BackgroundImage = null;
            this.gbInfo.Controls.Add(this.btnPickFolder);
            this.gbInfo.Controls.Add(this.chkSaveCopy);
            this.gbInfo.Controls.Add(this.txtFolderName);
            this.gbInfo.Controls.Add(this.txtUserName);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Font = null;
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.TabStop = false;
            // 
            // btnPickFolder
            // 
            this.btnPickFolder.AccessibleDescription = null;
            this.btnPickFolder.AccessibleName = null;
            resources.ApplyResources(this.btnPickFolder, "btnPickFolder");
            this.btnPickFolder.BackgroundImage = null;
            this.btnPickFolder.Font = null;
            this.btnPickFolder.Name = "btnPickFolder";
            this.btnPickFolder.UseVisualStyleBackColor = true;
            this.btnPickFolder.Click += new System.EventHandler(this.btnPickFolder_Click);
            // 
            // chkSaveCopy
            // 
            this.chkSaveCopy.AccessibleDescription = null;
            this.chkSaveCopy.AccessibleName = null;
            resources.ApplyResources(this.chkSaveCopy, "chkSaveCopy");
            this.chkSaveCopy.BackgroundImage = null;
            this.chkSaveCopy.Font = null;
            this.chkSaveCopy.Name = "chkSaveCopy";
            this.chkSaveCopy.UseVisualStyleBackColor = true;
            // 
            // txtFolderName
            // 
            this.txtFolderName.AccessibleDescription = null;
            this.txtFolderName.AccessibleName = null;
            resources.ApplyResources(this.txtFolderName, "txtFolderName");
            this.txtFolderName.BackgroundImage = null;
            this.txtFolderName.Font = null;
            this.txtFolderName.Name = "txtFolderName";
            // 
            // txtUserName
            // 
            this.txtUserName.AccessibleDescription = null;
            this.txtUserName.AccessibleName = null;
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.BackgroundImage = null;
            this.txtUserName.Font = null;
            this.txtUserName.Name = "txtUserName";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // folderBrowserDialog
            // 
            resources.ApplyResources(this.folderBrowserDialog, "folderBrowserDialog");
            // 
            // gbSettings
            // 
            this.gbSettings.AccessibleDescription = null;
            this.gbSettings.AccessibleName = null;
            resources.ApplyResources(this.gbSettings, "gbSettings");
            this.gbSettings.BackgroundImage = null;
            this.gbSettings.Controls.Add(this.txtIntUpdateTime);
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.chkDailyBackups);
            this.gbSettings.Controls.Add(this.chkShowNotifs);
            this.gbSettings.Controls.Add(this.chkStartOnStartUp);
            this.gbSettings.Controls.Add(this.chkOnTop);
            this.gbSettings.Font = null;
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.TabStop = false;
            // 
            // txtIntUpdateTime
            // 
            this.txtIntUpdateTime.AccessibleDescription = null;
            this.txtIntUpdateTime.AccessibleName = null;
            resources.ApplyResources(this.txtIntUpdateTime, "txtIntUpdateTime");
            this.txtIntUpdateTime.BackgroundImage = null;
            this.txtIntUpdateTime.Font = null;
            this.txtIntUpdateTime.Name = "txtIntUpdateTime";
            this.txtIntUpdateTime.Leave += new System.EventHandler(this.txtIntUpdateTime_Leave);
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
            // 
            // chkDailyBackups
            // 
            this.chkDailyBackups.AccessibleDescription = null;
            this.chkDailyBackups.AccessibleName = null;
            resources.ApplyResources(this.chkDailyBackups, "chkDailyBackups");
            this.chkDailyBackups.BackgroundImage = null;
            this.chkDailyBackups.Checked = true;
            this.chkDailyBackups.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDailyBackups.Font = null;
            this.chkDailyBackups.Name = "chkDailyBackups";
            this.chkDailyBackups.UseVisualStyleBackColor = true;
            // 
            // chkShowNotifs
            // 
            this.chkShowNotifs.AccessibleDescription = null;
            this.chkShowNotifs.AccessibleName = null;
            resources.ApplyResources(this.chkShowNotifs, "chkShowNotifs");
            this.chkShowNotifs.BackgroundImage = null;
            this.chkShowNotifs.Checked = true;
            this.chkShowNotifs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowNotifs.Font = null;
            this.chkShowNotifs.Name = "chkShowNotifs";
            this.chkShowNotifs.UseVisualStyleBackColor = true;
            // 
            // chkStartOnStartUp
            // 
            this.chkStartOnStartUp.AccessibleDescription = null;
            this.chkStartOnStartUp.AccessibleName = null;
            resources.ApplyResources(this.chkStartOnStartUp, "chkStartOnStartUp");
            this.chkStartOnStartUp.BackgroundImage = null;
            this.chkStartOnStartUp.Font = null;
            this.chkStartOnStartUp.Name = "chkStartOnStartUp";
            this.chkStartOnStartUp.UseVisualStyleBackColor = true;
            this.chkStartOnStartUp.CheckedChanged += new System.EventHandler(this.chkStartOnStartUp_CheckedChanged);
            // 
            // chkOnTop
            // 
            this.chkOnTop.AccessibleDescription = null;
            this.chkOnTop.AccessibleName = null;
            resources.ApplyResources(this.chkOnTop, "chkOnTop");
            this.chkOnTop.BackgroundImage = null;
            this.chkOnTop.Font = null;
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.UseVisualStyleBackColor = true;
            // 
            // frmPreferences
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbInfo);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPreferences";
            this.Load += new System.EventHandler(this.frmPreferences_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnPickFolder;
        private System.Windows.Forms.CheckBox chkSaveCopy;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkShowNotifs;
        private System.Windows.Forms.CheckBox chkStartOnStartUp;
        private System.Windows.Forms.CheckBox chkOnTop;
        private System.Windows.Forms.TextBox txtIntUpdateTime;
        private System.Windows.Forms.CheckBox chkDailyBackups;
    }
}