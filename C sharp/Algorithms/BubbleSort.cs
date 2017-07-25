using System;
using System.Collections.Generic;

namespace Algorithms
{
    namespace Sort
    {
        namespace BubbleSort
        {
            /// <summary>
            /// 最简单的冒泡排序算法, 未进行任何优化
            /// </summary>
            /// <typeparam name="T"></typeparam>
            public class BubbleSortV1<T>
            where T : IComparable  // 限定T是可比较大小的
            {
                /// <summary>
                /// 升序排序
                /// </summary>
                /// <param name="array"></param>
                /// <param name="length"></param>
                public static void Sort(IList<T> array, int length)
                {
                    for (int i = 0; i < length - 1; i++)     // 比较n-1次
                    {
                        for (int j = 0; j < length - 1; j++) // 每次都遍历整个数组, 进行冒泡
                        {
                            if (array[j].CompareTo(array[j + 1]) > 0) // 大于
                            {
                                var temp = array[j];
                                array[j] = array[j + 1];
                                array[j + 1] = temp;
                            }
                        }
                    }
                }
                /// <summary>
                /// 降序排序
                /// </summary>
                /// <param name="array"></param>
                /// <param name="length"></param>
                public static void SortDesc(IList<T> array, int length)
                {
                    for (int i = 0; i < length - 1; i++)     // 比较n-1次
                    {
                        for (int j = 0; j < length - 1; j++)  // 每次都遍历整个数组, 进行冒泡
                        {
                            if (array[j].CompareTo(array[j + 1]) < 0) // 小于
                            {
                                var temp = array[j];
                                array[j] = array[j + 1];
                                array[j + 1] = temp;
                            }
                        }
                    }
                }
            } // end class

        }
    }

}
