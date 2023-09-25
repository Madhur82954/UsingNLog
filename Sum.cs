using System;
using System.Collections.Generic;
using System.Text;

namespace UsingNLog
{
    internal class Sum
    {
        NLog n = new NLog();

        public void Add(int a,int b)
        {
            if(a==0 || b == 0)
            {
                Console.WriteLine("a and b values are zero");
                n.LogError("a and b values are zero");
            }
            else
            {
                int c = a + b;
                Console.WriteLine("c = " + c);
                n.LogInfo("Addition of" + a + " and " + b + " is = " + c);
            }
        }
    }
}
