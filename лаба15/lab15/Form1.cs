using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab15
{
    public partial class Form1 : Form
    {
        Whether model_whether = new Whether();
        public Form1()
        {
            InitializeComponent();          
            model_whether.TeorWhether();
            label6.Text = "" + model_whether.ch_state[0] / 1000;
            label7.Text = "" + model_whether.ch_state[1] / 1000;
            label8.Text = "" + model_whether.ch_state[2] / 1000;
        }      
        private void timer1_Tick(object sender, EventArgs e)
        {
            model_whether.WhetherSim();
            label3.Text = "" + model_whether.state[model_whether.current_state];
            label1.Text = "" + Math.Round(model_whether.day,2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }

    public class Whether
    {
        public string[] state = new string[3] { "Пасмурно", "Ясно", "Облачно" };
        public double day = 0;
        public double[] ch_state = new double[3] {0, 0, 0};
        public int current_state = 0;

        double[,] IMatrix = new double[3, 3]
        {
            {-0.4, 0.3, 0.1 },
            {0.4, -0.8, 0.4 },
            {0.1, 0.4, -0.5 }
        };
        Random rnd = new Random();      
        public void WhetherSim()
        {
            
            double time = 0;
            double ch;
            ch = rnd.NextDouble();
            for (int i = 0; i < 3; i++)
            {
                if (i != current_state)
                    ch -= (IMatrix[current_state, i] / IMatrix[current_state, current_state]);

                if (ch >= 1)
                {
                    current_state = i;
                    time = rnd.NextDouble() / (-IMatrix[current_state, current_state]);
                    break;
                }
            }
            day += time;
        }
        public void TeorWhether()
        {
            
            double ch;
            for (int j = 0; j < 1000; j++)
            {
                ch = rnd.NextDouble();
                for (int i = 0; i < 3; i++)
                {
                    if (i != current_state)
                        ch -= (IMatrix[current_state, i] / IMatrix[current_state, current_state]);

                    if (ch >= 1)
                    {
                        current_state = i;
                        break;
                    }

                }
                if (current_state == 0)
                 ch_state[0]++; 
                else if (current_state == 1)
                 ch_state[1]++; 
                else if (current_state == 2)
                 ch_state[2]++; 
            }         
        }
    }

}
