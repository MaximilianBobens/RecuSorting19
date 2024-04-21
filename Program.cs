namespace RecusiveSorting19;
class Progam
{
    static void Main(string[] args)
    {
        int[] arrayTestQuick = { 3, 6, 7, 2, 9 };
        SortingAlgo.QuickSort(arrayTestQuick,0,arrayTestQuick.Length-1);
        Console.WriteLine("Sorted QuickSort:");
        PrintArray(arrayTestQuick);

        int[] arrayTestMerge = { 3, 9, 6, 7, 2, 1 };
        SortingAlgo.MergeSort(arrayTestMerge,0,arrayTestMerge.Length-1);
        Console.WriteLine("Sorted MergeSort:");
        PrintArray(arrayTestMerge);
        
        SortingAlgo.TestSortingAlgorithmWithArraysOfSize();
    }
    
    private static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item + " ");
        }

        Console.WriteLine();
    }
}