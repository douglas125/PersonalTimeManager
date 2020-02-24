using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectBuilderPessoal
{
    public partial class frmPieChart : Form
    {
        public frmPieChart()
        {
            InitializeComponent();
        }

        private void frmPieChart_FormClosing(object sender, FormClosingEventArgs e)
        {
            zedGraph.Dispose();
        }
    }
}