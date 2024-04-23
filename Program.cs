class Program
{
    static void Main(string[] args)
    {
        TestSelectionSort();
        TestInsertionSort();
        TestMergeSort();
        TestQuickSort();
    }

    public static void TestSelectionSort()
    {
        SortingAlgo s1 = new SortingAlgo();
        MySort m1 = new MySort();
        int[] arr = m1.Create();
        Console.WriteLine(s1.SelectionSort(arr));
        MySort.PrintArray(arr);
    }

    public static void TestInsertionSort()
    {
        SortingAlgo s1 = new SortingAlgo();
        MySort m1 = new MySort();
        int[] arr = m1.Create();
        Console.WriteLine(s1.InsertionSort(arr));
        MySort.PrintArray(arr);
    }

    public static void TestMergeSort()
    {
        SortingAlgo s2 = new SortingAlgo();
        MySort m2 = new MySort();
        int[] arr = m2.Create();
        Console.WriteLine(s2.MergeSort(arr, 0, arr.Length - 1));
        MySort.PrintArray(arr);
    }

    public static void TestQuickSort()
    {
        SortingAlgo s1 = new SortingAlgo();
        MySort m1 = new MySort();
        int[] arr = m1.Create();
        Console.WriteLine(s1.QuickSort(arr, 0, arr.Length - 1));
        MySort.PrintArray(arr);
    }
}

class MySort
{
    public const int Size = 10000;
    private static Random r = new Random();

    public int[] Create()
    {
        int[] arr = new int[Size];
        for (int i = 0; i < Size; i++)
        {
            arr[i] = r.Next(1,100);
        }
        return arr;
    }
    public static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}