using System.Diagnostics;

namespace RecusiveSorting19;

public class SortingAlgo
{
    public static void QuickSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSort(array,left,pivotIndex-1);
            QuickSort(array,pivotIndex+1,right);
        }
    }
    
    public static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right);
        return i + 1;
    }
    
    public static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    
    public static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);
            Merge(array, left, mid, right);
        }
    }

    private static void Merge(int[] array, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        Array.Copy(array, left, L, 0, n1);
        Array.Copy(array, mid + 1, R, 0, n2);

        int i = 0, j = 0, k = left;

        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                array[k] = L[i];
                i++;
            }
            else
            {
                array[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            array[k] = L[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            array[k] = R[j];
            j++;
            k++;
        }
    }

  
    public static void TestSortingAlgorithmWithArraysOfSize()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        stopwatch.Stop();
        Console.WriteLine("Time elapsed: " + stopwatch.ElapsedMilliseconds + " ms");
        Random r = new Random();
        int size = r.Next(1, 100);
        int[] array = new int[size];
        stopwatch = Stopwatch.StartNew();
        SortingAlgo.QuickSort(array, 0, array.Length - 1);
        stopwatch.Stop();
        Console.WriteLine($"QuickSort for array size {size}: {stopwatch.ElapsedMilliseconds} ms");

        // Wiederholen Sie den Vorgang für MergeSort und andere Algorithmen
    }

    

}

