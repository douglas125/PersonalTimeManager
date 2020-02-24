using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalManager
{
    public partial class frmManageTasks : Form
    {
        public DataSet PBData;
        private DataTable tblTasks;

        /// <summary>Combobox displaying tasks in parent</summary>
        public ComboBox ComboPai;

        public frmManageTasks()
        {
            InitializeComponent();
        }

        private void frmManageTasks_Load(object sender, EventArgs e)
        {
            tblTasks = PBData.Tables["tblTasks"];

            cmbDelTask.DataSource = tblTasks;
            cmbDelTask.DisplayMember = "colTask";

            cmbRenTask.DataSource = tblTasks;
            cmbRenTask.DisplayMember = "colTask";
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            txtNewTask.Text = XMLFuncs.FileReader.RemoveReservedChars(txtNewTask.Text);

            if (txtNewTask.Text != "" && (!TaskExists(txtNewTask.Text)))
            {
                //Creates association table
                string name = "Associations:" + txtNewTask.Text;
                DataTable t = new DataTable("Associations:" + txtNewTask.Text);

                if (PBData.Tables.IndexOf(name) < 0)
                {
                    //Adds item to tasks
                    DataRow r = tblTasks.NewRow();
                    r["colTask"] = txtNewTask.Text;
                    tblTasks.Rows.Add(r);

                    cmbDelTask.SelectedIndex = cmbDelTask.Items.Count - 1;
                    ComboPai.SelectedIndex = ComboPai.Items.Count - 1;
                    txtNewTask.Text = "";

                    //Adds datatable
                    DataColumn[] key = new DataColumn[1];
                    key[0] = new DataColumn();
                    key[0].DataType = System.Type.GetType("System.Int32");
                    key[0].ColumnName = "Count";
                    key[0].AutoIncrement = true;
                    key[0].ReadOnly = true;

                    DataColumn c = new DataColumn("colAssoc", System.Type.GetType("System.String"));

                    t.Columns.Add(key[0]);
                    t.Columns.Add(c);
                    t.PrimaryKey = key;

                    PBData.Tables.Add(t);
                }
            }
        }

        private void btnRemTask_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show(lblConfirm.Text + " " + cmbDelTask.Text + "?",
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delString = cmbDelTask.Text;

                //Destroys task
                DataRow[] r = tblTasks.Select("colTask = '" + cmbDelTask.Text + "'");
                for (int i = 0; i < r.Length; i++)
                    tblTasks.Rows.Remove(r[i]);

                //Destroys associated info
                for (int i = 0; i < PBData.Tables.Count; i++)
                {
                    if (PBData.Tables[i].TableName.EndsWith(":" + delString))
                    {
                        PBData.Tables.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        private void cmbRenTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNewName.Text = cmbRenTask.Text;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {

            txtNewName.Text = XMLFuncs.FileReader.RemoveReservedChars(txtNewName.Text);

            if (txtNewName.Text != "" && (!TaskExists(txtNewName.Text)))
            {
                string renString = cmbRenTask.Text;

                //Renames task
                DataRow[] r = tblTasks.Select("colTask = '" + cmbRenTask.Text + "'");
                for (int i = 0; i < r.Length; i++)
                    r[i]["colTask"] = txtNewName.Text;

                //Renames associated info
                for (int i = 0; i < PBData.Tables.Count; i++)
                {
                    if (PBData.Tables[i].TableName.EndsWith(":"+renString))
                    {
                        string ss = PBData.Tables[i].TableName.Substring(0, PBData.Tables[i].TableName.Length - renString.Length);
                        PBData.Tables[i].TableName = ss + txtNewName.Text;
                    }
                }
            }
        }

        /// <summary>Returns true if a task already exists</summary>
        /// <param name="taskName">Task name to check</param>
        private bool TaskExists(string taskName)
        {
            DataRow[] r = tblTasks.Select("colTask = '" + taskName + "'");
            return (r.Length != 0);
        }

    }
}