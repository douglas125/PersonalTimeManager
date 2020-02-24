using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalManager
{
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();
        }

        private void frmPieChart_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < itemsMenu.DropDownItems.Count; i++)
                itemsMenu.DropDownItems[i].Dispose();

            vals = null;
            itemsMenu.Dispose();
            zedGraph.Dispose();
            GC.Collect();
        }

        public List<double> vals = new List<double>();
        private void frmChart_Load(object sender, EventArgs e)
        {

        }

    }
}