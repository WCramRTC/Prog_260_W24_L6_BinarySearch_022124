namespace Prog_260_W24_L6_BinarySearch_022124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        } // End of Main method

        // Test Binary Search
        public static void TestBinarySearch()
        {
            // Test BinarySearch
            Console.WriteLine("Testing BinarySearch:");
            TestBinarySearch();

            // Generate random array
            int[] randomArray = BinarySearchNotes.GenerateRandomArray(10);
            Console.WriteLine("\nGenerated Random Array:");
            BinarySearchNotes.PrintArray(randomArray);
        } // End of TestBinarySearch method
    } // End of Program class
} // End of namespace
