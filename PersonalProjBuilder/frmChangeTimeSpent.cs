using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalManager
{
    public partial class frmChangeTimeSpent : Form
    {
        public DataSet PBData;

        public frmChangeTimeSpent()
        {
            InitializeComponent();
        }

        private void frmChangeTimeSpent_Load(object sender, EventArgs e)
        {
            cmbTasks.DataSource = PBData.Tables["tblTasks"];
            cmbTasks.DisplayMember = "colTask";
        }

        private void cmbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTimesSpent();
        }

        private DateTime Hoje = DateTime.Today;
        private void GetTimesSpent()
        {
            DataTable t = GetDateTbl(false);

            curTimeSpent.Value = Hoje;
            newTimeSpent.Value = Hoje;
            if (t != null)
            {
                DataRow[] r = t.Select("colTask = '" + cmbTasks.Text + "'");
                if (r.Length > 0)
                {
                    curTimeSpent.Value += TimeSpan.FromSeconds((int)r[0]["colElapTimeInSeconds"]);
                    newTimeSpent.Value += TimeSpan.FromSeconds((int)r[0]["colElapTimeInSeconds"]);
                }
            }
        }

        /// <summary>Gets date data table.</summary>
        /// <param name="Create">Create table if it does not exist.</param>
        private DataTable GetDateTbl(bool Create)
        {
            string tblName = dTP.Value.Year.ToString() + "-" + dTP.Value.Month.ToString() + "-" + dTP.Value.Day.ToString();
            tblName = "TimeSpent:" + tblName;
            if (PBData.Tables.IndexOf(tblName) >= 0) return PBData.Tables[tblName];
            else
            {
                if (Create)
                {
                    DataTable tblTime = new DataTable(tblName);

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

                    PBData.Tables.Add(tblTime);
                    return tblTime;
                }
                else return null;
            }
        }

        private void dTP_ValueChanged(object sender, EventArgs e)
        {
            GetTimesSpent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DataTable t = GetDateTbl(true);
            DataRow[] r = t.Select("colTask = '" + cmbTasks.Text + "'");
            DataRow r2;
            if (r.Length != 0)
            {
                r2 = r[0];
            }
            else
            {
                r2 = t.NewRow();
                r2["colTask"]=cmbTasks.Text;

                t.Rows.Add(r2);
            }
            TimeSpan difTime = newTimeSpent.Value - Hoje;

            r2["colElapTimeInSeconds"] = difTime.TotalSeconds;
            r2["colElapTime"] = difTime.ToString();

            txtRemark.Text = txtRemark.Text.Trim();
            if (txtRemark.Text != "")
            {
                string s = r2["colRemarks"].ToString().Trim();
                if (s != "") s += "; ";
                r2["colRemarks"] = s + txtRemark.Text;
                txtRemark.Text = "";
            }

            GetTimesSpent();
        }
    }
}