using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton2
    {
        private Singleton2()
        {
            Console.WriteLine("constructor");
        }

        private static Singleton2 instance;

        private static object syncObj = new object();

        public static Singleton2 getInstance()
        {
            lock (syncObj)
            {
                Console.WriteLine("LOCK");
                if(instance == null)
                {
                    Console.WriteLine("null and create");
                    instance = new Singleton2();
                }
            }
            return instance;
        }

        public void doSomething(string s)
        {
            //Console.WriteLine($"doing {s}");
        }
    }
}
