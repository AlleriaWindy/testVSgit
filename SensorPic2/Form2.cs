using SensorPic2.Hardware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;

namespace SensorPic2
{
    public partial class Form2 : Form
    {
        public WindSensor1 ws1;
        bool _cancel = false;

        public Form2(ref WindSensor1 w)
        {
            InitializeComponent();
            ws1 = w;
        }

        int HexChar2Int(char c)
        {
            if (c >= '0' && c <= '9')
                return c - '0';
            else if (c >= 'A' && c <= 'F')
                return (c - 'A' + 10);
            else if (c >= 'a' && c <= 'f')
                return (c - 'a' + 10);
            else
                throw new Exception("输入不对！");
        }

        int Hexstr2Int(string s)
        {
            int sum = 0;
            sum += HexChar2Int(s[0]) * 16;
            sum += HexChar2Int(s[1]);

            return sum;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string [] strs = SerialPort.GetPortNames();
            foreach (var x in strs)
            {
                comboBox1.Items.Add(x);
            }
            if(comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            comboBox2.SelectedItem = "9600";
            if (ws1 != null)
            {
                textBox1.Text = ws1.Address.ToString("X");
                comboBox1.SelectedItem = ((object[])ws1.Tag)[0].ToString();
                comboBox2.SelectedItem = ((object[])ws1.Tag)[1].ToString();
            }
        }

        public new WindSensor1 ShowDialog()
        {
            base.ShowDialog();
            return ws1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int a = Hexstr2Int(textBox1.Text);
            if (ws1 != null)
                ws1.StopDevice();
            string com = comboBox1.SelectedItem.ToString();
            string bdr = comboBox2.SelectedItem.ToString();
            ws1 = new Hardware.WindSensor1(com, Convert.ToInt32(bdr));
            ws1.Address = (byte)Hexstr2Int(textBox1.Text);
            ws1.Tag = new object[] { com, bdr };
            if (sender == null && e == null)
                return;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ws1 == null)
            {
                MessageBox.Show("请至少初始化一次设备！");
                return;
            }
            ws1.StartDevice();
            ws1.ChangeBuadRate(Convert.ToInt32(comboBox2.SelectedItem.ToString()));
            button3_Click(null,null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ws1 == null)
            {
                MessageBox.Show("请至少初始化一次设备！");
                return;
            }
            ws1.StartDevice();
            ws1.ChangeAddres((byte)Hexstr2Int(textBox1.Text));
            button3_Click(null, null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ws1 == null)
            {
                MessageBox.Show("请至少初始化一次设备！");
                return;
            }
            ws1.StartDevice();
            ws1.ChangeSampleRate((byte)Hexstr2Int(textBox2.Text));
            //button3_Click(null, null);
        }
    }
}
