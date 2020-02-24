using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalManager
{
    public partial class frmViewTimes : Form
    {
        public DataSet PBData;

        public frmViewTimes()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.LCID);

            InitializeComponent();
        }

        private DataTable GetDateTbl()
        {
            string tblName = dTP.Value.Year.ToString() + "-" + dTP.Value.Month.ToString() + "-" + dTP.Value.Day.ToString();
            tblName = "TimeSpent:" + tblName;
            if (PBData.Tables.IndexOf(tblName) >= 0) return PBData.Tables[tblName];
            else return null;
        }

        private void btnDaySummary_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            DataTable t = GetDateTbl();
            if (t != null)
            {
                if (frmPie != null && !frmPie.IsDisposed)
                    frmPie.Dispose();

                frmPie = new frmChart();

                ZedGraph.GraphPane Pane = frmPie.zedGraph.GraphPane;

                //Titulos
                frmPie.Text = lblTimeSpent.Text + ": " + lblDay.Text + " " + dTP.Value.Date.ToString().Split()[0];
                Pane.Title.Text = frmPie.Text;
                Pane.Title.FontSpec.Size = 24f;
                //Pane.Title.FontSpec.IsItalic = true;

                Pane.Fill = new ZedGraph.Fill(Color.White, Color.LightYellow, 45f);
                Pane.Chart.Fill.Type = ZedGraph.FillType.None;

                //fonte da legenda
                Pane.Legend.FontSpec.Size = 11f;

                //Slices
                int tempoTot = 0;
                foreach (DataRow r in t.Rows)
                {
                    int tempo=(int)r["colElapTimeInSeconds"];
                    tempoTot += tempo;
                    Color cor=Color.FromArgb(rnd.Next(240),rnd.Next(240),rnd.Next(240));
                    ZedGraph.PieItem p = Pane.AddPieSlice(Math.Round((double)tempo/3600,2), cor, Color.White, 45f, 0.1, r["colTask"].ToString());

                    //Menu pie slices removal feature
                    ToolStripMenuItem m = new ToolStripMenuItem(r["colTask"].ToString());
                    m.Checked = true;
                    frmPie.itemsMenu.DropDownItems.Add(m);
                    m.Click += new EventHandler(m_Click);
                    frmPie.vals.Add((double)tempo / 3600);
                }

                //Sets menu text
                frmPie.itemsMenu.Text = lblTask.Text;


                TimeSpan tsp=new TimeSpan(0,0,tempoTot);

                //Total label
                txt = new ZedGraph.TextObj(lblTotTime.Text + "\n" + Math.Round(tsp.TotalHours,2).ToString() + " h", 0.88f, 0.3f, ZedGraph.CoordType.PaneFraction);
                Pane.GraphObjList.Add(txt);
                txt.FontSpec.Fill = new ZedGraph.Fill(Color.White, Color.Yellow, 45f);
                //shadow
                ZedGraph.TextObj txt2 = new ZedGraph.TextObj(txt);
                txt2.FontSpec.Fill = new ZedGraph.Fill(Color.Black);
                txt2.Location.X += 0.006f;
                txt2.Location.Y += 0.008f;
                Pane.GraphObjList.Add(txt2);

                frmPie.zedGraph.AxisChange();

                frmPie.Show();
            }
        }

        frmChart frmPie;
        private void btnMonthSummary_Click(object sender, EventArgs e)
        {
            string mes = dTP.Value.Month.ToString();

            List<string> _tasks = new List<string>();
            List<double> _times = new List<double>();

            foreach (DataTable tbl in PBData.Tables)
            {
                //checks if month is in selected day
                string[] s = tbl.TableName.Split(':');
                if (s.Length > 1) s = s[1].Split('-');
                if (s.Length > 1 && s[1]==mes)
                {
                    //adds each task
                    foreach (DataRow r in tbl.Rows)
                    {
                        //position
                        int i = _tasks.IndexOf(r["colTask"].ToString());
                        if (i < 0)
                        {
                            i = _tasks.Count;
                            _tasks.Add(r["colTask"].ToString());
                            _times.Add(0);
                        }

                        //time count
                        _times[i] += (double)((int)r["colElapTimeInSeconds"]);
                    }
                }
            }

            Random rnd = new Random();
            //zedGraph Pie Chart

            DataTable t = GetDateTbl();
            if (frmPie != null && !frmPie.IsDisposed)
                frmPie.Dispose();

            frmPie = new frmChart();

            ZedGraph.GraphPane Pane = frmPie.zedGraph.GraphPane;

            //Titulos
            frmPie.Text = lblTimeSpent.Text + ": " + lblMonth.Text + " " +
                System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[dTP.Value.Month - 1] + "/" + dTP.Value.Year.ToString();
            
            Pane.Title.Text = frmPie.Text;
            Pane.Title.FontSpec.Size = 24f;
            //Pane.Title.FontSpec.IsItalic = true;

            Pane.Fill = new ZedGraph.Fill(Color.White, Color.LightYellow, 45f);
            Pane.Chart.Fill.Type = ZedGraph.FillType.None;

            //fonte da legenda
            Pane.Legend.FontSpec.Size = 11f;

            //Slices
            TimeSpan tspTot = new TimeSpan(0,0,0);
            for (int j=0;j<_tasks.Count;j++)
            {
                TimeSpan tsp = new TimeSpan(0, 0, (int)_times[j]);
                tspTot+=tsp;

                Color cor = Color.FromArgb(rnd.Next(240), rnd.Next(240), rnd.Next(240));
                ZedGraph.PieItem p = Pane.AddPieSlice(Math.Round(_times[j]/3600,2), cor, Color.White, 45f, 0.1, _tasks[j]);

                //Menu pie slices removal feature
                ToolStripMenuItem m = new ToolStripMenuItem(_tasks[j]);
                m.Checked = true;
                frmPie.itemsMenu.DropDownItems.Add(m);
                m.Click += new EventHandler(m_Click);
                frmPie.vals.Add(_times[j] / 3600);
            }
            //Sets menu text
            frmPie.itemsMenu.Text = lblTask.Text;

            //Total label
            txt = new ZedGraph.TextObj(lblTotTime.Text + "\n" + Math.Round(tspTot.TotalHours,1).ToString() + " h", 0.9f, 0.17f, ZedGraph.CoordType.PaneFraction);
            Pane.GraphObjList.Add(txt);
            txt.FontSpec.Fill = new ZedGraph.Fill(Color.White, Color.Yellow, 45f);
            //shadow
            ZedGraph.TextObj txt2 = new ZedGraph.TextObj(txt);
            txt2.FontSpec.Fill = new ZedGraph.Fill(Color.Black);
            txt2.Location.X += 0.006f;
            txt2.Location.Y += 0.008f;
            Pane.GraphObjList.Add(txt2);

            frmPie.zedGraph.AxisChange();

            frmPie.Show();
        }

        ZedGraph.TextObj txt;
        void m_Click(object sender, EventArgs e)
        {
            //try
            {
                ToolStripMenuItem m = (ToolStripMenuItem)sender;
                m.Checked = false;

                int i = frmPie.itemsMenu.DropDownItems.IndexOf(m);
                frmPie.itemsMenu.DropDownItems.Remove(m);
                frmPie.vals.RemoveAt(i);

                double total = 0;
                for (int j = 0; j < frmPie.vals.Count; j++) total += frmPie.vals[j];

                txt.Text = lblTotTime.Text + "\n" + Math.Round(total, 1).ToString() + " h";

                frmPie.zedGraph.GraphPane.CurveList.RemoveAt(i);
                frmPie.zedGraph.AxisChange();
                frmPie.zedGraph.Refresh();
            }
            //catch { }
        }



        private void dTP_ValueChanged(object sender, EventArgs e)
        {
            DataTable t = GetDateTbl();
            dataGridLog.DataSource = t;
            if (t != null)
            {
                dataGridLog.Columns["Count"].Visible = false;
                dataGridLog.Columns["colElapTimeInSeconds"].HeaderText = lblElapTimeSec.Text;
                dataGridLog.Columns["colElapTimeInSeconds"].Visible = false;

                dataGridLog.Columns["colElapTime"].HeaderText = lblElaptime.Text;
                dataGridLog.Columns["colElapTime"].ReadOnly = true;

                dataGridLog.Columns["colTask"].HeaderText = lblTask.Text;
                dataGridLog.Columns["colTask"].ReadOnly = true;

                dataGridLog.Columns["colRemarks"].HeaderText = lblRemarks.Text;
                dataGridLog.Columns["colRemarks"].Width = 300;
            }
        }

        private void frmViewTimes_Load(object sender, EventArgs e)
        {
            dTP_ValueChanged(sender, e);
        }

        private void btnMonthEffort_Click(object sender, EventArgs e)
        {
            string mes = dTP.Value.Month.ToString();

            List<string> _tasks = new List<string>();
            List<double> _times = new List<double>();

            foreach (DataTable tbl in PBData.Tables)
            {
                //checks if month is in selected day
                string[] s = tbl.TableName.Split(':');
                if (s.Length > 1) s = s[1].Split('-');
                if (s.Length > 1 && s[1] == mes)
                {
                    //adds each task
                    foreach (DataRow r in tbl.Rows)
                    {
                        //position
                        int i = _tasks.IndexOf(r["colTask"].ToString());
                        if (i < 0)
                        {
                            i = _tasks.Count;
                            _tasks.Add(r["colTask"].ToString());
                            _times.Add(0);
                        }
                        
                        //time count
                        _times[i] += (double)((int)r["colElapTimeInSeconds"]);
                    }
                }
            }

            Random rnd = new Random();
            //zedGraph Pie Chart

            DataTable t = GetDateTbl();
            frmChart frmBar = new frmChart();
            frmBar.itemsMenu.Visible = false;

            ZedGraph.GraphPane Pane = frmBar.zedGraph.GraphPane;

            //Titulos
            frmBar.Text = btnMonthEffort.Text + ": " + lblMonth.Text + " " +
                System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[dTP.Value.Month - 1] + "/" + dTP.Value.Year.ToString();

            Pane.Title.Text = frmBar.Text;
            Pane.Title.FontSpec.Size = 24f;
            //Pane.Title.FontSpec.IsItalic = true;

            Pane.Fill = new ZedGraph.Fill(Color.White, Color.LightYellow, 45f);
            Pane.Chart.Fill.Type = ZedGraph.FillType.None;

            //fonte da legenda
            Pane.Legend.FontSpec.Size = 11f;

            Pane.BarSettings.Base = ZedGraph.BarBase.Y;

            //Bars
            double[] yy = new double[_tasks.Count];
            double[] xx = new double[_tasks.Count];
            for (int j = 0; j < _tasks.Count; j++)
            {
                yy[j] = (double)(j + 1);
                xx[j] = Math.Round(_times[j] / 3600, 2);
            }

            Color cor = Color.FromArgb(rnd.Next(240), rnd.Next(240), rnd.Next(240));
            ZedGraph.BarItem p = Pane.AddBar("", xx, yy, Color.White);
            p.Bar.Fill = new ZedGraph.Fill(cor, Color.White, cor);

            Pane.YAxis.Scale.TextLabels = _tasks.ToArray();
            Pane.YAxis.Type = ZedGraph.AxisType.Text;
            Pane.YAxis.MajorTic.IsBetweenLabels = true;
            
            Pane.XAxis.Title.Text = lblTotalTH.Text;
            Pane.YAxis.Title.Text = lblTask.Text;

            frmBar.zedGraph.AxisChange();

            frmBar.Show();
        }


        //public void addMaxMin(string[] nomes, double[] maxs, double[] mins)
        //{
        //    //graf.GraphPane.BarSettings.Type = BarType.SortedOverlay;
        //    graf.GraphPane.BarSettings.Base = BarBase.Y;

        //    //Cores
        //    int R = rNum.Next(1, 255);
        //    int G = rNum.Next(1, 255);
        //    int B = rNum.Next(1, 255);
        //    System.Drawing.Color cor = Color.FromArgb(R, G, B);

        //    BarItem NovaBar = graf.GraphPane.AddBar("Maximum values", maxs, null, cor);
        //    NovaBar.Bar.Fill = new Fill(cor, Color.White, cor);

        //    R = rNum.Next(1, 255);
        //    G = rNum.Next(1, 255);
        //    B = rNum.Next(1, 255);
        //    cor = Color.FromArgb(R, G, B);

        //    BarItem NovaBar2 = graf.GraphPane.AddBar("Minimum values", mins, null, cor);
        //    NovaBar2.Bar.Fill = new Fill(cor, Color.White, cor);

        //    graf.GraphPane.YAxis.Scale.TextLabels = nomes;
        //    graf.GraphPane.YAxis.Type = AxisType.Text;
        //    graf.GraphPane.YAxis.MajorTic.IsBetweenLabels = true;

        //    graf.AxisChange();
        //}

    }
}