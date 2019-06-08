using Jace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class MainForm : Form
    {
        Microsoft.Office.Interop.Excel.Application app;
        public MainForm()
        {
            InitializeComponent();
            mainChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            mainChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            mainChart.ChartAreas[0].AxisX.Title = "z";
            mainChart.ChartAreas[0].AxisY.Title = "a(t,z)";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.Now;

            mainChart.Series[0].Points.Clear();
            mainChart.Series[1].Points.Clear();

            zInt = 0;
            for (double z = 0; z < h; z += zStep)
            {
                mainChart.Series[0].Points.AddXY(z, nonNewtonian[tInt, zInt]);
                mainChart.Series[1].Points.AddXY(z, newtonian[tInt, zInt]);
                zInt++;
            }
            tInt = (tInt + 1) % tCount;

            TimeSpan elapsed = DateTime.Now - startTime;
        }

        double zStep;
        int tMax = 5;
        double h;
        double xi0;
        double nu;
        double kappa;
        double tStep;
        double t;
        int tInt;
        int zInt;

        Func<IDictionary<string, double>, double> u0;
        Dictionary<string, double> arg;

        static CalculationEngine engine = new CalculationEngine();

        int sumSteps;

        private void Init()
        {
            h = Convert.ToDouble(TbH.Text);
            xi0 = Convert.ToDouble(TbXi0.Text);
            nu = Convert.ToDouble(TbNu.Text);
            kappa = Convert.ToDouble(TbKappa.Text);
            string u0Str = TbU0.Text;
            sumSteps = Convert.ToInt32(TbSteps.Text);
            tStep = (double)Timer.Interval / 1000;
            zStep = h / mainChart.Width * 10;

            u0 = engine.Build(u0Str);
            arg = new Dictionary<string, double>();
            arg.Add("z", 0);
        }

        double[,] nonNewtonian;
        double[,] newtonian;

        int zCount;
        int tCount;

        private void BtCalculate_Click(object sender, EventArgs e)
        {
            Init();

            zCount = Convert.ToInt32(Math.Ceiling(h / zStep));
            tCount = Convert.ToInt32(Math.Ceiling(tMax / tStep));

            nonNewtonian = new double[tCount + 1, zCount + 1];
            newtonian = new double[tCount + 1, zCount + 1];

            tInt = 0;
            for (double t = 0; t < tMax; t += tStep)
            {
                zInt = 0;
                for (double z = 0; z < h; z += zStep)
                {
                    double nonNewtonianVal = FunctionUtils.a(z, t, xi0, nu, h, kappa, u0, arg, sumSteps);
                    double newtonianVal = FunctionUtils.a(z, t, xi0, nu, h, 0, u0, arg, sumSteps);
                    //mainChart.Series[0].Points.AddXY(z, nonNewtonianVal);
                    //mainChart.Series[1].Points.AddXY(z, newtonianVal);

                    nonNewtonian[tInt, zInt] = nonNewtonianVal;
                    newtonian[tInt, zInt] = newtonianVal;
                    zInt++;
                }
                tInt++;
            }

            this.mainChart.ChartAreas[0].AxisX.Minimum = 0;
            this.mainChart.ChartAreas[0].AxisX.Maximum = h;

            this.mainChart.ChartAreas[0].AxisY.Minimum = -h;
            this.mainChart.ChartAreas[0].AxisY.Maximum = h;

            BtSaveByT.Enabled = BtSaveByZ.Enabled = BtStop.Enabled = true;

            tInt = 0;
            zInt = 0;

            Timer.Enabled = true;
        }

        private void Double_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && (sender as TextBox).Text != "")
            {
                e.Handled = true;
            }
        }

        private void Int_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtStop_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            TbH.Text = TbKappa.Text = TbNu.Text = TbSteps.Text = TbU0.Text = TbXi0.Text = "";
        }

        private void BtSaveByT_Click(object sender, EventArgs e)
        {
            Init();

            SetTForm svf = new SetTForm();
            if(svf.ShowDialog() == DialogResult.OK)
            {
                double t = Convert.ToDouble(svf.T);
                double zmin = Convert.ToDouble(svf.ZMin);
                double zmax = Convert.ToDouble(svf.ZMax);
                double zstep = Convert.ToDouble(svf.ZStep);

                if (app == null)
                {
                    app = new Microsoft.Office.Interop.Excel.Application();
                }
                var wb = app.Workbooks.Add();

                var ws = wb.Worksheets.Add();
                ws.Name = "a(t, z)";

                ws.Cells[1, 1].Value = "z";
                ws.Cells[1, 2].Value = "a";
                ws.Cells[1, 3].Value = $"t={t}";

                int i = 0;
                for (double z = zmin; z < zmax; z += zstep)
                {
                    double val = FunctionUtils.a(z, t, xi0, nu, h, kappa, u0, arg, sumSteps);
                    ws.Cells[i + 2, 1] = z;
                    ws.Cells[i + 2, 2] = val;

                    ++i;
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                    FileName = $"Решение задачи"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(sfd.FileName);
                    if (file.Exists) file.Delete();

                    wb.SaveAs(sfd.FileName);
                    wb.Close();

                    Close();
                }
            }
        }

        private void BtSaveByZ_Click(object sender, EventArgs e)
        {
            Init();

            SetZForm svf = new SetZForm();
            if (svf.ShowDialog() == DialogResult.OK)
            {
                double z = Convert.ToDouble(svf.Z);
                double tmin = Convert.ToDouble(svf.TMin);
                double tmax = Convert.ToDouble(svf.TMax);
                double tstep = Convert.ToDouble(svf.TStep);

                if (app == null)
                {
                    app = new Microsoft.Office.Interop.Excel.Application();
                }
                var wb = app.Workbooks.Add();

                var ws = wb.Worksheets.Add();
                ws.Name = "a(t, z)";

                ws.Cells[1, 1].Value = "t";
                ws.Cells[1, 2].Value = "a";
                ws.Cells[1, 3].Value = $"z={z}";

                int i = 0;
                for (double t = tmin; z < tmax; z += tstep)
                {
                    double val = FunctionUtils.a(z, t, xi0, nu, h, kappa, u0, arg, sumSteps);
                    ws.Cells[i + 2, 1] = t;
                    ws.Cells[i + 2, 2] = val;

                    ++i;
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                    FileName = $"Решение задачи"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(sfd.FileName);
                    if (file.Exists) file.Delete();

                    wb.SaveAs(sfd.FileName);
                    wb.Close();

                    Close();
                }
            }
        }
    }
}
