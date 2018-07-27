using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxHeap
{
    class Program
    {
        // http://bubkoo.com/2014/01/14/sort-algorithm/heap-sort/

        static void Main(string[] args)
        {
            int[] array = { 3, 5, 1, 7, 4, 2 };
            int[] top = new int[4];
            topK(array, 4, top);

            //heapSort(array);
            //foreach(var i in array)
            //{
            //    Console.WriteLine(i);
            //}
        }

        private static void heapSort(int[] array)
        {
            buildMaxHeap(array);
            for(int i = array.Length - 1; i > 0; i--)
            {
                swap(ref array[0], ref array[i]);
                heapifyMax(array, 0, i);
            }
        }

        // 找到最大的K个元素
        private static void topK(int[] array, int K, int[] kMax)
        {
            for(int i = 0; i < K; i++)
            {
                kMax[i] = array[i];
            }
            buildMinHeap(kMax);
            for (int j = K; j < array.Length; j++)
            {
                if(array[j] > kMax[0])
                {
                    swap(ref kMax[0], ref array[j]);
                    heapifyMin(kMax, 0, K);
                }
            }

            foreach(var i in kMax)
            {
                Console.WriteLine(i);
            }
        }

        private static void buildMinHeap(int[] array)
        {
            // 从最后一个节点的父节点开始，向上调整
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                heapifyMin(array, i, array.Length);
            }
        }

        private static void buildMaxHeap(int[] array)
        {
            // 从最后一个节点的父节点开始，向上调用调整最大堆
            for(int i = array.Length /2 -1; i >= 0; i--)
            {
                heapifyMax(array, i, array.Length);
            }
        }

        // 调整最大堆
        private static void heapifyMax(int[] array, int index, int size)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int max = index;

            if(left < size && array[left] > array[max])
            {
                max = left;
            }

            if(right < size && array[right] > array[max])
            {
                max = right;
            }

            // 有调整，将大的节点上移
            if(max != index)
            {
                swap(ref array[index], ref array[max]);
                heapifyMax(array, max, size);
            }
        }

        private static void heapifyMin(int[] array, int index, int size)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int min = index;

            if (left < size && array[left] < array[min])
            {
                min = left;
            }

            if (right < size && array[right] < array[min])
            {
                min = right;
            }

            // 有调整，将小的节点上移
            if (min != index)
            {
                swap(ref array[index], ref array[min]);
                heapifyMin(array, min, size);
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
