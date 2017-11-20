namespace SensorPic2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_degree = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_st = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.scale1 = new AGaugeApp.AGauge();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(125, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "北";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_degree);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.scale1);
            this.groupBox1.Location = new System.Drawing.Point(448, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 268);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "风向";
            // 
            // lbl_degree
            // 
            this.lbl_degree.AutoSize = true;
            this.lbl_degree.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_degree.ForeColor = System.Drawing.Color.Blue;
            this.lbl_degree.Location = new System.Drawing.Point(6, 26);
            this.lbl_degree.Name = "lbl_degree";
            this.lbl_degree.Size = new System.Drawing.Size(35, 16);
            this.lbl_degree.TabIndex = 15;
            this.lbl_degree.Text = "N/A";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Blue;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 61);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(430, 219);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "设置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(102, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "开始采集";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(192, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "停止采集";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(16, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "风速：";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_speed.ForeColor = System.Drawing.Color.Blue;
            this.lbl_speed.Location = new System.Drawing.Point(69, 296);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(35, 16);
            this.lbl_speed.TabIndex = 10;
            this.lbl_speed.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(165, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "声温：";
            // 
            // lbl_st
            // 
            this.lbl_st.AutoSize = true;
            this.lbl_st.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_st.ForeColor = System.Drawing.Color.Blue;
            this.lbl_st.Location = new System.Drawing.Point(230, 296);
            this.lbl_st.Name = "lbl_st";
            this.lbl_st.Size = new System.Drawing.Size(35, 16);
            this.lbl_st.TabIndex = 12;
            this.lbl_st.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(316, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "温度：";
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_temp.ForeColor = System.Drawing.Color.Blue;
            this.lbl_temp.Location = new System.Drawing.Point(381, 296);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(35, 16);
            this.lbl_temp.TabIndex = 14;
            this.lbl_temp.Text = "N/A";
            // 
            // scale1
            // 
            this.scale1.BaseArcColor = System.Drawing.Color.Gray;
            this.scale1.BaseArcRadius = 60;
            this.scale1.BaseArcStart = -90;
            this.scale1.BaseArcSweep = 360;
            this.scale1.BaseArcWidth = 2;
            this.scale1.Cap_Idx = ((byte)(1));
            this.scale1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.scale1.CapPosition = new System.Drawing.Point(10, 10);
            this.scale1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.scale1.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.scale1.CapText = "";
            this.scale1.Center = new System.Drawing.Point(120, 100);
            this.scale1.Font = new System.Drawing.Font("黑体", 10F);
            this.scale1.Location = new System.Drawing.Point(18, 48);
            this.scale1.MaxValue = 360F;
            this.scale1.MinValue = 0F;
            this.scale1.Name = "scale1";
            this.scale1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.scale1.NeedleColor2 = System.Drawing.Color.Silver;
            this.scale1.NeedleRadius = 55;
            this.scale1.NeedleType = 0;
            this.scale1.NeedleWidth = 7;
            this.scale1.Range_Idx = ((byte)(0));
            this.scale1.RangeColor = System.Drawing.Color.LightGreen;
            this.scale1.RangeEnabled = true;
            this.scale1.RangeEndValue = 360F;
            this.scale1.RangeInnerRadius = 60;
            this.scale1.RangeOuterRadius = 80;
            this.scale1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.scale1.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.scale1.RangesEndValue = new float[] {
        360F,
        100F,
        0F,
        0F,
        0F};
            this.scale1.RangesInnerRadius = new int[] {
        60,
        100,
        70,
        70,
        70};
            this.scale1.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.scale1.RangesStartValue = new float[] {
        0F,
        80F,
        0F,
        0F,
        0F};
            this.scale1.RangeStartValue = 0F;
            this.scale1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.scale1.ScaleLinesInterInnerRadius = 60;
            this.scale1.ScaleLinesInterOuterRadius = 75;
            this.scale1.ScaleLinesInterWidth = 1;
            this.scale1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.scale1.ScaleLinesMajorInnerRadius = 60;
            this.scale1.ScaleLinesMajorOuterRadius = 80;
            this.scale1.ScaleLinesMajorStepValue = 45F;
            this.scale1.ScaleLinesMajorWidth = 2;
            this.scale1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.scale1.ScaleLinesMinorInnerRadius = 60;
            this.scale1.ScaleLinesMinorNumOf = 9;
            this.scale1.ScaleLinesMinorOuterRadius = 70;
            this.scale1.ScaleLinesMinorWidth = 1;
            this.scale1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.scale1.ScaleNumbersFormat = null;
            this.scale1.ScaleNumbersRadius = 95;
            this.scale1.ScaleNumbersRotation = 0;
            this.scale1.ScaleNumbersStartScaleLine = 0;
            this.scale1.ScaleNumbersStepScaleLines = 1;
            this.scale1.Size = new System.Drawing.Size(237, 201);
            this.scale1.TabIndex = 0;
            this.scale1.Text = "aGauge1";
            this.scale1.Value = 0F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 328);
            this.Controls.Add(this.lbl_temp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_st);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "演示窗体";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AGaugeApp.AGauge scale1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_degree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_st;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_temp;
    }
}

