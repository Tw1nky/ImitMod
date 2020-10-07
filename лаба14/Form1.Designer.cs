namespace IMLab11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_Generate = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Average1 = new System.Windows.Forms.TextBox();
            this.textBox_Varience1 = new System.Windows.Forms.TextBox();
            this.textBox_Chi_Squared1 = new System.Windows.Forms.TextBox();
            this.label_Error = new System.Windows.Forms.Label();
            this.textBox_Average_Error1 = new System.Windows.Forms.TextBox();
            this.textBox_Varience_Error1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Num = new System.Windows.Forms.TextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Varience_Error2 = new System.Windows.Forms.TextBox();
            this.textBox_Average_Error2 = new System.Windows.Forms.TextBox();
            this.textBox_Chi_Squared2 = new System.Windows.Forms.TextBox();
            this.textBox_Varience2 = new System.Windows.Forms.TextBox();
            this.textBox_Average2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_Varience_Error3 = new System.Windows.Forms.TextBox();
            this.textBox_Average_Error3 = new System.Windows.Forms.TextBox();
            this.textBox_Chi_Squared3 = new System.Windows.Forms.TextBox();
            this.textBox_Varience3 = new System.Windows.Forms.TextBox();
            this.textBox_Average3 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(11, 132);
            this.button_Generate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(77, 32);
            this.button_Generate.TabIndex = 0;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(190, 10);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(396, 271);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Variance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Average";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 345);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Chi-squared";
            // 
            // textBox_Average1
            // 
            this.textBox_Average1.Location = new System.Drawing.Point(295, 287);
            this.textBox_Average1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Average1.Name = "textBox_Average1";
            this.textBox_Average1.Size = new System.Drawing.Size(76, 20);
            this.textBox_Average1.TabIndex = 18;
            // 
            // textBox_Varience1
            // 
            this.textBox_Varience1.Location = new System.Drawing.Point(295, 312);
            this.textBox_Varience1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Varience1.Name = "textBox_Varience1";
            this.textBox_Varience1.Size = new System.Drawing.Size(76, 20);
            this.textBox_Varience1.TabIndex = 19;
            // 
            // textBox_Chi_Squared1
            // 
            this.textBox_Chi_Squared1.Location = new System.Drawing.Point(295, 341);
            this.textBox_Chi_Squared1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Chi_Squared1.Name = "textBox_Chi_Squared1";
            this.textBox_Chi_Squared1.Size = new System.Drawing.Size(137, 20);
            this.textBox_Chi_Squared1.TabIndex = 20;
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Location = new System.Drawing.Point(34, 379);
            this.label_Error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(10, 13);
            this.label_Error.TabIndex = 23;
            this.label_Error.Text = " ";
            // 
            // textBox_Average_Error1
            // 
            this.textBox_Average_Error1.Location = new System.Drawing.Point(430, 285);
            this.textBox_Average_Error1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Average_Error1.Name = "textBox_Average_Error1";
            this.textBox_Average_Error1.Size = new System.Drawing.Size(76, 20);
            this.textBox_Average_Error1.TabIndex = 24;
            // 
            // textBox_Varience_Error1
            // 
            this.textBox_Varience_Error1.Location = new System.Drawing.Point(430, 314);
            this.textBox_Varience_Error1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Varience_Error1.Name = "textBox_Varience_Error1";
            this.textBox_Varience_Error1.Size = new System.Drawing.Size(76, 20);
            this.textBox_Varience_Error1.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(386, 289);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Error";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(386, 316);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Error";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Number of exp.";
            // 
            // textBox_Num
            // 
            this.textBox_Num.Location = new System.Drawing.Point(92, 108);
            this.textBox_Num.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Num.Name = "textBox_Num";
            this.textBox_Num.Size = new System.Drawing.Size(76, 20);
            this.textBox_Num.TabIndex = 29;
            this.textBox_Num.Text = "1000";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(649, 10);
            this.chart2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(403, 271);
            this.chart2.TabIndex = 30;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(175, 398);
            this.chart3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(525, 291);
            this.chart3.TabIndex = 31;
            this.chart3.Text = "chart3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 398);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "3Gen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "2Gen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "1Gen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(861, 318);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Error";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(861, 292);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Error";
            // 
            // textBox_Varience_Error2
            // 
            this.textBox_Varience_Error2.Location = new System.Drawing.Point(906, 316);
            this.textBox_Varience_Error2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Varience_Error2.Name = "textBox_Varience_Error2";
            this.textBox_Varience_Error2.Size = new System.Drawing.Size(76, 20);
            this.textBox_Varience_Error2.TabIndex = 42;
            // 
            // textBox_Average_Error2
            // 
            this.textBox_Average_Error2.Location = new System.Drawing.Point(906, 288);
            this.textBox_Average_Error2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Average_Error2.Name = "textBox_Average_Error2";
            this.textBox_Average_Error2.Size = new System.Drawing.Size(76, 20);
            this.textBox_Average_Error2.TabIndex = 41;
            // 
            // textBox_Chi_Squared2
            // 
            this.textBox_Chi_Squared2.Location = new System.Drawing.Point(770, 344);
            this.textBox_Chi_Squared2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Chi_Squared2.Name = "textBox_Chi_Squared2";
            this.textBox_Chi_Squared2.Size = new System.Drawing.Size(137, 20);
            this.textBox_Chi_Squared2.TabIndex = 40;
            // 
            // textBox_Varience2
            // 
            this.textBox_Varience2.Location = new System.Drawing.Point(770, 314);
            this.textBox_Varience2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Varience2.Name = "textBox_Varience2";
            this.textBox_Varience2.Size = new System.Drawing.Size(76, 20);
            this.textBox_Varience2.TabIndex = 39;
            // 
            // textBox_Average2
            // 
            this.textBox_Average2.Location = new System.Drawing.Point(770, 289);
            this.textBox_Average2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Average2.Name = "textBox_Average2";
            this.textBox_Average2.Size = new System.Drawing.Size(76, 20);
            this.textBox_Average2.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(662, 348);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Chi-squared";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(662, 292);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Average";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(662, 318);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Variance";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(850, 637);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 54;
            this.label17.Text = "Error";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(850, 610);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 53;
            this.label18.Text = "Error";
            // 
            // textBox_Varience_Error3
            // 
            this.textBox_Varience_Error3.Location = new System.Drawing.Point(896, 635);
            this.textBox_Varience_Error3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Varience_Error3.Name = "textBox_Varience_Error3";
            this.textBox_Varience_Error3.Size = new System.Drawing.Size(76, 20);
            this.textBox_Varience_Error3.TabIndex = 52;
            // 
            // textBox_Average_Error3
            // 
            this.textBox_Average_Error3.Location = new System.Drawing.Point(896, 606);
            this.textBox_Average_Error3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Average_Error3.Name = "textBox_Average_Error3";
            this.textBox_Average_Error3.Size = new System.Drawing.Size(76, 20);
            this.textBox_Average_Error3.TabIndex = 51;
            // 
            // textBox_Chi_Squared3
            // 
            this.textBox_Chi_Squared3.Location = new System.Drawing.Point(760, 662);
            this.textBox_Chi_Squared3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Chi_Squared3.Name = "textBox_Chi_Squared3";
            this.textBox_Chi_Squared3.Size = new System.Drawing.Size(137, 20);
            this.textBox_Chi_Squared3.TabIndex = 50;
            // 
            // textBox_Varience3
            // 
            this.textBox_Varience3.Location = new System.Drawing.Point(760, 633);
            this.textBox_Varience3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Varience3.Name = "textBox_Varience3";
            this.textBox_Varience3.Size = new System.Drawing.Size(76, 20);
            this.textBox_Varience3.TabIndex = 49;
            // 
            // textBox_Average3
            // 
            this.textBox_Average3.Location = new System.Drawing.Point(760, 608);
            this.textBox_Average3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Average3.Name = "textBox_Average3";
            this.textBox_Average3.Size = new System.Drawing.Size(76, 20);
            this.textBox_Average3.TabIndex = 48;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(651, 666);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 47;
            this.label19.Text = "Chi-squared";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(651, 610);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 13);
            this.label20.TabIndex = 46;
            this.label20.Text = "Average";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(651, 637);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 45;
            this.label21.Text = "Variance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 653);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox_Varience_Error3);
            this.Controls.Add(this.textBox_Average_Error3);
            this.Controls.Add(this.textBox_Chi_Squared3);
            this.Controls.Add(this.textBox_Varience3);
            this.Controls.Add(this.textBox_Average3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_Varience_Error2);
            this.Controls.Add(this.textBox_Average_Error2);
            this.Controls.Add(this.textBox_Chi_Squared2);
            this.Controls.Add(this.textBox_Varience2);
            this.Controls.Add(this.textBox_Average2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.textBox_Num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_Varience_Error1);
            this.Controls.Add(this.textBox_Average_Error1);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.textBox_Chi_Squared1);
            this.Controls.Add(this.textBox_Varience1);
            this.Controls.Add(this.textBox_Average1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button_Generate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Average1;
        private System.Windows.Forms.TextBox textBox_Varience1;
        private System.Windows.Forms.TextBox textBox_Chi_Squared1;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.TextBox textBox_Average_Error1;
        private System.Windows.Forms.TextBox textBox_Varience_Error1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Num;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Varience_Error2;
        private System.Windows.Forms.TextBox textBox_Average_Error2;
        private System.Windows.Forms.TextBox textBox_Chi_Squared2;
        private System.Windows.Forms.TextBox textBox_Varience2;
        private System.Windows.Forms.TextBox textBox_Average2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_Varience_Error3;
        private System.Windows.Forms.TextBox textBox_Average_Error3;
        private System.Windows.Forms.TextBox textBox_Chi_Squared3;
        private System.Windows.Forms.TextBox textBox_Varience3;
        private System.Windows.Forms.TextBox textBox_Average3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

