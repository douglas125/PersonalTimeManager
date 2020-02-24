namespace PersonalManager
{
    partial class frmPBPessoal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPBPessoal));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonalManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addremarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTimeSpentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAssociationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.changeTimeSpentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblNowUsing = new System.Windows.Forms.Label();
            this.lblNoTask = new System.Windows.Forms.Label();
            this.lblNoTaskIdent = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbTasks = new System.Windows.Forms.ComboBox();
            this.lblNoTaskClick = new System.Windows.Forms.Label();
            this.lblConfirmExit = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblInsSafDriv = new System.Windows.Forms.Label();
            this.lblCantSaveCopy = new System.Windows.Forms.Label();
            this.lblCantSaveLocalDir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAssoc = new System.Windows.Forms.Button();
            this.txtStringToAssociate = new System.Windows.Forms.TextBox();
            this.lblProblem = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblClearLog = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLastWindow = new System.Windows.Forms.Label();
            this.lblNotReg = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuNotify.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.ContextMenuStrip = this.contextMenuNotify;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_DoubleClick);
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuNotify
            // 
            this.contextMenuNotify.AccessibleDescription = null;
            this.contextMenuNotify.AccessibleName = null;
            resources.ApplyResources(this.contextMenuNotify, "contextMenuNotify");
            this.contextMenuNotify.BackgroundImage = null;
            this.contextMenuNotify.Font = null;
            this.contextMenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonalManagerToolStripMenuItem,
            this.addremarkToolStripMenuItem,
            this.changeTimeSpentToolStripMenuItem1,
            this.preferencesToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem1});
            this.contextMenuNotify.Name = "contextMenuNotify";
            // 
            // showPersonalManagerToolStripMenuItem
            // 
            this.showPersonalManagerToolStripMenuItem.AccessibleDescription = null;
            this.showPersonalManagerToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.showPersonalManagerToolStripMenuItem, "showPersonalManagerToolStripMenuItem");
            this.showPersonalManagerToolStripMenuItem.BackgroundImage = null;
            this.showPersonalManagerToolStripMenuItem.Name = "showPersonalManagerToolStripMenuItem";
            this.showPersonalManagerToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.showPersonalManagerToolStripMenuItem.Click += new System.EventHandler(this.showPersonalManagerToolStripMenuItem_Click);
            // 
            // addremarkToolStripMenuItem
            // 
            this.addremarkToolStripMenuItem.AccessibleDescription = null;
            this.addremarkToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.addremarkToolStripMenuItem, "addremarkToolStripMenuItem");
            this.addremarkToolStripMenuItem.BackgroundImage = null;
            this.addremarkToolStripMenuItem.Name = "addremarkToolStripMenuItem";
            this.addremarkToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.addremarkToolStripMenuItem.Click += new System.EventHandler(this.addremarkToolStripMenuItem_Click);
            // 
            // changeTimeSpentToolStripMenuItem1
            // 
            this.changeTimeSpentToolStripMenuItem1.AccessibleDescription = null;
            this.changeTimeSpentToolStripMenuItem1.AccessibleName = null;
            resources.ApplyResources(this.changeTimeSpentToolStripMenuItem1, "changeTimeSpentToolStripMenuItem1");
            this.changeTimeSpentToolStripMenuItem1.BackgroundImage = null;
            this.changeTimeSpentToolStripMenuItem1.Name = "changeTimeSpentToolStripMenuItem1";
            this.changeTimeSpentToolStripMenuItem1.ShortcutKeyDisplayString = null;
            this.changeTimeSpentToolStripMenuItem1.Click += new System.EventHandler(this.changeTimeSpentToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem1
            // 
            this.preferencesToolStripMenuItem1.AccessibleDescription = null;
            this.preferencesToolStripMenuItem1.AccessibleName = null;
            resources.ApplyResources(this.preferencesToolStripMenuItem1, "preferencesToolStripMenuItem1");
            this.preferencesToolStripMenuItem1.BackgroundImage = null;
            this.preferencesToolStripMenuItem1.Name = "preferencesToolStripMenuItem1";
            this.preferencesToolStripMenuItem1.ShortcutKeyDisplayString = null;
            this.preferencesToolStripMenuItem1.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AccessibleDescription = null;
            this.toolStripMenuItem3.AccessibleName = null;
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.AccessibleDescription = null;
            this.exitToolStripMenuItem1.AccessibleName = null;
            resources.ApplyResources(this.exitToolStripMenuItem1, "exitToolStripMenuItem1");
            this.exitToolStripMenuItem1.BackgroundImage = null;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeyDisplayString = null;
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.AccessibleDescription = null;
            this.menuStrip.AccessibleName = null;
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.BackgroundImage = null;
            this.menuStrip.Font = null;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.tasksToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.AccessibleDescription = null;
            this.quitToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            this.quitToolStripMenuItem.BackgroundImage = null;
            this.quitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToTrayToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.loadDataFromFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // minimizeToTrayToolStripMenuItem
            // 
            this.minimizeToTrayToolStripMenuItem.AccessibleDescription = null;
            this.minimizeToTrayToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.minimizeToTrayToolStripMenuItem, "minimizeToTrayToolStripMenuItem");
            this.minimizeToTrayToolStripMenuItem.BackgroundImage = null;
            this.minimizeToTrayToolStripMenuItem.Name = "minimizeToTrayToolStripMenuItem";
            this.minimizeToTrayToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.minimizeToTrayToolStripMenuItem.Click += new System.EventHandler(this.minimizeToTrayToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.AccessibleDescription = null;
            this.preferencesToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.preferencesToolStripMenuItem, "preferencesToolStripMenuItem");
            this.preferencesToolStripMenuItem.BackgroundImage = null;
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // loadDataFromFileToolStripMenuItem
            // 
            this.loadDataFromFileToolStripMenuItem.AccessibleDescription = null;
            this.loadDataFromFileToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.loadDataFromFileToolStripMenuItem, "loadDataFromFileToolStripMenuItem");
            this.loadDataFromFileToolStripMenuItem.BackgroundImage = null;
            this.loadDataFromFileToolStripMenuItem.Name = "loadDataFromFileToolStripMenuItem";
            this.loadDataFromFileToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.loadDataFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadDataFromFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AccessibleDescription = null;
            this.toolStripMenuItem1.AccessibleName = null;
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AccessibleDescription = null;
            this.exitToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.BackgroundImage = null;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.AccessibleDescription = null;
            this.tasksToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.tasksToolStripMenuItem, "tasksToolStripMenuItem");
            this.tasksToolStripMenuItem.BackgroundImage = null;
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageTasksToolStripMenuItem,
            this.manageAssociationsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.changeTimeSpentToolStripMenuItem,
            this.viewLogToolStripMenuItem,
            this.clearLogToolStripMenuItem});
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // manageTasksToolStripMenuItem
            // 
            this.manageTasksToolStripMenuItem.AccessibleDescription = null;
            this.manageTasksToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.manageTasksToolStripMenuItem, "manageTasksToolStripMenuItem");
            this.manageTasksToolStripMenuItem.BackgroundImage = null;
            this.manageTasksToolStripMenuItem.Name = "manageTasksToolStripMenuItem";
            this.manageTasksToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.manageTasksToolStripMenuItem.Click += new System.EventHandler(this.manageTasksToolStripMenuItem_Click);
            // 
            // manageAssociationsToolStripMenuItem
            // 
            this.manageAssociationsToolStripMenuItem.AccessibleDescription = null;
            this.manageAssociationsToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.manageAssociationsToolStripMenuItem, "manageAssociationsToolStripMenuItem");
            this.manageAssociationsToolStripMenuItem.BackgroundImage = null;
            this.manageAssociationsToolStripMenuItem.Name = "manageAssociationsToolStripMenuItem";
            this.manageAssociationsToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.manageAssociationsToolStripMenuItem.Click += new System.EventHandler(this.manageAssocsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AccessibleDescription = null;
            this.toolStripMenuItem2.AccessibleName = null;
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // changeTimeSpentToolStripMenuItem
            // 
            this.changeTimeSpentToolStripMenuItem.AccessibleDescription = null;
            this.changeTimeSpentToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.changeTimeSpentToolStripMenuItem, "changeTimeSpentToolStripMenuItem");
            this.changeTimeSpentToolStripMenuItem.BackgroundImage = null;
            this.changeTimeSpentToolStripMenuItem.Name = "changeTimeSpentToolStripMenuItem";
            this.changeTimeSpentToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.changeTimeSpentToolStripMenuItem.Click += new System.EventHandler(this.changeTimeSpentToolStripMenuItem_Click);
            // 
            // viewLogToolStripMenuItem
            // 
            this.viewLogToolStripMenuItem.AccessibleDescription = null;
            this.viewLogToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.viewLogToolStripMenuItem, "viewLogToolStripMenuItem");
            this.viewLogToolStripMenuItem.BackgroundImage = null;
            this.viewLogToolStripMenuItem.Name = "viewLogToolStripMenuItem";
            this.viewLogToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.viewLogToolStripMenuItem.Click += new System.EventHandler(this.viewLogToolStripMenuItem_Click);
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.AccessibleDescription = null;
            this.clearLogToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.clearLogToolStripMenuItem, "clearLogToolStripMenuItem");
            this.clearLogToolStripMenuItem.BackgroundImage = null;
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.AccessibleDescription = null;
            this.aboutToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.BackgroundImage = null;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblNowUsing
            // 
            this.lblNowUsing.AccessibleDescription = null;
            this.lblNowUsing.AccessibleName = null;
            resources.ApplyResources(this.lblNowUsing, "lblNowUsing");
            this.lblNowUsing.Font = null;
            this.lblNowUsing.Name = "lblNowUsing";
            // 
            // lblNoTask
            // 
            this.lblNoTask.AccessibleDescription = null;
            this.lblNoTask.AccessibleName = null;
            resources.ApplyResources(this.lblNoTask, "lblNoTask");
            this.lblNoTask.Font = null;
            this.lblNoTask.Name = "lblNoTask";
            // 
            // lblNoTaskIdent
            // 
            this.lblNoTaskIdent.AccessibleDescription = null;
            this.lblNoTaskIdent.AccessibleName = null;
            resources.ApplyResources(this.lblNoTaskIdent, "lblNoTaskIdent");
            this.lblNoTaskIdent.Font = null;
            this.lblNoTaskIdent.Name = "lblNoTaskIdent";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.cmbTasks);
            this.groupBox1.Font = null;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.AccessibleDescription = null;
            this.btnNew.AccessibleName = null;
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.BackgroundImage = null;
            this.btnNew.Font = null;
            this.btnNew.Name = "btnNew";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.manageTasksToolStripMenuItem_Click);
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
            // 
            // lblNoTaskClick
            // 
            this.lblNoTaskClick.AccessibleDescription = null;
            this.lblNoTaskClick.AccessibleName = null;
            resources.ApplyResources(this.lblNoTaskClick, "lblNoTaskClick");
            this.lblNoTaskClick.Font = null;
            this.lblNoTaskClick.Name = "lblNoTaskClick";
            // 
            // lblConfirmExit
            // 
            this.lblConfirmExit.AccessibleDescription = null;
            this.lblConfirmExit.AccessibleName = null;
            resources.ApplyResources(this.lblConfirmExit, "lblConfirmExit");
            this.lblConfirmExit.Font = null;
            this.lblConfirmExit.Name = "lblConfirmExit";
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleDescription = null;
            this.groupBox2.AccessibleName = null;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackgroundImage = null;
            this.groupBox2.Controls.Add(this.lblInsSafDriv);
            this.groupBox2.Controls.Add(this.lblCantSaveCopy);
            this.groupBox2.Controls.Add(this.lblCantSaveLocalDir);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAssoc);
            this.groupBox2.Controls.Add(this.txtStringToAssociate);
            this.groupBox2.Controls.Add(this.lblProblem);
            this.groupBox2.Font = null;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lblInsSafDriv
            // 
            this.lblInsSafDriv.AccessibleDescription = null;
            this.lblInsSafDriv.AccessibleName = null;
            resources.ApplyResources(this.lblInsSafDriv, "lblInsSafDriv");
            this.lblInsSafDriv.Font = null;
            this.lblInsSafDriv.Name = "lblInsSafDriv";
            // 
            // lblCantSaveCopy
            // 
            this.lblCantSaveCopy.AccessibleDescription = null;
            this.lblCantSaveCopy.AccessibleName = null;
            resources.ApplyResources(this.lblCantSaveCopy, "lblCantSaveCopy");
            this.lblCantSaveCopy.Font = null;
            this.lblCantSaveCopy.Name = "lblCantSaveCopy";
            // 
            // lblCantSaveLocalDir
            // 
            this.lblCantSaveLocalDir.AccessibleDescription = null;
            this.lblCantSaveLocalDir.AccessibleName = null;
            resources.ApplyResources(this.lblCantSaveLocalDir, "lblCantSaveLocalDir");
            this.lblCantSaveLocalDir.Font = null;
            this.lblCantSaveLocalDir.Name = "lblCantSaveLocalDir";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // btnAssoc
            // 
            this.btnAssoc.AccessibleDescription = null;
            this.btnAssoc.AccessibleName = null;
            resources.ApplyResources(this.btnAssoc, "btnAssoc");
            this.btnAssoc.BackgroundImage = null;
            this.btnAssoc.Font = null;
            this.btnAssoc.Name = "btnAssoc";
            this.btnAssoc.UseVisualStyleBackColor = true;
            this.btnAssoc.Click += new System.EventHandler(this.btnAssoc_Click);
            // 
            // txtStringToAssociate
            // 
            this.txtStringToAssociate.AccessibleDescription = null;
            this.txtStringToAssociate.AccessibleName = null;
            resources.ApplyResources(this.txtStringToAssociate, "txtStringToAssociate");
            this.txtStringToAssociate.BackgroundImage = null;
            this.txtStringToAssociate.Font = null;
            this.txtStringToAssociate.Name = "txtStringToAssociate";
            // 
            // lblProblem
            // 
            this.lblProblem.AccessibleDescription = null;
            this.lblProblem.AccessibleName = null;
            resources.ApplyResources(this.lblProblem, "lblProblem");
            this.lblProblem.Font = null;
            this.lblProblem.Name = "lblProblem";
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleDescription = null;
            this.groupBox3.AccessibleName = null;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackgroundImage = null;
            this.groupBox3.Controls.Add(this.lblNoTaskClick);
            this.groupBox3.Controls.Add(this.lblConfirmExit);
            this.groupBox3.Controls.Add(this.lblNoTaskIdent);
            this.groupBox3.Controls.Add(this.lblNowUsing);
            this.groupBox3.Controls.Add(this.lblClearLog);
            this.groupBox3.Controls.Add(this.lblWelcome);
            this.groupBox3.Controls.Add(this.lblNoTask);
            this.groupBox3.Controls.Add(this.lblLastWindow);
            this.groupBox3.Font = null;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // lblClearLog
            // 
            this.lblClearLog.AccessibleDescription = null;
            this.lblClearLog.AccessibleName = null;
            resources.ApplyResources(this.lblClearLog, "lblClearLog");
            this.lblClearLog.Font = null;
            this.lblClearLog.Name = "lblClearLog";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AccessibleDescription = null;
            this.lblWelcome.AccessibleName = null;
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Font = null;
            this.lblWelcome.Name = "lblWelcome";
            // 
            // lblLastWindow
            // 
            this.lblLastWindow.AccessibleDescription = null;
            this.lblLastWindow.AccessibleName = null;
            resources.ApplyResources(this.lblLastWindow, "lblLastWindow");
            this.lblLastWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastWindow.Font = null;
            this.lblLastWindow.Name = "lblLastWindow";
            // 
            // lblNotReg
            // 
            this.lblNotReg.AccessibleDescription = null;
            this.lblNotReg.AccessibleName = null;
            resources.ApplyResources(this.lblNotReg, "lblNotReg");
            this.lblNotReg.Font = null;
            this.lblNotReg.Name = "lblNotReg";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "TrajMan.PMF";
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            // 
            // frmPBPessoal
            // 
            this.AcceptButton = this.btnAssoc;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.lblNotReg);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBox2);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmPBPessoal";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmPBPessoal_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmPBPessoal_MouseClick);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPBPessoal_FormClosing);
            this.Resize += new System.EventHandler(this.frmPBPessoal_Resize);
            this.contextMenuNotify.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblNowUsing;
        private System.Windows.Forms.Label lblNoTask;
        private System.Windows.Forms.Label lblNoTaskIdent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTasks;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAssociationsToolStripMenuItem;
        private System.Windows.Forms.Label lblConfirmExit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewLogToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblLastWindow;
        private System.Windows.Forms.TextBox txtStringToAssociate;
        private System.Windows.Forms.Button btnAssoc;
        private System.Windows.Forms.Label lblNoTaskClick;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ContextMenuStrip contextMenuNotify;
        private System.Windows.Forms.ToolStripMenuItem showPersonalManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.Label lblCantSaveLocalDir;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.Label lblCantSaveCopy;
        private System.Windows.Forms.Label lblNotReg;
        private System.Windows.Forms.Label lblInsSafDriv;
        private System.Windows.Forms.ToolStripMenuItem addremarkToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ToolStripMenuItem loadDataFromFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTimeSpentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTimeSpentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.Label lblClearLog;
    }
}

