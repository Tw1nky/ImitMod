using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IMLab11//14 лабораторная
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Generate_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox_Num.Text);
            Double Average = 0.5;//мат ожидание
            Double Varience = 1 / 12;//дисперсия
            Double[] mas = new Double[12];//для 1 генератора
            Double[] eps = new Double[num];//массив величин для 1 генератора
            Double[] eps2 = new Double[num];//массив величин для 2 генератора
            Double[] eps3 = new Double[num];//массив величин для 3 генератора
            chart1.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].Points.Clear();
            chart3.Series["Series1"].Points.Clear();
            chart1.ChartAreas["ChartArea1"].AxisX.CustomLabels.Clear();
            chart2.ChartAreas["ChartArea1"].AxisX.CustomLabels.Clear();
            chart3.ChartAreas["ChartArea1"].AxisX.CustomLabels.Clear();
            Double min1 = 1000000;
            Double max1 = -1000000;
            Double min2 = 1000000;
            Double max2 = -1000000;
            Double min3 = 1000000;
            Double max3 = -1000000;
            Double[] masChiSq = new Double[10] { 3.841, 5.991, 7.815, 9.488, 11.070, 12.592, 14.067, 15.507, 16.919, 18.307};
            
            //Функции
            Double[] FirstGen(Double N, Double[] mas12, Double[] Eps, bool flag )//заполняем массив величин для 1 генератора
            {
                for (int j = 0; j < N; j++) 
                {
                    Double sumMas = 0;
                    for (int i = 0; i < 12; i++)
                    {
                        mas12[i] = rnd.NextDouble();
                        sumMas += mas12[i];
                    }
                    Eps[j] = sumMas - 6;//заполнили величинами
                    if (flag)//находими мин и макс для 1 генератора, для 2 генератора не заходим
                    {
                        if (Eps[j] < min1)
                        {
                            min1 = Eps[j];
                        }
                        if (Eps[j] > max1)
                        {
                            max1 = Eps[j];
                        }
                    }
                }
                return Eps;
            }

            Double[] SecondGen(Double N, Double[] Eps, Double[] Eps2)//заполняем массив величин для 2 генератора
            {           
                for (int i = 0; i < N; i++)
                { 
                    Double a1240 = 0.00416;
                    Double EPSx3 = Eps[i] * Eps[i] * Eps[i];
                    Double EPS3 = 3 * Eps[i];
                    Eps2[i] = Eps[i] + a1240 * (EPSx3 - EPS3);
                    if (Eps2[i] < min2)
                    {
                        min2 = Eps[i];
                    }
                    if (Eps2[i] > max2)
                    {
                        max2 = Eps[i];
                    }
                }
                return Eps2;
            }

            Double[] ThirdGen(Double N, Double[] Eps3)//заполняем массив величин для 3 генератора
            {
                for (int i = 0; i < N / 2; i++)
                {
                    Double a1 = rnd.NextDouble();
                    Double a2 = rnd.NextDouble();
                    Double UnitedPart = Math.Sqrt((-2) * Math.Log(a1));
                    Eps3[i] = UnitedPart * Math.Cos(2 * Math.PI * a2);
                    if (Eps3[i] < min3)
                    {
                        min3 = Eps3[i];
                    }
                    if (Eps3[i] > max3)
                    {
                        max3 = Eps3[i];
                    }
                    Eps3[num - i - 1] = UnitedPart * Math.Sin(2 * Math.PI * a2);
                    if (Eps3[i] < min3)
                    {
                        min3 = Eps3[i];
                    }
                    if (Eps3[i] > max3)
                    {
                        max3 = Eps3[i];
                    }
                }
                return Eps3;
            }

            Double[] Intervals (Double min, Double max)//разбиваем на интервалы
            {
                min = Math.Floor(min);
                max = Math.Ceiling(max);
                Double CountIntervals = Math.Round(max - min);
                Double[] intervals = new Double[(int)CountIntervals];
                for ( int i = 0; i < CountIntervals; i++)
                {
                    intervals[i] = min;
                    min += 1;
                }
                return intervals;
            }

            Double[] NumberInIntervals(Double[] IntervalsMas, Double[] Eps)//заполняем массив частот попадания в интервал
            {
                Double[] Frequensy = new Double[IntervalsMas.Length];
                for (int i = 0; i < Frequensy.Length; i++)
                {
                    Frequensy[i] = 0;
                }
                for ( int i = 0; i < num; i++)
                {
                    Double C = Math.Floor(Eps[i]);
                    for ( int j = 0; j < IntervalsMas.Length; j++)
                    {
                        if ( C == IntervalsMas[j])
                        {
                            Frequensy[j]++;//количество попаданий в каждый интервал
                        }
                    }
                }
                for ( int i = 0; i < Frequensy.Length; i++)
                {
                    Frequensy[i] = Frequensy[i] / (double)num;//частота попадания в каждый интервал
                }
                return Frequensy;
            }
            //Закончились функции


            //ДЛЯ первого генератора
            var stopwatch1 = new Stopwatch();
            stopwatch1.Reset();            
            stopwatch1.Start();
            eps = FirstGen(num, mas, eps, true);
            Double[] Intervals1 = Intervals(min1, max1);//интервалы
            Double[] Freq1 = NumberInIntervals(Intervals1, eps);// во Freq1,2,3 будут храниться частоты попадания в интервал
            stopwatch1.Stop();
            Console.WriteLine(stopwatch1.ElapsedMilliseconds);
            //Гистограмма
            for (int i = 0; i < Freq1.Length; i++)
            {
                chart1.ChartAreas["ChartArea1"].AxisX.CustomLabels.Add(i, i + 1, (Intervals1[i]).ToString());
                chart1.Series["Series1"].Points.AddY(Freq1[i]);
            }
            //Мат ожидание
            Double mat1 = Mat(eps);
            textBox_Average1.Text = mat1.ToString();
            textBox_Average_Error1.Text = (Math.Round((Math.Abs(Average - mat1) / Average) * 100)).ToString() + " %";
            //Дисперсия
            Double disp1 = Disp(Freq1, mat1);
            textBox_Varience1.Text = disp1.ToString();
            double mistDi1 = Math.Abs(((Varience - disp1) / Varience) * 100);
            textBox_Varience_Error1.Text = (Math.Round(mistDi1)).ToString() + " %";
            //Хи квадрат
            Double chi1 = Chi(Freq1,eps , Intervals1);
            bool k1 = false;
            if (chi1 < masChiSq[Intervals1.Length-1])
                k1 = true;
            textBox_Chi_Squared1.Text = Math.Round(chi1, 4).ToString() + " < "+ masChiSq[Intervals1.Length - 1] + " " + k1;


            //ДЛЯ второго генератора
            stopwatch1.Reset();
            stopwatch1.Start();
            eps2 = FirstGen(num, mas, eps2, false);
            eps2 = SecondGen(num, eps, eps2);
            Double[] Intervals2 = Intervals(min2, max2);
            Double[] Freq2 = NumberInIntervals(Intervals2, eps2);
            stopwatch1.Stop();
            Console.WriteLine(stopwatch1.ElapsedMilliseconds);
            //Гистограмма
            for (int i = 0; i < Freq2.Length; i++)
            {
                chart2.ChartAreas["ChartArea1"].AxisX.CustomLabels.Add(i, i + 1, (Intervals2[i]).ToString());
                chart2.Series["Series1"].Points.AddY(Freq2[i]);
            }
            //Мат ожидание
            Double mat2 = Mat(eps2);
            textBox_Average2.Text = mat2.ToString();
            textBox_Average_Error2.Text = (Math.Round((Math.Abs(Average - mat2) / Average) * 100)).ToString() + " %";
            //Дисперсия
            Double disp2 = Disp(Freq2, mat2);
            textBox_Varience2.Text = disp2.ToString();
            double mistDi2 = Math.Abs(((Varience - disp2) / Varience) * 100);
            textBox_Varience_Error2.Text = (Math.Round(mistDi2)).ToString() + " %";
            //Хи квадрат
            Double chi2 = Chi(Freq2, eps2, Intervals2);
            bool k2 = false;
            if (chi2 < masChiSq[Intervals1.Length - 1])
                k2 = true;
            textBox_Chi_Squared2.Text = Math.Round(chi2, 4).ToString() + " < " + masChiSq[Intervals2.Length - 1] + " " + k2;


            //ДЛЯ третьего генератора
            stopwatch1.Reset();
            stopwatch1.Start();
            eps3 = ThirdGen(num, eps3);
            Double[] Intervals3 = Intervals(min3, max3);
            Double[] Freq3 = NumberInIntervals(Intervals3, eps3);
            stopwatch1.Stop();
            Console.WriteLine(stopwatch1.ElapsedMilliseconds);
            //Гистограмма
            for (int i = 0; i < Freq3.Length; i++)
            {
                chart3.ChartAreas["ChartArea1"].AxisX.CustomLabels.Add(i, i + 1, (Intervals3[i]).ToString());
                chart3.Series["Series1"].Points.AddY(Freq3[i]);
            }
            //Мат ожидание
            Double mat3 = Mat(eps3);
            textBox_Average3.Text = mat3.ToString();
            textBox_Average_Error3.Text = (Math.Round((Math.Abs(Average - mat3) / Average) * 100)).ToString() + " %";
            //Дисперсия
            Double disp3 = Disp(Freq3, mat3);
            textBox_Varience3.Text = disp3.ToString();
            double mistDi3 = Math.Abs(((Varience - disp3) / Varience) * 100);
            textBox_Varience_Error3.Text = (Math.Round(mistDi3)).ToString() + " %";
            //Хи квадрат
            Double chi3 = Chi(Freq3,eps3, Intervals3);
            bool k3 = false;
            if (chi3 < masChiSq[Intervals1.Length - 1])
                k3 = true;
            textBox_Chi_Squared3.Text = Math.Round(chi3, 4).ToString() + " < " + masChiSq[Intervals3.Length - 1] + " " + k3;


            //Функции мат ожидания дисперсии и хи квадрат
            Double Mat (Double[] Eps)//Мат ожидание
            {
                Double mat = 0;
                for (int i = 0; i < Eps.Length; i++)
                {
                    mat += Eps[i];
                }
                mat /= num;
                return mat;
            }

            Double Disp(Double[] Eps, Double MatThis)//Дисперсия
            {
                Double disp = 0;
                for (int i = 0; i < Eps.Length; i++)
                {
                    disp += Math.Pow(Eps[i],2);
                }
                disp /= num;
                disp -=  Math.Pow(MatThis,2);
                return disp;
            }

            Double Chi(Double[] Frequency,  Double[] Eps, Double[] Inter)//Хи квадрат
            {
                Double chi = 0;
                for (int i = 0; i < Frequency.Length; i++)
                {
                    chi += ((Frequency[i] * num * Frequency[i] * num) / (num * ( 1/(Math.Sqrt(2*Math.PI)) * Math.Pow(Math.E,(-1*(Math.Pow((Inter[i]+0.5),2)/2) )))));
                }
                chi -= num;
                return chi;
            }
        }
    }
}
