using Assignment01_AdvancedC_.Question1;
using Assignment01_AdvancedC_.Question2;

namespace Assignment01_AdvancedC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            int[] intArray = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Original integer array:");
            PrintArray(intArray);

            BubbleSort.OptimizedBubbleSort(intArray);
            Console.WriteLine("\nSorted integer array:");
            PrintArray(intArray);
            #endregion
            #region Q2
            // Example with integer range
            Range<int> intRange = new Range<int>(11, 5);
            Console.WriteLine($"Is 10 in range? {intRange.IsInRange(10)}"); 
            Console.WriteLine($"Is 20 in range? {intRange.IsInRange(20)}"); 
            Console.WriteLine($"Length of integer range: {intRange.Length()}"); 

            // Example with double range
            Range<double> doubleRange = new Range<double>(8.9, 2.5);
            Console.WriteLine($"Is 5.0 in range? {doubleRange.IsInRange(5.0)}"); 
            Console.WriteLine($"Is 9.0 in range? {doubleRange.IsInRange(9.0)}"); 
            Console.WriteLine($"Length of double range: {doubleRange.Length()}"); 
            #endregion
        }
        #region Q1
        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        } 
        #endregion
    }
}
