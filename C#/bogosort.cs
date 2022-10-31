using System;
using System.Collections.Generic;

namespace Bogosort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = new List<int>() { 29, 100, 1, 2, 57 };
            BogoSort(list);
            Console.WriteLine(String.Join(",", list));
        }

        public static void BogoSort(IList<int> list)
        {
            var attempt = 1;
            while (!IsSorted(list))
            {
                Console.WriteLine($"Attempt {attempt}");
                list.Shuffle();
                attempt++;
            }            
        }

        static bool IsSorted(IList<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < list[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }

    /// <summary>
    /// IList extension methods.
    /// </summary>
    static class IListExtensions
    {
        static Random rng = new Random();

        /// <summary>
        /// Shuffle the items in the specified list.
        /// </summary>
        /// <param name="list">The list to shuffle.</param>
        /// <typeparam name="T">The item type.</typeparam>
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}