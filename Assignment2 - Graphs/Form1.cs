using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2___Graphs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var objChart = chart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 12;
            
            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = -50;
            objChart.AxisY.Maximum = 50;

            chart.Series.Clear();

            Random random = new Random();
            foreach (Temprature t in tempratureBindingSource.DataSource as List<Temprature>)
            {
                chart.Series.Add(t.location);
                chart.Series[t.location].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                chart.Series[t.location].Legend = "Legend1";
                chart.Series[t.location].ChartArea = "ChartArea1";
                chart.Series[t.location].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 1; i <= 12; i++)
                    chart.Series[t.location].Points.AddXY(i, Convert.ToInt32(t[$"M{i}"]));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tempratureBindingSource.DataSource = new List<Temprature>();
        }
    }
}
