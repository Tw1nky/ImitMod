using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imit18
{
    class Program
    {
        static Random rnd = new Random();
        static int BusyWindowsCount = 0, ClientsInQue = 0, WindowsCount = 3, NumbOfMin, NumbOfExp, ClientsInBank = 0, ClientsTotal=0;
        static List<Agent> agents = new List<Agent>();
        static List<double> taus = new List<double>();
        static List<double> PosibilityTheo = new List<double>();
        static float La = 0.7f, Mu = 0.8f;
        static Dictionary<int, int> Freq = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            Console.Write("Число окон: ");
            WindowsCount = Int32.Parse(Console.ReadLine());
            Console.Write("Число агентов: ");
            int AgentsCount = Int32.Parse(Console.ReadLine());
            double min = 100;
            double Delta;
            
            for (int i = 0; i < AgentsCount; i++)
            {
                agents.Add(new Agent(La));
                taus.Add(agents[i].GetNextEvent());
                
                if (taus[i]<min)
                {
                    min = taus[i];
                    NumbOfMin = i;
                }
            }
            Console.Write("Число экспериментов: ");
            NumbOfExp = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < NumbOfExp; i++)
            {
                Delta = ExpRv(Mu * BusyWindowsCount);
                if (min < Delta)
                {
                    if (BusyWindowsCount < WindowsCount)
                    {
                        BusyWindowsCount++;
                    }
                    else
                    {
                        ClientsInQue++;
                    }
                    ClientsInBank++;
                    ClientsTotal++;
                }
                else
                {                   
                    if (ClientsInQue == 0)
                    {
                        BusyWindowsCount--;
                    }
                    else
                    {
                        ClientsInQue--;
                    }
                    ClientsInBank--;
                }
                FreqAdder(ClientsInBank,1);
                min = 100;
                taus[NumbOfMin] = agents[NumbOfMin].GetNextEvent();
                for (int j = 0; j < AgentsCount; j++)
                {
                    if (taus[j] < min)
                    {
                        min = taus[j];
                        NumbOfMin = j;
                    }
                }
                PosibilityTheo.Add(StatTheo());
                Console.WriteLine("Состояние Системы");
                Console.WriteLine("Занятые окна: " + BusyWindowsCount);
                Console.WriteLine("Агенты в очереди: " + ClientsInQue);
                Console.WriteLine("Предположительное состояние системы : " + PosibilityTheo[i]);               
                Console.WriteLine("----------------------------------");                             
            }
            foreach (var item in Freq)
            {
                Console.WriteLine("Реальное состояние системы: " + (double)item.Value / (double)ClientsTotal);
            }                      
            Console.ReadLine();
        }
        static double ExpRv(double x) => (double)(-Math.Log(rnd.NextDouble()) / x);       
        static double Factor(int x)
        {
            int Mul = 1;
            if (x==0)
            {
                return 1;
            }
            else
            {
                while (x>0)
                {
                    Mul *= x;
                    x--;
                }
                return Mul;
            }
        }
        static double StatTheo()
        {
            double PT;
            if (ClientsInBank < WindowsCount)
            {
                double sum = 0;
                for (int i = 0; i < WindowsCount; i++)
                {
                    sum += ((double)Math.Pow(La / Mu, ClientsInBank) / Factor(ClientsInBank));
                }
                sum += ((double)Math.Pow(La / Mu, WindowsCount + 1) / (Factor(WindowsCount) * (WindowsCount - (La / Mu))));
                PT = ((double)Math.Pow(La / Mu, ClientsInBank) / Factor(ClientsInBank)) * sum;
            }
            else
            {
                double sum = 0;
                for (int i = 0; i < WindowsCount; i++)
                {
                    sum += ((double)Math.Pow(La / Mu, ClientsInBank) / Factor(ClientsInBank));
                }
                PT = ((double)Math.Pow(La / Mu, ClientsInBank) / (Factor(WindowsCount) * (double)Math.Pow(WindowsCount, ClientsInBank - WindowsCount))) * sum;
            }
            return PT;
        }
        static void FreqAdder(int Key,int Value)
        {
            if (Freq.ContainsKey(Key))
            {
                Freq[Key]++;
            }
            else
            {
                Freq.Add(Key, Value);
            }
        }       
    }
    class Agent
    {
        float t0 = 0, La, Tau;
        Random rnd = new Random();
        public Agent(float La)
        {
            this.La = La;
        }
        public float GetNextEvent()
        {
            var ti = (float)(-Math.Log(rnd.NextDouble()) / La);
            Tau = ti - t0;
            t0 = ti;
            return Tau;

        }        
    }
}
