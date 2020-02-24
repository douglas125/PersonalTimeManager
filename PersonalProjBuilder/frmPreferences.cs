using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;


namespace PersonalManager
{
    public partial class frmPreferences : Form
    {
        // The path to the key where Windows looks for startup applications
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);


        private DataTable Preferences;
        public DataSet data;

        public frmPreferences()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.LCID);

            InitializeComponent();
        }

        private void txtIntUpdateTime_Leave(object sender, EventArgs e)
        {
            double t;
            double.TryParse(txtIntUpdateTime.Text, out t);
            if (t <= 0)
                txtIntUpdateTime.Text = "1";
            else if (t > 30)
                txtIntUpdateTime.Text = "30";
        }

        private void frmPreferences_Load(object sender, EventArgs e)
        {
            if (data.Tables.IndexOf("Preferences") < 0)
            {
                Preferences = new DataTable("Preferences");
                data.Tables.Add(Preferences);
            }
            else Preferences = data.Tables["Preferences"];

            try
            {
                // Check to see the current state (running at startup or not)
                if (rkApp.GetValue("PersonalManager") == null)
                {
                    // The value doesn't exist, the application is not set to run at startup
                    chkStartOnStartUp.Checked = false;
                }
                else
                {
                    // The value exists, the application is set to run at startup
                    chkStartOnStartUp.Checked = true;
                }
            }
            catch { }

            AssociaPreferencias();
        }

        private void AssociaPreferencias()
        {
            foreach (Control c in gbInfo.Controls)
                XMLFuncs.CreateColumn(Preferences, c);

            foreach (Control c in gbSettings.Controls)
                XMLFuncs.CreateColumn(Preferences, c);
        }

        private void btnPickFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderName.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void chkStartOnStartUp_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkStartOnStartUp.Checked)
                {
                    // Add the value in the registry so that the application runs at startup
                    rkApp.SetValue("PersonalManager", Application.ExecutablePath.ToString());
                }
                else
                {
                    // Remove the value from the registry so that the application doesn't start
                    rkApp.DeleteValue("PersonalManager", false);
                }
            }
            catch { }


        }
    }
}