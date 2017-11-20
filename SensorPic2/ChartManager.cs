using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SensorPic2
{
    class ChartManager
    {
        public Chart _Chart { get; set; }
        private Queue<KeyValuePair<DateTime,int>> _QQQ;

        public ChartManager(Chart c)
        {
            _Chart = c;
            _QQQ = new Queue<KeyValuePair<DateTime, int>>();
        }


        /// <summary>
        /// 初始化Chart
        /// </summary>
        public void Init_Chart()
        {
            //定义图表区域
            _Chart.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("C1");
            _Chart.ChartAreas.Add(chartArea1);

            //定义存储和显示点的容器
            this._Chart.Series.Clear();
            Series series1 = new Series("S1");
            series1.LegendText = "风速";
            series1.ChartArea = "C1";
            series1.Color = Color.Red;
            series1.XValueType = ChartValueType.DateTime;
            series1.MarkerSize = 6;
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.MarkerBorderColor = Color.Red;
            series1.IsValueShownAsLabel = true;
            series1.ChartType = SeriesChartType.Line;
            series1.Points.Clear();

            this._Chart.Series.Add(series1);

            //设置图表显示样式
            chartArea1.AxisX.Title = "时间（小时:分钟）";
            chartArea1.AxisX.Minimum = DateTime.Now.ToOADate();
            chartArea1.AxisX.Maximum = (DateTime.Now.AddDays(1)).Date.ToOADate();
            chartArea1.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea1.AxisX.Interval = 1;
            chartArea1.AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            
            chartArea1.AxisY.Title = "风速（cm/s）";
            chartArea1.AxisY.Minimum = 0;
            chartArea1.AxisY.Maximum = 7000;
            chartArea1.AxisY.Interval = 500;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;

            //chartArea1.BackColor = Color.Transparent;

            _Chart.Titles.Clear();
            _Chart.Titles.Add("S01");
            _Chart.Titles[0].Text = "风速记录";
            _Chart.Titles[0].ForeColor = Color.RoyalBlue;
            _Chart.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);

        }

        public void AppendPoint(int value)
        {
            _Chart.Series[0].Points.Clear();
            if (_QQQ.Count > 10)
                _QQQ.Dequeue();
            _QQQ.Enqueue(new KeyValuePair<DateTime, int>(DateTime.Now, value));

            var first = _QQQ.ElementAt(0);
            var last = _QQQ.ElementAt(_QQQ.Count-1);
            _Chart.ChartAreas[0].AxisX.Minimum = first.Key.ToOADate();
            _Chart.ChartAreas[0].AxisX.Maximum = last.Key.ToOADate();
            _Chart.ChartAreas[0].AxisX.Interval = ((last.Key - first.Key).Seconds)/_QQQ.Count;

            
            
            for (int i = 0; i < _QQQ.Count; i++)
            {
                var x = _QQQ.ElementAt(i);
                double nnn = x.Key.ToOADate();
                _Chart.Series[0].Points.AddXY(nnn,x.Value );
            }

        }
    }
}
