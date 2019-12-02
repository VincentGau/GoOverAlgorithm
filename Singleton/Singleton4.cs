using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton4
    {
        private Singleton4()
        {
            Console.WriteLine("constructor");
        }

        private static Singleton4 instance = new Singleton4();

        public static Singleton4 getInstance()
        {
            return instance;
        }

        public void doSomething(string s)
        {
            //Console.WriteLine($"doing {s}");
        }
    }
}
