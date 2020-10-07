using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab17
{
    public partial class Form1 : Form
    {
        Model meth;
        public Form1()
        {
            InitializeComponent();
            meth = new Model();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            meth.Statistics();
            for(int i=0;i<1000;i++)
            {
                if(meth.Frequency[i] != 0) 
                    chart1.Series[0].Points.AddXY(i, meth.Frequency[i]);
                if (meth.Stats[i] != 0)
                    chart1.Series[1].Points.AddXY(i, meth.Stats[i]);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Model
    {
        public double lamb1 = 0.2, lamb2 = 0.1,sum, t1=0, t2=0, tsum=0, a;
        private int temp1=0, temp2=0, tempSum=0, T=1000, N=1000;
        public double[] Frequency=new double[1000];
        public double[] Stats=new double[1000];
        Random rnd = new Random();
        public void Statistics()
        {            
            
            for (int i=0;i<1000;i++)
            {
                Frequency[i] = 0;
                Stats[i] = 0;
            }
            for (int i = 0; i < N; i++)
            {
                Generator();
                Frequency[temp1 + temp2]++;
                Stats[tempSum]++;
            }
            for (int i = 0; i < 1000; i++)
            {
                Frequency[i]/= N;
                Stats[i]/= N;
            }
        }
        private void Generator()
        {
            sum = lamb1 + lamb2;
            temp1 = temp2 = tempSum = 0;
            t1 = t2 = tsum = 0;
            while (t1 < T || t2 < T || tsum < T)
            {
                a = rnd.NextDouble();
                if (t1 < T)
                {
                    t1 += (-Math.Log(a) / lamb1);
                    temp1++;
                }
                if (t2 < T)
                {
                    t2 += (-Math.Log(a) / lamb2);
                    temp2++;
                }
                if (tsum < T)
                {
                    tsum += (-Math.Log(a) / sum);
                    tempSum++;
                }
            }
        }
    }
}