using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 54, 26, 93, 17, 77, 31, 44, 55, 20 };
            quickSort(array, 0, 8);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 以第一个元素为pivot，设置两个游标，左边遇到小于等于pivot value的向右移动，否则停止；右边遇到大于等于pivot value的向左移动，否则停止；然后交换停下来的两个值；继续遍历；
        /// 最后右游标指向的地方即为此次pivot（右游标指向的值已经小于pivot value），将它和第一个元素交换，此时pivot 左边的值都不大于它，右边的值都不小于它；就地排序，不需要额外的存储空间；
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static int partition(int[] array, int start, int end)
        {
            int pivotValue = array[start];
            int left = start + 1;
            int right = end;
            while(left <= right)
            {
                while(array[left] <= pivotValue && left <= right)
                {
                    left++;
                }
                while(array[right] >= pivotValue && left <= right)
                {
                    right--;
                }
                if(left < right)
                {
                    swap(ref array[left], ref array[right]);
                }
            }
            swap(ref array[start], ref array[right]);
            return right;
        }

        public static void quickSort(int[] array, int start, int end)
        {
            if(start < end)
            {
                int pivot = partition(array, start, end);
                quickSort(array, start, pivot - 1);
                quickSort(array, pivot + 1, end);
            }
        }

        private static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
