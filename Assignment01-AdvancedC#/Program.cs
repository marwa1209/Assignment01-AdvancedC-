using Assignment01_AdvancedC_.Question1;

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
