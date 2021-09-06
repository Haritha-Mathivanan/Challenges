using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double currentsum=0;
            for (int i = 1; i <= N;i++ )
            {
                String diceinputs = Console.ReadLine();
                double dicepoints = StringtoThreedigit(diceinputs);
                currentsum += dicepoints;
                double currentaverage = Runningaverage(currentsum,i);
                Display(dicepoints,currentaverage);
            }
        }
        public static double StringtoThreedigit(String diceinputs)
        {
            String[] dicepoint = diceinputs.Split();
            double sum=0;
            int pow = 2;
            for (int i = 0; i < dicepoint.Length;i++ )
            {
               int n = Convert.ToInt32(dicepoint[i]);
                sum += n * Math.Pow(10, pow);
                pow--;

            }
            return Math.Round(sum,0);

        }
        public static double Runningaverage(double runnningsum,int count)
        {
            return Math.Round((runnningsum / count),1);
        }
        public static void Display(double dicepoint,double runningavg)
        {
            //String x="";

            //   x+= (Math.Round(dicepoint,0)+" "+Math.Round(runningavg,1));
            //   return x;
            Console.WriteLine(Math.Round(dicepoint,0)+" "+Math.Round(runningavg,1));
        }
    }
}
