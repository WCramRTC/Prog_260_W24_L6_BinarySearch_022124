using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_260_W24_L6_BinarySearch_022124
{
    internal class BinarySearchNotes
    {

        // Iterative Binary Search
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; // Target not found
        } // End of BinarySearch method

        // Method to test BinarySearch
        public static void TestBinarySearch()
        {
            int[] arr = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int target = 12;
            int result = BinarySearch(arr, target);
            if (result != -1)
                Console.WriteLine("Element found at index " + result);
            else
                Console.WriteLine("Element not found in array");
        } // End of TestBinarySearch method

        // Method to generate an array with random unique values
        public static int[] GenerateRandomArray(int size)
        {
            Random rand = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                int randNum;
                do
                {
                    randNum = rand.Next();
                } while (Array.IndexOf(arr, randNum) != -1); // Ensure uniqueness
                arr[i] = randNum;
            }
            return arr;
        } // End of GenerateRandomArray method

        // Method to print an array
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("Array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        } // End of PrintArray method

        // Test Binary Search
        //public static void TestBinarySearch()
        //{
        //    // Test BinarySearch
        //    Console.WriteLine("Testing BinarySearch:");
        //    TestBinarySearch();

        //    // Generate random array
        //    int[] randomArray = BinarySearchNotes.GenerateRandomArray(10);
        //    Console.WriteLine("\nGenerated Random Array:");
        //    BinarySearchNotes.PrintArray(randomArray);
        //} // End of TestBinarySearch method

    } // End of BinarySearchNotes class
} // End of namespace
