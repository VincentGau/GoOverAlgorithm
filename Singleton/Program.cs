using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Parallel.For(0, 1000, i => Singleton4.getInstance().doSomething(i.ToString()));
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
