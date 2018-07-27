using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutBar
{
    class Program
    {
        static void Main(string[] args)
        {
            // 切割钢条问题，数组下标为钢条长度，元素值为钢条价值，给定长度为n的钢条，求解如何切割价值最大；
            // 动态规划法
            int[] p = new int[] { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };
            Console.WriteLine(cut(p,10));
        }

        public static int cut(int[] p, int n)
        {
            int[] r = new int[p.Length + 1];
            r[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                int q = -1;
                for(int j = 1; j <= i; j++)
                {
                    int tmp = p[j] + r[i - j];
                    q = q > tmp ? q : tmp;
                }

                r[i] = q;
            }
            return r[n];
        }
    }
}
