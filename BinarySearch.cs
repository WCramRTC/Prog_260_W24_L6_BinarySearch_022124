using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_260_W24_L6_BinarySearch_022124
{
    internal class BinarySearch
    {

        public static int BinarySearchIterative(int[] array, int target)
        {
            // pointer
            int left = 0; // The first index
            int right = array.Length - 1; // The last index

            int count = 1;
            // If i had unsorted data, i would use a linear search
            // [ 1,6, 9, 3, 0, 34, 11]

            // Binary search can ONLY work, on a sorted collection
            // [0, 1, 3, 6, 9, 11, 34]
            //  0        3          6

            while(left <= right) // while the left pointer value is LESS than right pointer value, keep running
            {
                //        int mid = left + (right - left) / 2;
                int mid = left + (right - left) / 2;
                // left = 0
                // right = 6
                // mid = 3

                Console.WriteLine("Loop: " + count++);

                // [0, 1, 3, 6, 9, 11, 34]
                //  0        3          6
                // left     mid       right

                // Checking to see if the current element is the target
                if (array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] < target) // 6 < 11
                {
                    left = mid + 1; // left = 3 + 1 = 4
                    // [0, 1, 3, 6, 9, 11,    34]
                    //              4          6
                    //            left       right
                } // 0, 1, 2
                else if (array[mid] > target)
                {
                    right = mid - 1;
                }

                //        if (arr[mid] == target)
                //            return mid;
                //        else if (arr[mid] < target)
                //            left = mid + 1;
                //        else
                //            right = mid - 1;
            }

            // Will return if the value is not found
            return -1;
        } // BinarySearch


    } // class

    //// Iterative Binary Search
    //public static int BinarySearch(int[] arr, int target)
    //{
    //    int left = 0;
    //    int right = arr.Length - 1;

    //    while (left <= right)
    //    {
    //        int mid = left + (right - left) / 2;

    //        if (arr[mid] == target)
    //            return mid;
    //        else if (arr[mid] < target)
    //            left = mid + 1;
    //        else
    //            right = mid - 1;
    //    }

    //    return -1; // Target not found
    //} // End of BinarySearch method

} // namespace
