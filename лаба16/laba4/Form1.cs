using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Collections.Specialized;
using System.Collections;

namespace laba4
{    
    public partial class Form1 : Form
    {
        
        double dt = 0.005f, Mu = 0.1d, Xi = 0.02d, W = 0, count;
        Random rnd;
        double c, i = 0;       
        double  _money = 200;
        double sum;
        public double getNum()
        {
            Random rnd = new Random();
            double a1, a2;
            a1 = rnd.NextDouble();
            a2 = rnd.NextDouble();
            sum = Math.Sqrt(-2 * Math.Log(a1)) * Math.Cos(2 * Math.PI * a2);
            return sum;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void inputPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        int _possessions = 0;
        public Form1()
        {
            InitializeComponent();           
            timer1.Interval = 1000;
            Money.Text = _money + "Р";
            rnd = new Random();            
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            chart1.Series[0].Points.Clear();           
            c = (float)inputPrice.Value;
            chart1.Series[0].Points.AddXY(0, c);
            count = c;                     
            timer1.Start();
            _possessions = 0;
            Possessions.Text = _possessions.ToString();
            _money = 200;
            Money.Text = _money + "Р";
        }
        private void Buy_Click(object sender, EventArgs e)
        {
            if (_money>= c)
            {
                noMoney.Visible = false;
                _money -= c;
                Money.Text = _money + "Р";
                _possessions ++;
                Possessions.Text = _possessions.ToString();
            }
            else
            {
                noMoney.Visible = true;
            }
        }
        private void Sell_Click(object sender, EventArgs e)
        {
            if (_possessions>0)
            {
                _money += c;
                _possessions--;
                Money.Text = _money.ToString();
                Possessions.Text = _possessions.ToString();
            }
            if (_money>= c)
                noMoney.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.Minimum = c - 2;
            i =0f;
            W += Math.Sqrt(dt) * getNum();
            count *= Math.Exp((Mu - Xi * Xi / 2) * dt + Xi * W);
            chart1.Series[0].Points.AddXY(i, count);
            c = (float)count;
            i+=dt;                    
        }
    }
    

}
