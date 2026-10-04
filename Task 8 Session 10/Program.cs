using System.Collections;
using System.Collections.Specialized;

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
        
        public static List<int> GetEvenNumbers(List<int> list)
        {
            for(var i = 0; i< list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            return list;
        }

        public static int FirstNonRepeatedChar(string str)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charCounts.ContainsKey(c))
                    charCounts[c]++;
                else
                    charCounts[c] = 1;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (charCounts[str[i]] == 1)
                    return i;
            }

            return -1;
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
            //ArrayList arraylist = new ArrayList() { 1, 2, 3, 4, 5 };
            //ReverseArrayList(arraylist);
            //foreach(var item in arraylist)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q4
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //GetEvenNumbers(list);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q5
            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(5);

            //fixedSizeList.Add(1);
            //fixedSizeList.Add(2);
            //fixedSizeList.Add(3);
            //fixedSizeList.Add(4);
            //fixedSizeList.Add(5);

            //Console.WriteLine(fixedSizeList.Get(0));
            //Console.WriteLine(fixedSizeList.Get(2));
            //Console.WriteLine(fixedSizeList.Get(4));

            //fixedSizeList.Add(6); //List is full
            //Console.WriteLine(fixedSizeList.Get(5)); //Index is out of range.
            #endregion

            #region Q6
            //string testStr = "hahakhaha";
            //int index = FirstNonRepeatedChar(testStr);
            //Console.WriteLine($"First non-repeated char in '{testStr}' is at index: {index} (Character: '{testStr[index]}')");
            #endregion
        }
    }
}
