using System;
using System.Collections.Generic;
using System.Linq;

namespace LinearSearch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var numbers = new [] { 1, 2, 3, 4, 5, 6 };
            var numbers = Enumerable.Range(1, 10000).ToArray();

            foreach (var number in numbers)
            {
                //int? result = LinearSearch(numbers, number);
                int? result = GenericLinearSearch(numbers, number);

                if (result != null && result == (number - 1))
                {
                    Console.WriteLine($"Index for '{number}' is '{result}'");
                }
                else
                {
                    throw new Exception("Oh no!");
                }
            }

        public static int LinearSearch(int[] data, int key)
        {
            for (int index = 0; index < data.Length; index++)
            {
                if (data[index] == key)
                {
                    return index;
                }
            }

            return -1;
        }

        public static int GenericLinearSearch<T>(T[] data, T key)
        {
            for (int index = 0; index < data.Length; index++)
            {
                if (EqualityComparer<T>.Default.Equals(data[index], key))
                {
                    return index;
                }
            }

            return -1;
        }
    }
}
