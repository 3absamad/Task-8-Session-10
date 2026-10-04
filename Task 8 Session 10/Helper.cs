using System;
using System.Collections.Generic;
using System.Text;

namespace Task_8_Session_10
{
    public class Helper<T> where T : IComparable<T>
    {
        public static void Swap(ref T a, ref T b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }
        
        public static void OptimizedSort(T[] arr)
        {
            if (arr is null)
                return;

            for(var  i = 0; i < arr.Length; i++)
            {
                bool swapped = false;
                for(var j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j+1]) == 1)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
    }
}
