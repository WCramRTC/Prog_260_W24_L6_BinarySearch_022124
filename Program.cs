// In order to use stopwatch we need to use
using System.Diagnostics;

namespace Prog_260_W24_L6_BinarySearch_022124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeComplexityNotes.RunExamples();

        } // End of Program class

        public static void Stopwatch()
        {
            int target = 33;

            // Instance of stopwatch
            Stopwatch sw = new Stopwatch();

            // Start the stop watch. sw.Start();
            sw.Start();

            BinaryExample(target);

            // Stop : sw.Stop()
            sw.Stop();

            long result = sw.ElapsedMilliseconds;

            // Display the information
            Console.WriteLine("Binary Search Milliseconds: " + (result));

            int[] array = new int[] { 14, 7, 20, 5, 12, 3, 18, 10, 1, 16, 6, 19, 2, 8, 17, 9, 11, 4, 15, 13 };

            sw.Restart();

            sw.Start();

            LinearSearch(array, 33);

            sw.Stop();
            result = sw.ElapsedMilliseconds;

            // Display the information
            Console.WriteLine("Linear Search Milliseconds: " + (result));
        }

        public static int LinearSearch(int[] array, int target)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target) return i;

            }

            return -1;
        }

        public static void BinaryExample(int target)
        {
            int[] array = new int[] { 14, 7, 20, 5, 12, 3, 18, 10, 1, 16, 6, 19, 2, 8, 17, 9, 11, 4, 15, 13 };
            //int target = 17;

            Console.WriteLine("Before Sort: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Array.Sort(array);

            Console.WriteLine("After Sort: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int targetIndex = BinarySearch.BinarySearchIterative(array, target);

            Console.WriteLine(targetIndex);

        } // End of Main method

        // Target 17
        // Loop 1: 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20
        // Loop 2: 12 13 14 15 16 17 18 19 20
        // Loop 3: 17 18 19 20
        // Loop 4: 17 18
        // Loop 5: 17

        // Target 1
        // Loop 1: 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20
        // Loop 2: 1 2 3 4 5 6 7 8 9 10
        // Loop 3: 1 2 3 
        // Loop 4: 1
    }

} // End of namespace
