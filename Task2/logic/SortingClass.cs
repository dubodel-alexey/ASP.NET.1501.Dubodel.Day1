using System;
using System.Linq;

namespace logic
{
    public static class SortingClass
    {
        public static void SortByElementsSum(double[][] targerArray, bool direct)
        {
            var array = new double[targerArray.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = targerArray[i].Sum();
            }

            Sort(targerArray, array, direct);
        }

        public static void SortByElementsSum(int[][] targerArray, bool direct)
        {
            var array = new int[targerArray.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = targerArray[i].Sum();
            }

            Sort(targerArray, array, direct);
        }

        public static void SortByMaxElements<T>(T[][] targerArray, bool direct) where T : IComparable<T>
        {
            var array = new T[targerArray.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = targerArray[i].Max();
            }

            Sort(targerArray, array, direct);
        }

        public static void SortByMinElements<T>(T[][] targerArray, bool direct) where T : IComparable<T>
        {
            var array = new T[targerArray.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = targerArray[i].Min();
            }

            Sort(targerArray, array, direct);
        }

        private static void Sort<T>(T[][] targerArray, T[] array, bool direct) where T : IComparable<T> 
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (direct)
                    {
                        if (array[j].CompareTo(array[i]) < 0) 
                        {
                            Swap(ref array[j],ref array[i]);
                            Swap(ref targerArray[j],ref targerArray[i]);
                        }
                    }
                    else
                    {
                        if (array[j].CompareTo(array[i]) > 0) 
                        {
                            Swap(ref array[j], ref array[i]);
                            Swap(ref targerArray[j], ref targerArray[i]);
                        }
                    }
                }
            }
        }

        public static void Swap<T>(ref T firstItem, ref T secondItem)
        {
            T temp = firstItem;
            firstItem = secondItem;
            secondItem = temp;
        }
    }
}
