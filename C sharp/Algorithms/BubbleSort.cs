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

            /// <summary>
            /// 常见的优化后的冒泡排序
            /// </summary>
            /// <typeparam name="T"></typeparam>
            public class BubbleSortV2<T>
            where T : IComparable  // 限定T是可比较大小的
            {
                /// <summary>
                /// 升序排序
                /// </summary>
                /// <param name="array"></param>
                /// <param name="length"></param>
                public static void Sort(IList<T> array, int length)
                {
                    for (int i = 1; i < length; i++)     // 比较n-1次
                    {
                        for (int j = 0; j < length - i; j++) // 每次都遍历整个数组, 进行冒泡
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
                    for (int i = 1; i < length; i++)     // 比较n-1次
                    {
                        for (int j = 0; j < length - i; j++)  // 每次都遍历整个数组, 进行冒泡
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

            /// <summary>
            /// 冒泡排序的另一种实现思路, 当没有发生交换时, 说明是有序的, 即终止排序, 最好能达到o(n), 一般为O(n^2)
            /// </summary>
            /// <typeparam name="T"></typeparam>
            public class BubbleSortV3<T>
            where T: IComparable
            {
                /// <summary>
                /// 升序
                /// </summary>
                /// <param name="array"></param>
                /// <param name="length"></param>
                public static void Sort(IList<T> array, int length)
                {
                    int count = 0;  // 已经冒泡的个数
                    bool isChange = false;
                    while (true)
                    {
                        isChange = false;
                        for (int i = 0; i < length - 1 - count; i++)
                        {
                            if(array[i].CompareTo(array[i + 1]) > 0)
                            {
                                var temp = array[i];
                                array[i] = array[i + 1];
                                array[i + 1] = temp;
                                isChange = true;
                            }
                        }
                        count++;
                        if(!isChange)
                        {
                            break;
                        }
                    }
                }
                /// <summary>
                /// 降序
                /// </summary>
                /// <param name="array"></param>
                /// <param name="length"></param>
                public static void SortDesc(IList<T> array, int length)
                {
                    int count = 0;  // 已经冒泡的个数
                    bool isChange = false;
                    while (true)
                    {
                        isChange = false;
                        for (int i = 0; i < length - 1 - count; i++)
                        {
                            if (array[i].CompareTo(array[i + 1]) < 0)
                            {
                                var temp = array[i];
                                array[i] = array[i + 1];
                                array[i + 1] = temp;
                                isChange = true;
                            }
                        }
                        count++;
                        if (!isChange)
                        {
                            break;
                        }
                    }
                }

            }// end class

        }
    }

}
