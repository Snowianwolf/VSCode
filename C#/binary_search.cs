using System;
using System.Linq;

namespace BinarySearch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var numbers = new [] { 1, 2, 3, 4, 5, 6 };
            var numbers = Enumerable.Range(1, 10000).ToArray();

            foreach (var number in numbers)
            {
                //int? result = IterativeBinarySearch(numbers, number);
                int? result = RecursiveBinarySearch(numbers, number);

                if (result != null && result == (number - 1))
                {
                    Console.WriteLine($"Index for '{number}' is '{result}'");
                }
                else
                {
                    throw new Exception("Oh no!");
                }
            }

        }

        public static int? IterativeBinarySearch(int[] data, int key)
        {
            var first = 0;
            var last = data.Length - 1;

            while (first <= last)
            {
                var mid = (first + last) / 2;

                if (data[mid] < key)
                {
                    first = mid + 1;
                }
                else if (data[mid] > key)
                {
                    last = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return null;
        }

        public static int? RecursiveBinarySearch<T>(T[] data, T key)
            where T : IComparable<T>
        {
            return RecursiveBinarySearch(data, key, 0, data.Length - 1);
        }

        public static int? RecursiveBinarySearch<T>(
            T[] data, T key, int first, int last)
            where T : IComparable<T>
        {
            if (first > last)
            {
                return null;
            }
            else
            {
                var mid = (first + last) / 2;
                var comparison = data[mid].CompareTo(key);

                if (comparison < 0)
                {
                    return RecursiveBinarySearch(data, key, mid + 1, last);
                }
                else if (comparison > 0)
                {
                    return RecursiveBinarySearch(data, key, first, mid - 1);
                }
                else
                {
                    return mid;
                }
            }
        }
    }
}