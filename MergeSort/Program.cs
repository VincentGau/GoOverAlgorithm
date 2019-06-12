using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a1 = { 1, 3, 5 };
            //int[] a2 = { 2, 4, 6 };
            //int[] a3 = merge(a1, a2);

            //int[] a = { 1, 3, 5, 2, 4, 6 };
            //merge(a, 0, 2, 5);
            //Console.WriteLine(a[0]);

            int[] a = { 1, 3, 5, 2, 4, 6 };
            mergeSort(a, 0, 5);
            Console.WriteLine(a[0]);
        }

        public static void mergeSort(int[] array, int first, int last)
        {
            if(first < last)
            {
                int mid = (last + first) / 2;
                mergeSort(array, first, mid);
                mergeSort(array, mid + 1, last);
                merge(array, first, mid, last);
            }
        }

        /// <summary>
        /// 当数组前半段和后半段都已排序，将整个数组合并成有序；
        /// </summary>
        /// <param name="array"></param>
        /// <param name="first"></param>
        /// <param name="mid"></param>
        /// <param name="last"></param>
        public static void merge(int[] array, int first, int mid, int last)
        {
            int p = first;
            int q = mid + 1;
            int[] tmp = new int[last - first + 1];
            int k = 0;
            while(p <= mid && q <= last)
            {
                if (array[p] < array[q])
                    tmp[k++] = array[p++];
                else
                    tmp[k++] = array[q++];

            }

            while (p <= mid)
                tmp[k++] = array[p++];
            while (q <= last)
                tmp[k++] = array[q++];

            int index = 0;
            for(int i = first; i < last; i++)
            {
                array[i] = tmp[index++];
            }
        }


        /// <summary>
        /// 将两个有序数组合并成一个；
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public static int[] merge(int[] array1, int[] array2)
        {
            if (array1.Length == 0)
                return array2;
            if (array2.Length == 0)
                return array1;
            int p = 0;
            int q = 0;
            int k = 0;
            int[] result = new int[array1.Length + array2.Length];
            while(p < array1.Length && q < array2.Length)
            {
                if (array1[p] < array2[q])
                {
                    result[k++] = array1[p++];
                }
                else
                    result[k++] = array2[q++];
            }
            while (p < array1.Length)
                result[k++] = array1[p++];
            while (q < array2.Length)
                result[k++] = array2[q++];

            return result;
        }
    }
}
