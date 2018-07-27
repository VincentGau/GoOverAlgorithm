using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackBranchBound
{
    class Program
    {
        //分支限界法解决0-1背包问题：
        //    从活节点表中取出节点进行扩展

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int[] weight = { 1, 2, 5, 6, 7 };
            int[] value = { 1, 6, 18, 22, 28 };
            const int N = 5;
            const int maxWeight = 11;

            List<Node> l = new List<Node>();
            l.Add(new Node() { totalWeight = 0, totalValue = 0, path = new List<int>() });


            int level = 0;
            int optimalValue = 0;
            List<int> optimalPath = new List<int>();
            while(true)
            {
                Node n = l[0];
                level = n.path.Count;

                if(n.path.Count == N)
                {
                    if(n.totalValue > optimalValue)
                    {
                        optimalValue = n.totalValue;
                        optimalPath = n.path;
                    }
                }
                else
                {
                    List<int> newPath = new List<int>();
                    n.path.ForEach(item => newPath.Add(item));
                    newPath.Add(0);
                    l.Add(new Node() { totalWeight = n.totalWeight, totalValue = n.totalValue, path = newPath });

                    if (n.totalWeight + weight[level] <= maxWeight)
                    {
                        List<int> newPath2 = new List<int>();
                        n.path.ForEach(item => newPath2.Add(item));
                        newPath2.Add(1);
                        Node childNode2 = new Node() { totalWeight = n.totalWeight + weight[level], totalValue = n.totalValue + value[level], path = newPath2 };
                        l.Add(childNode2);
                    }
                }
                
                

                l.Remove(n);

                if (!l.Any())
                {
                    break;
                }
                
            }


            Console.WriteLine(optimalValue);
            foreach(var i in optimalPath)
            {
                Console.WriteLine("{0} - ", i);
            }

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        struct Node
        {
            public int totalWeight { get; set; }
            public int totalValue { get; set; }
            public List<int> path { get; set; }
        }
    }
}
