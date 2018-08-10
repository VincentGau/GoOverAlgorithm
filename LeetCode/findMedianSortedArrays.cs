using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 求两个有序数组的中位数，如果有两个中位数，求其均值；
    /// </summary>
    class FindMedianSortedArrays
    {
        // num1 和num2 不同时为空
        public static double find(int[] nums1, int[] nums2)
        {
            //if (num1.Length == 0)
            //    return getMedian(num2);
            //if(num2.Length == 0)
            //    return getMedian(num1);

            int[] result = new int[nums1.Length + nums2.Length];

            int i = 0, j = 0, k = 0;

            while(i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                    result[k++] = nums1[i++];
                else
                    result[k++] = nums2[j++];
            }

            while(i < nums1.Length)
            {
                result[k++] = nums1[i++];
            }
            while(j < nums2.Length){
                result[k++] = nums2[j++];
            }

            Console.WriteLine(getMedian(result));

            return getMedian(result);
        }

        public static double getMedian(int[] num)
        {
            int len = num.Length;
            if(len % 2 == 0)
            {
                double result = ((double)num[len / 2] + num[len / 2 - 1]) / 2;
                return result;
            }
            else
            {
                return num[len / 2];
            }
        }
    }
}
