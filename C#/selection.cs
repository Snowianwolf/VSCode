using System;
using System.Collections.Generic;

namespace SelectionSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = new List<int>() { 29, 100, 1, 2, 57 };
            var sortedList = SelectionSort(list);
            Console.WriteLine(String.Join(",", sortedList));
        }

        static List<int> SelectionSort(IList<int> list)
        {
            var sortedList = new List<int>();
            while (list.Count > 0)
            {
                int indexToMove = IndexOfMin(list);
                int min = list[indexToMove];
                list.RemoveAt(indexToMove);
                sortedList.Add(min);
            }
            return sortedList;
        }

        static int IndexOfMin(IList<int> list)
        {
            int minIndex = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < list[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }
    }
}