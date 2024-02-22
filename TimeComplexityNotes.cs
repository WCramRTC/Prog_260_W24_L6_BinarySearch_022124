using System;
using System.Diagnostics;

namespace Prog_260_W24_L6_BinarySearch_022124
{
    public class TimeComplexityNotes
    {
        // Linear search: O(n) time complexity, O(1) space complexity
        public static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++) // Impact on time complexity: Iterates through the entire array once, linear time complexity
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        } // End of LinearSearch method

        // Binary search: O(log n) time complexity, O(1) space complexity
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right) // Impact on time complexity: Reduces the search space by half in each iteration, logarithmic time complexity
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        } // End of BinarySearch method

        // Example with high time complexity: O(n^2) time complexity
        public static void NestedLoop(int n)
        {
            for (int i = 0; i < n; i++) // Impact on time complexity: Nested loops iterating n times each, resulting in quadratic time complexity
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Nested loop iteration");
                }
            }
        } // End of NestedLoop method

        // Example with high space complexity: O(n) space complexity
        public static void CreateArray(int n)
        {
            int[] arr = new int[n]; // Impact on space complexity: Creates an array of size n, resulting in linear space complexity
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }
        } // End of CreateArray method

        // Method to run examples
        public static void RunExamples()
        {
            Stopwatch stopwatch = new Stopwatch();

            // Example with linear search
            int[] linearArr = { 2, 4, 6, 8, 10 };
            int linearTarget = 8;
            stopwatch.Start();
            int linearIndex = LinearSearch(linearArr, linearTarget);
            stopwatch.Stop();
            Console.WriteLine("Linear search result: " + linearIndex);
            Console.WriteLine("Time taken for LinearSearch: " + stopwatch.ElapsedMilliseconds + " milliseconds");

            // Example with binary search
            int[] binaryArr = { 2, 4, 6, 8, 10 };
            int binaryTarget = 6;
            stopwatch.Restart();
            int binaryIndex = BinarySearch(binaryArr, binaryTarget);
            stopwatch.Stop();
            Console.WriteLine("Binary search result: " + binaryIndex);
            Console.WriteLine("Time taken for BinarySearch: " + stopwatch.ElapsedMilliseconds + " milliseconds");

            // Example with high time complexity
            stopwatch.Restart();
            NestedLoop(5); // Nested loops iterating 5 times each, resulting in O(n^2) time complexity
            stopwatch.Stop();
            Console.WriteLine("Time taken for NestedLoop: " + stopwatch.ElapsedMilliseconds + " milliseconds");

            // Example with high space complexity
            stopwatch.Restart();
            CreateArray(10); // Creates an array of size 10, resulting in O(n) space complexity
            stopwatch.Stop();
            Console.WriteLine("Time taken for CreateArray: " + stopwatch.ElapsedMilliseconds + " milliseconds");
        } // End of RunExamples method
    } // End of TimeComplexityNotes class
} // End of namespace
