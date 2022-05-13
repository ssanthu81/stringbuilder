using System;
using System.Text;
using System.Diagnostics;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";

            Stopwatch sw1 = new Stopwatch();
            sw1.Start();



            for(int i = 1; i <= 100000; i++)
            {
                s = s + i;
           }

            sw1.Stop();

            Program s1 = new Program();
            for (int i = 1; i <= 100000; i++)
            {
                s1.Append(i);
            }
            sw1.Stop();
        }
    }
}