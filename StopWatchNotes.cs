using System;
using System.Diagnostics;
namespace Prog_260_W24_L6_BinarySearch_022124;

public class TimeComplexityExamples
{
    // O(1) - Constant Time Complexity
    public static int GetFirstElement(int[] arr)
    {
        if (arr.Length > 0)
            return arr[0];
        else
            throw new InvalidOperationException("Array is empty");
    }

    // O(n) - Linear Time Complexity
    public static int FindMax(int[] arr)
    {
        if (arr.Length == 0)
            throw new InvalidOperationException("Array is empty");

        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;
    }

    // O(n^2) - Quadratic Time Complexity
    public static int[] BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        return arr;
    }

    // O(log n) - Logarithmic Time Complexity
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
    }

    // Method to generate an array with random values
    public static int[] GenerateRandomArray(int size)
    {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(1, 101); // Random numbers between 1 and 100
        }
        return arr;
    }

    // Method to run tests and measure performance
    public static void RunTests()
    {
        int[] arr = GenerateRandomArray(1000000); // Generating a large array for demonstration

        Stopwatch stopwatch = new Stopwatch();

        // O(1) - Constant Time Complexity
        stopwatch.Start();
        int firstElement = GetFirstElement(arr);
        stopwatch.Stop();
        Console.WriteLine("First element: " + firstElement);
        Console.WriteLine("Time taken for O(1) operation: " + stopwatch.ElapsedMilliseconds + " milliseconds");
        Console.WriteLine();

        // O(n) - Linear Time Complexity
        stopwatch.Restart();
        int max = FindMax(arr);
        stopwatch.Stop();
        Console.WriteLine("Max element: " + max);
        Console.WriteLine("Time taken for O(n) operation: " + stopwatch.ElapsedMilliseconds + " milliseconds");
        Console.WriteLine();

        // O(n^2) - Quadratic Time Complexity
        stopwatch.Restart();
        int[] sortedArray = BubbleSort(arr);
        stopwatch.Stop();
        Console.Write("Sorted array: ");
        foreach (int num in sortedArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Time taken for O(n^2) operation: " + stopwatch.ElapsedMilliseconds + " milliseconds");
        Console.WriteLine();

        // O(log n) - Logarithmic Time Complexity
        Array.Sort(sortedArray); // Sorting the array for binary search
        stopwatch.Restart();
        int index = BinarySearch(sortedArray, arr[0]); // Searching for the first element
        stopwatch.Stop();
        Console.WriteLine("Index of target element: " + index);
        Console.WriteLine("Time taken for O(log n) operation: " + stopwatch.ElapsedMilliseconds + " milliseconds");
    }
}
