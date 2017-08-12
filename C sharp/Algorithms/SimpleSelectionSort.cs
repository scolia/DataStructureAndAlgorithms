using System;
using System.Collections.Generic;

namespace Algorithms
{
    namespace Sort
    {
        namespace SimpleSelectionSort
        {
            public class SimpleSelectionSortV1<T>
            where T : IComparable
            {
                /// <summary>
                /// 升序排序
                /// </summary>
                /// <param name="array"></param>
                /// <param name="length"></param>
                public static void Sort(IList<T> array, int length)
                {
                    int index;
                    for (int i = 0; i < length; i++)
                    {
                        index = i;
                        for (int j = i + 1; j < length; j++)
                        {
                            if (array[index].CompareTo(array[j]) > 0)
                            {
                                index = j;
                            }
                        }
                        if (i != index)
                        {
                            var temp = array[i];
                            array[i] = array[index];
                            array[index] = temp;
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
                    int index;
                    for (int i = 0; i < length; i++)
                    {
                        index = i;
                        for (int j = i + 1; j < length; j++)
                        {
                            if (array[index].CompareTo(array[j]) < 0)
                            {
                                index = j;
                            }
                        }
                        if (i != index)
                        {
                            var temp = array[i];
                            array[i] = array[index];
                            array[index] = temp;
                        }
                    }
                }

            }
        }
    }
    
}
