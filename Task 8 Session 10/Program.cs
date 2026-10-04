using System.Collections;

namespace Task_8_Session_10
{
    internal class Program
    {
        public static void ReverseArrayList(ArrayList arraylist)
        {
            var left = 0;
            var right = arraylist.Count - 1;

            while(left < right)
            {
                var tmp = arraylist[left];
                arraylist[left] = arraylist[right];
                arraylist[right] = tmp;
                left++;
                right--;
            }
        }
        

        static void Main(string[] args)
        {
            #region Q1
            //The optimization is that i did a check if the array is already sorted,
            //if it is then we break the loop and return the array.

            //int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            //Helper<int>.OptimizedSort(data);
            //foreach(var i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q2
            //var range = new Range<int>(10, 20);
            //Console.WriteLine($"Is 15 in range 10-20? {range.IsInRange(15)}");
            //Console.WriteLine($"Range length: {range.Length()}");
            #endregion

            #region Q3
            ArrayList arraylist = new ArrayList() { 1, 2, 3, 4, 5 };
            ReverseArrayList(arraylist);
            foreach(var item in arraylist)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Q4

            #endregion
        }
    }
}
