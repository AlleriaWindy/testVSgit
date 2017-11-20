using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SensorPic2
{
    public partial class Form1 : Form   //this is a form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ChartManager _cm;
        private void Form1_Load(object sender, EventArgs e)
        {
            _cm = new ChartManager(this.chart1);
            _cm.Init_Chart();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2(ref ws1);
            ws1 = fm.ShowDialog();
            //MessageBox.Show(obs[2].ToString());
            /*ws1 = new Hardware.WindSensor1("COM4", 9600);
            ws1.Address = 0x6A;*/
            if (ws1 != null)
            {
                ws1.WindStrReced += ws1_WindStrReced;
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            
        }

        Hardware.WindSensor1 ws1;
        Timer tm;
        private void button2_Click(object sender, EventArgs e)
        {
            ws1.StartDevice();
            tm = new Timer();
            tm.Interval = 500;
            tm.Enabled = true;
            tm.Tick += (a,b) =>
                {
                    ws1.SendDataRquest();
                };
            button2.Enabled = false;
            button3.Enabled = true;
            button1.Enabled = false;
        }

        int zb_tm = 0;
        void ws1_WindStrReced(object sender, int speed, double dgree, double st, double temp)
        {
            this.Invoke((MethodInvoker)(()=>
            {
                lbl_speed.Text = speed.ToString() + "cm/s";
                lbl_st.Text = st.ToString() + "℃";
                lbl_temp.Text = temp.ToString() + "℃";
                lbl_degree.Text = dgree.ToString() + "°";
                scale1.Value = Convert.ToInt16(dgree);
                if (zb_tm++ > 4)
                {
                    _cm.AppendPoint(speed);
                    zb_tm = 0;
                }
                
            }));
        }

        


        private void button3_Click(object sender, EventArgs e)
        {
            tm.Enabled = false;
            tm.Dispose();
            button1.Enabled = button2.Enabled = true;
            button3.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ws1 != null)
                ws1.StopDevice();
        }
    }
}
