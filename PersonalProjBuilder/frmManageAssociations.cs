using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalManager
{
    public partial class frmManageAssociations : Form
    {

        public DataSet PBData;

        public frmManageAssociations()
        {
            InitializeComponent();
        }

        private void frmManageAssociations_Load(object sender, EventArgs e)
        {
            cmbAssocTasks.DataSource = PBData.Tables["tblTasks"];
            cmbAssocTasks.DisplayMember = "colTask";
        }

        private void cmbAssocTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = PBData.Tables["Associations:" + cmbAssocTasks.Text];

            if (dataGrid.DataSource != null)
            {
                dataGrid.Columns["Count"].Visible = false;
                dataGrid.Columns["colAssoc"].HeaderText = lblAssocTask.Text;
            }
        }
    }
}