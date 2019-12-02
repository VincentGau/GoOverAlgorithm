using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton3
    {
        private Singleton3()
        {
            Console.WriteLine("constructor");
        }

        private static Singleton3 instance;

        private static object syncObj = new object();

        public static Singleton3 getInstance()
        {
            if(instance == null)
            {
                lock (syncObj)
                {
                    Console.WriteLine("LOCK");
                    if(instance == null)
                    {
                        Console.WriteLine("null and create");
                        instance = new Singleton3();
                    }
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
