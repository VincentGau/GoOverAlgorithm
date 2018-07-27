using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    class Program
    {
        /*
         状态方程：
            m[i, W] 表示到第i 个元素为止，限制总重量为W 的情况下能做的最优解；
         状态转移方程：
                        0                                           if  i = 0 or W = 0              如果没有物品可选或者总重量不能超过0，那么结果为0
            m[i, W] =   m[i - 1, W]                                 if w[i] > W                     如果第i 个物品的重量超过了限制的总重量，则不能选择它，
                        Max(m[i-1, W], v[i] + m[i-1, W - w[i]])     if w[i] <= W                    如果第i 个物品的重量没有超过限制，则可以选择它或者不选它，择其优者：
                                                                                                        如果不选它，那么没有因为它消耗重量，对剩下i - 1个物品的在限制重量为W 的情况下求最优解
                                                                                                        如果选择它，这种选择的价值等于 该物品的价值 加上 对剩下i - 1 个物品求最优解，前提是要在W 的基础上减掉该物品的重量
             */

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int[] weight = { 0, 1, 2, 5, 6, 7 };
            int[] value = { 0, 1, 6, 18, 22, 28 };
            const int N = 5;
            const int maxWeight = 11;
            int[,] m = new int[N + 1, maxWeight + 1];

            for (int i = 0; i < N; i++)
                for (int j = 0; j < maxWeight; j++)
                    m[i, j] = 0;

            for (int i = 1; i <= N; i++)
            {
                // 状态转移方程
                for (int j = 1; j <= maxWeight; j++)
                {
                    // 当前物品的重量不超过总重量限制的时候
                    if (weight[i] <= j)
                    {
                        m[i, j] = Math.Max(value[i] + m[i - 1, j - weight[i]], m[i - 1, j]);
                    }
                    else
                    {
                        m[i, j] = m[i - 1, j];
                    }
                }
            }

            Console.WriteLine("Max value: {0}", m[N, maxWeight]);


            // 从右下角倒退，判断哪些物品被选择
            // 得到的二维表，右下角的值就是背包问题的解，背包能装下的最大价值
            // 从二维表中右下角出发，比较m[i, right] 和 m[i-1, right]，如果二者相等，表示第i 个物品没有被选择，如果m[i, right] 较大，表示第i 个物品被选择；
            int right = maxWeight;
            List<int> result = new List<int>();
            for (int i = N; i >= 1; i--)
            {
                if (m[i, right] > m[i - 1, right])
                {
                    result.Add(value[i]);
                    right -= weight[i];
                }
            }
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
