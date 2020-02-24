using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PersonalManager
{
    public partial class frmPBPessoal : Form
    {
        #region Leitura da janela atual

        [DllImport("user32.dll")]
        static extern int GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(int hWnd, StringBuilder text, int count);

        [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int GetWindow(int hwnd, uint wFlag);

        public class GetWindowConstants
        {
            public const uint GW_HWNDFIRST = 0;
            public const uint GW_HWNDLAST = 1;
            public const uint GW_HWNDNEXT = 2;
            public const uint GW_HWNDPREV = 3;
            public const uint GW_OWNER = 4;
            public const uint GW_CHILD = 5;
            public const uint GW_ENABLEDPOPUP = 6;
            public const uint GW_MAX = 6;
        }

        /// <summary>Exemplos de uso das funcoes.</summary>
        private void ExamplesOfGetActiveWindow()
        {

            const int nChars = 256;
            int handle = 0;
            StringBuilder Buff = new StringBuilder(nChars);

            handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                string TituloJanela = Buff.ToString();
                string Handle = handle.ToString();
            }

            int handle2 = GetWindow(handle, GetWindowConstants.GW_HWNDFIRST);
            GetWindowText(handle2, Buff, nChars);
            string tit2 = Buff.ToString();

            int handle3 = GetWindow(handle, GetWindowConstants.GW_HWNDLAST);

            List<string> tits = new List<string>();

            while (handle2 != handle3)
            {
                handle2 = GetWindow(handle2, GetWindowConstants.GW_HWNDNEXT);
                GetWindowText(handle2, Buff, nChars);
                tit2 = Buff.ToString();
                if (tit2.Trim() != "") tits.Add(tit2);
            }
        }

        private string GetActiveWindow()
        {
            const int nChars = 256;
            int handle = 0;
            StringBuilder Buff = new StringBuilder(nChars);

            handle = GetForegroundWindow();

            string Titulo = "";

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                Titulo = Buff.ToString();
                string Handle = handle.ToString();
            }

            return Titulo;
        }

        #endregion

        #region Calculos de tempo, exibicao de notificacoes

        /// <summary>Checks if application is registered for the computer</summary>
        private bool IsRegistered
        {
            get
            {
                //Free software now
                return true;

                /*
                List<long> L = new List<long>();

                #region SoftMC
                L.Add(8380061); L[0] *= 107; L[0] *= 2;
                L.Add(95539); L[1] *= 12473; L[1] *= 2;
                L.Add(14957); L[2] *= 119551; //Rosana
                //L.Add(19207); L[2] *= 32130; //Utino
                //L.Add(18979); L[2] *= 25134; //Sarara
                bool temp = Volume.GetVol.IsRegistered(L, "SoftMC");
                #endregion

                #region Petrobras
                //L.Clear();
                //L.Add(38754761); L[0] *= 87; //Petrobras
                //bool temp = Volume.GetVol.IsRegistered(L, "Petrobras");
                #endregion

                return temp;
                */
            }
        }

        private bool FirstTime = true;

        private string CurrentWindow = "", LastWindow = "";
        List<string> CurrentTasks = new List<string>();
        private void timer_Tick(object sender, EventArgs e)
        {
            if (FirstTime)
            {
                FirstTime = false;
                notifyIcon.BalloonTipTitle = lblWelcome.Text + " " + PersonalPBData.Tables["Preferences"].Rows[0]["txtUserName"].ToString(); ;
                notifyIcon.BalloonTipText = this.Text;

                notifyIcon.ShowBalloonTip(100);
            }

            if (!IsRegistered)
            {
                notifyIcon.BalloonTipTitle = lblNotReg.Text;
                notifyIcon.BalloonTipText = lblInsSafDriv.Text;

                notifyIcon.ShowBalloonTip(100);
            }
            else
            {

                //Computes timings
                ComputeTiming();

                //Show notifications?
                string ss = PersonalPBData.Tables["Preferences"].Rows[0]["chkShowNotifs"].ToString();
                bool showNotifications = (ss.ToLower() != "false");
                

                //Checks for changes in windows
                string CurrWin = GetActiveWindow();

                if (CurrWin != "" && CurrentWindow != CurrWin)
                {
                    //identifies tasks
                    CurrentTasks.Clear();

                    //find task associated to window
                    foreach (DataTable t in PersonalPBData.Tables)
                    {
                        if (t.TableName.StartsWith("Associations:"))
                        {
                            for (int i = 0; i < t.Rows.Count; i++)
                            {
                                //Find string
                                string busca = t.Rows[i]["colAssoc"].ToString().ToLower();
                                int pos = CurrWin.ToLower().IndexOf(busca);
                                if (pos >= 0)
                                {
                                    //Found?
                                    string[] s = t.TableName.Split(':');
                                    CurrentTasks.Add(s[1]);
                                    i = t.Rows.Count;
                                }
                            }
                        }
                    }

                    //information
                    if (CurrentWindow != "") LastWindow = CurrentWindow;
                    CurrentWindow = CurrWin;
                    notifyIcon.BalloonTipTitle = lblNowUsing.Text;

                    string str = "";
                    for (int i = 0; i < CurrentTasks.Count; i++)
                    {
                        if (i != 0) str += "\n";
                        str += (1 + i).ToString() + ": " + CurrentTasks[i];
                        txtStringToAssociate.Text = "";
                    }

                    if (str != "")
                    {
                        //tasks have been found. Show it or not, based on user preference

                        notifyIcon.BalloonTipText = str; //CurrWin;
                        if (showNotifications) notifyIcon.ShowBalloonTip(100);

                    }
                    else
                    {
                        notifyIcon.BalloonTipText = lblNoTaskClick.Text;
                        if (this.WindowState == FormWindowState.Minimized)
                        {
                            txtStringToAssociate.Text = CurrWin;
                            txtStringToAssociate.SelectAll();
                        }
                        if (showNotifications) notifyIcon.ShowBalloonTip(100);
                    }


                }
                else if (CurrWin == "" && CurrentWindow != CurrWin)
                {
                    if (CurrentWindow != "") LastWindow = CurrentWindow;
                    CurrentWindow = CurrWin;
                    notifyIcon.BalloonTipTitle = lblNoTask.Text;
                    notifyIcon.BalloonTipText = lblNoTaskIdent.Text;

                    if (showNotifications) notifyIcon.ShowBalloonTip(100);
                }
                lblLastWindow.Text = LastWindow;


                //Applies preferences
                ApplyPrefs();

                //Clears memory
                GC.Collect();
            }
        }

        /// <summary>Creates a datatable for today if one doesnt already exist. Returns table.</summary>
        private DataTable CreateTodayTable()
        {
            //Computes timing
            string hoje = DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString();
            //Checks if today exists in datatable
            string NametblTime = "TimeSpent:" + hoje;
            DataTable tblTime;

            if (PersonalPBData.Tables.IndexOf(NametblTime) < 0)
            {
                tblTime = new DataTable(NametblTime);

                //creates data
                DataColumn[] key = new DataColumn[1];
                key[0] = new DataColumn();
                key[0].DataType = System.Type.GetType("System.Int32");
                key[0].ColumnName = "Count";
                key[0].AutoIncrement = true;
                key[0].ReadOnly = true;

                DataColumn c1 = new DataColumn("colTask", System.Type.GetType("System.String"));
                DataColumn c2 = new DataColumn("colElapTimeInSeconds", System.Type.GetType("System.Int32"));
                DataColumn c3 = new DataColumn("colElapTime", System.Type.GetType("System.String"));
                DataColumn c4 = new DataColumn("colRemarks", System.Type.GetType("System.String"));

                tblTime.Columns.Add(key[0]);
                tblTime.Columns.Add(c1);
                tblTime.Columns.Add(c3);
                tblTime.Columns.Add(c4);
                tblTime.Columns.Add(c2);
                tblTime.PrimaryKey = key;

                PersonalPBData.Tables.Add(tblTime);
            }
            else
            {
                tblTime = PersonalPBData.Tables[NametblTime];
            }

            return tblTime;
        }

        /// <summary>Computes times spent on each task</summary>
        private void ComputeTiming()
        {
            //Creates a table for today
            DataTable tblTime = CreateTodayTable();
            string NametblTime = tblTime.TableName;


            //updates tasks times
            for (int i = 0; i < CurrentTasks.Count; i++)
            {
                //Checks if task has already been added
                DataRow[] rCheck = tblTime.Select("colTask = '" + CurrentTasks[i] + "'");
                DataRow CurrRow;
                if (rCheck.Length == 0)
                {
                    //There isnt, add
                    CurrRow = tblTime.NewRow();
                    CurrRow["colTask"] = CurrentTasks[i];
                    CurrRow["colElapTimeInSeconds"] = timer.Interval / 1000;
                    tblTime.Rows.Add(CurrRow);
                }
                else
                {
                    CurrRow = rCheck[0];
                    CurrRow["colElapTimeInSeconds"] = (int)CurrRow["colElapTimeInSeconds"] + timer.Interval / 1000;
                    int ii = (int)CurrRow["colElapTimeInSeconds"];
                }
                TimeSpan ts = new TimeSpan(0, 0, (int)CurrRow["colElapTimeInSeconds"]);
                CurrRow["colElapTime"] = ts.ToString();
            }

            tblTime.Dispose();
        }

        /// <summary>Applies user preferences</summary>
        private void ApplyPrefs()
        {
            string s = PersonalPBData.Tables["Preferences"].Rows[0]["chkOnTop"].ToString();

            bool topMostPref = (s.ToLower() == "true");
            if (this.TopMost != topMostPref) this.TopMost = topMostPref;

            timer.Interval = (int)PersonalPBData.Tables["Preferences"].Rows[0]["txtIntUpdateTime"] * 1000;


            //Tries to save data
            string SPath = "";
            try
            {
                SPath = Application.StartupPath + "\\";
                PersonalPBData.WriteXml(SPath + "ProjMan.PMF", XmlWriteMode.WriteSchema);
            }
            catch
            {
                notifyIcon.BalloonTipTitle = lblProblem.Text;
                notifyIcon.BalloonTipText = lblCantSaveLocalDir.Text + " " + SPath;
                notifyIcon.ShowBalloonTip(100);
            }

            s = PersonalPBData.Tables["Preferences"].Rows[0]["chkSaveCopy"].ToString();
            bool saveCopyPref = (s.ToLower() == "true") && (frmPrefs == null || frmPrefs.IsDisposed);

            if (saveCopyPref)
            {
                try
                {
                    string s2 = PersonalPBData.Tables["Preferences"].Rows[0]["txtFolderName"].ToString();
                    if (!(s2.EndsWith("\\"))) s2 += "\\";
                    s2 += "ProjMan - " + PersonalPBData.Tables["Preferences"].Rows[0]["txtUserName"].ToString() + ".PMF";

                    PersonalPBData.WriteXml(s2, XmlWriteMode.WriteSchema);
                }
                catch
                {
                    notifyIcon.BalloonTipTitle = lblProblem.Text;
                    notifyIcon.BalloonTipText = lblCantSaveCopy.Text + " " + PersonalPBData.Tables["Preferences"].Rows[0]["txtFolderName"].ToString();
                    notifyIcon.ShowBalloonTip(100);
                }
            }

            s = PersonalPBData.Tables["Preferences"].Rows[0]["chkDailyBackups"].ToString();
            bool saveBkpCopyPref = (s.ToLower() != "false") && (frmPrefs == null || frmPrefs.IsDisposed);

            if (saveBkpCopyPref)
            {
                try
                {
                    string hoje = DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString();

                    SPath = Application.StartupPath + "\\";
                    PersonalPBData.WriteXml(SPath + "ProjMan - " + PersonalPBData.Tables["Preferences"].Rows[0]["txtUserName"].ToString() +
                        " - " + hoje + ".PMF", XmlWriteMode.WriteSchema);
                }
                catch
                {
                    notifyIcon.BalloonTipTitle = lblProblem.Text;
                    notifyIcon.BalloonTipText = lblCantSaveLocalDir.Text + " " + SPath;
                    notifyIcon.ShowBalloonTip(100);
                }
            }
        }

        #endregion

        #region Minimizacao para o tray e exit do aplicativo

        public frmPBPessoal()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.LCID);

            InitializeComponent();
        }

        private void frmPBPessoal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Focus();
        }

        /// <summary>Will not cancel this type of exit.</summary>
        bool NoCancel = false;
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoCancel = true;
            Application.Exit();
        }

        private void frmPBPessoal_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizeToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Focus();
            }
        }


        private void showPersonalManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Focus();
        }

        private void frmPBPessoal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (System.Windows.Forms.MessageBox.Show(lblConfirmExit.Text,
            //    this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            if (this.WindowState != FormWindowState.Minimized && !NoCancel)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                //This saves files
                timer_Tick(sender, e);

                notifyIcon.Dispose();
            }
        }


        #endregion

        #region Bancos de dados

        DataSet PersonalPBData = new DataSet();

        private void frmPBPessoal_Load(object sender, EventArgs e)
        {
            notifyIcon.Text = this.Text;
            this.Hide();
            //reads existing data
            try
            {
                string SPath = Application.StartupPath + "\\";

                PersonalPBData.ReadXml(SPath + "ProjMan.PMF");
            }
            catch
            { }

            CheckStructure();

            timer.Enabled = true;
        }

        /// <summary>Checks and corrects dataset structure</summary>
        private void CheckStructure()
        {

            //Cant find tasks table, create it
            if (PersonalPBData.Tables.IndexOf("tblTasks") < 0)
            {
                CriaTaskTable();
            }

            //Cant find preferences, show preferences form
            if (PersonalPBData.Tables.IndexOf("Preferences") < 0)
            {
                EventArgs e=new EventArgs();
                preferencesToolStripMenuItem_Click(this, e);
            }

            cmbTasks.DataSource = PersonalPBData.Tables["tblTasks"];
            cmbTasks.DisplayMember = "colTask";


        }

        private void CriaTaskTable()
        {
            DataTable tasksTable = new DataTable("tblTasks");

            DataColumn[] key = new DataColumn[1];
            key[0] = new DataColumn();
            key[0].DataType = System.Type.GetType("System.Int32");
            key[0].ColumnName = "Count";
            key[0].AutoIncrement = true;
            key[0].ReadOnly = true;

            DataColumn c = new DataColumn("colTask", System.Type.GetType("System.String"));

            tasksTable.Columns.Add(key[0]);
            tasksTable.Columns.Add(c);
            tasksTable.PrimaryKey = key;

            PersonalPBData.Tables.Add(tasksTable);
        }

        #endregion

        #region Show forms

        frmManageTasks frmManTask;
        private void manageTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmManTask == null || frmManTask.IsDisposed)
                frmManTask = new frmManageTasks();

            frmManTask.PBData = PersonalPBData;
            frmManTask.ComboPai = this.cmbTasks;

            frmManTask.Show();
        }

        frmManageAssociations frmManAssoc;
        private void manageAssocsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmManAssoc == null || frmManAssoc.IsDisposed)
                frmManAssoc = new frmManageAssociations();

            frmManAssoc.PBData = PersonalPBData;

            frmManAssoc.Show();
        }
        frmViewTimes frmLog;
        private void viewLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmLog == null || frmLog.IsDisposed)
                frmLog = new frmViewTimes();

            frmLog.PBData = PersonalPBData;

            frmLog.Show();
        }

        frmPreferences frmPrefs;
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPrefs == null || frmPrefs.IsDisposed)
                frmPrefs = new frmPreferences();

            frmPrefs.data = PersonalPBData;

            frmPrefs.Show();
        }

        AboutBox frmAbout;
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAbout == null || frmAbout.IsDisposed)
                frmAbout = new AboutBox();

            frmAbout.Show();
        }

        frmChangeTimeSpent frmChange;
        private void changeTimeSpentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmChange == null || frmChange.IsDisposed)
                frmChange = new frmChangeTimeSpent();

            frmChange.PBData = PersonalPBData;

            frmChange.Show();
        }

        #endregion


        private void btnAssoc_Click(object sender, EventArgs e)
        {
            txtStringToAssociate.Text = txtStringToAssociate.Text.Trim();

            if (cmbTasks.Text != "" && txtStringToAssociate.Text!="")
            {
                DataTable t = PersonalPBData.Tables["Associations:" + cmbTasks.Text];
                DataRow r = t.NewRow();

                //does row already exist?
                DataRow[] rCheck = t.Select("colAssoc = '" + txtStringToAssociate.Text + "'");

                if (rCheck.Length == 0)
                {
                    //adds if it does not.
                    r["colAssoc"] = txtStringToAssociate.Text;
                    t.Rows.Add(r);
                }
                txtStringToAssociate.Text = "";
            }
        }

        private void addremarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] curTasks = CurrentTasks.ToArray();

            //Checks if there are tasks
            if (curTasks.Length == 0)
            {
                System.Windows.Forms.MessageBox.Show(lblNoTaskIdent.Text, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frmRemark frmRem = new frmRemark();
                string tasksFound = "";
                for (int i = 0; i < curTasks.Length; i++)
                    tasksFound += (i + 1).ToString() + ": " + curTasks[i] + " ";

                frmRem.lblTasksFound.Text = tasksFound;
                frmRem.TopMost = true;
                frmRem.ShowDialog();

                string[] now = DateTime.Now.ToString().Split();

                frmRem.Text = XMLFuncs.FileReader.RemoveReservedChars(frmRem.Text);

                if (frmRem.txtRemark.Text != "")
                {
                    try
                    {
                        //Updates activities
                        DataTable tblTime = CreateTodayTable();

                        //Add remark to activities
                        for (int i = 0; i < curTasks.Length; i++)
                        {
                            DataRow[] r = tblTime.Select("colTask = '" + curTasks[i] + "'");
                            string RemAnt = r[0]["colRemarks"].ToString().Trim();
                            if (RemAnt != "") RemAnt = RemAnt + "; ";
                            RemAnt = RemAnt + now[1] + " - " + frmRem.txtRemark.Text.Trim();
                            r[0]["colRemarks"] = RemAnt;
                        }
                    }
                    catch { }
                }
                frmRem.Dispose();
            }
        }

        private void loadDataFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PersonalPBData = new DataSet();
                try
                {
                    PersonalPBData.ReadXml(openFileDialog.FileName);
                }
                catch { }

                CheckStructure();
            }
        }

        private void clearLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show(lblClearLog.Text, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < PersonalPBData.Tables.Count; i++)
                {
                    if (PersonalPBData.Tables[i].TableName.StartsWith("TimeSpent:"))
                    {
                        PersonalPBData.Tables.RemoveAt(i);
                        i--;
                    }
                }
            }
        }



    }
}