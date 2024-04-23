using System;
using System.Diagnostics;

public class SortingAlgo
{
    public string SelectionSort(int[] array)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                    minIndex = j;
            }

            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }

        sw.Stop();
        return "SelectionSort: " + sw.ElapsedMilliseconds + "ms";
    }

    public string InsertionSort(int[] array)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        int n = array.Length;
        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }

        sw.Stop();
        return "InsertionSort: " + sw.ElapsedMilliseconds + "ms";
    }

    public string MergeSort(int[] array, int left, int right)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        MergeSortRecursive(array, left, right);

        sw.Stop();
        return "MergeSort: " + sw.ElapsedMilliseconds + "ms";
    }

    private void MergeSortRecursive(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSortRecursive(array, left, mid);
            MergeSortRecursive(array, mid + 1, right);
            Merge(array, left, mid, right);
        }
    }

    public string QuickSort(int[] array, int left, int right)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        QuickSortRecursive(array, left, right);

        sw.Stop();
        return "QuickSort: " + sw.ElapsedMilliseconds + "ms";
    }

    private void QuickSortRecursive(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSortRecursive(array, left, pivotIndex - 1);
            QuickSortRecursive(array, pivotIndex + 1, right);
        }
    }

    private int Partition(int[] array, int left, int right)
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

    private void Merge(int[] array, int left, int mid, int right)
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

    private void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
