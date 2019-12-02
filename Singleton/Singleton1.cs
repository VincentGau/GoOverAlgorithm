using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton1
    {
        private static Singleton1 instance;

        private Singleton1()
        {
            Console.WriteLine("constructor");
        }

        public static Singleton1 getInstance()
        {
            if(instance == null)
            {
                Console.WriteLine("null and create");
                instance = new Singleton1();
            }
            return instance;
        }

        public void doSomething(string s)
        {
            //Console.WriteLine($"doing something {s}");
        }
    }
}
