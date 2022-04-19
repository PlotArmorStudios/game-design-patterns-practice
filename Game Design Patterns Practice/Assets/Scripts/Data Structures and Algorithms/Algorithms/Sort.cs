using UnityEngine;

public class Sort : UseArray
{
    private int[] nums = new[] {1, 2, 5, 2, 3};

    private void Start()
    {
        Debug.Log("Original array: ");
        Display(ArrayUnsorted);

        Debug.Log("Sorted array: ");
        //SelectionSort
        // SelectionSort(nums);
        // Display(nums);

        //InsertionSort
        // InsertionSort(ArrayUnsorted);
        // Display(ArrayUnsorted);

        //BubbleSort
        // BubbleSort(ArrayUnsorted);
        // Display(ArrayUnsorted);

        //ShellSort
        // ShellSort(ArrayUnsorted);
        // Display(ArrayUnsorted);

        //MergeSort
        MergeSort(ArrayUnsorted, 0, 4);
        Display(ArrayUnsorted);
    }

    public void Display(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i].ToString());
        }
    }

    public void SelectionSort(int[] array)
    {
        for (int i = 0;
            i < array.Length - 1;
            i++) //i = array.Length - 1 because you don't want to compare the last element with all the other elements. It's already sorted
        {
            int position = i;
            //j = i + 1 because j is the position (to the right of i) being checked and compared to i.
            for (int j = i + 1; j < array.Length; j++)
                if (array[j] < array[position]) //checking for selection
                    position = j; //stores smallest number found as the position to be swapped
            //swap smallest number into current position
            int temp = array[i];
            array[i] = array[position];
            array[position] = temp;
        }
    }

    public void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int comparison =
                array[i]; //stores the present element at array[i]. will be used to insert the element to its proper position
            int position = i; //used to compare the element at the index of position with comparison
            //find the position where the element can be inserted
            while (
                position > 0 &&
                array[position - 1] >
                comparison) //after inserting the element to the index of the position, all the elements to the left must be moved right to be sorted
            {
                array[position] = array[position - 1]; //move the element to the right
                position = position - 1;
            }

            array[position] = comparison;
        }
    }

    public void BubbleSort(int[] array) //the largest elements are sorted to their place first
    {
        for (int pass = array.Length - 1;
            pass >= 0;
            pass--) //pass = array.Length - 1 the idea idea the largest element will be in its place in the first pass
        {
            for (int j = 0;
                j < pass;
                j++) // j < pass because we only need to traverse until the second largest element. largest element is already sorted
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public void ShellSort(int[] array)
    {
        int gap = array.Length / 2;

        while (gap > 0)
        {
            int i = gap;
            while (i < array.Length)
            {
                int temp = array[i];
                int j = i - gap;
                while (j >= 0 && array[j] > temp)
                {
                    array[j + gap] = array[j];
                    j = j - gap;
                }

                array[j + gap] = temp;
                i++;
            }

            gap = gap / 2;
        }
    }

    public void MergeSort(int[] A, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2; //1. compute the index of the middle of array A array
            MergeSort(A, left, mid); //Recursively split left side of array A into SUB arrays
            MergeSort(A, mid + 1, right); //Recursively split right side of array A into SUB arrays
            Merge(A, left, mid,
                right); //Sort(compare and reorganize into a placeholder array) and merge the SUB arrays that have been split
        }
    }

    private void Merge(int[] A, int left, int mid, int right)
    {
        int i = left;
        int j = mid + 1; //Compare starting at mid index + 1
        int k = left;
        int[] B = new int[right + 1]; //Array used for merging the elements

        while (i <= mid && j <= right) //merge two sorted SUB arrays
        {
            if (
                A[i] < A[j]) //if this is true, it means the elements of the first SUB array is smaller than the element of the second SUB array
            {
                B[k] = A[i]; //store the element of the first SUB array
                i = i + 1; //moves to the next index of the FIRST SUB array
            }
            else //If this is true, it means the elements of the second SUB array is smaller than the element of the first SUB array
            {
                B[k] = A[j]; //store the element of the SECOND SUB array
                j = j + 1; //moves to the next index of the SECOND SUB array
            }

            k = k + 1; //moves to next index of the placeholder array
        }

        //one SUB array may have more elements that the other SUB array. If there are any, this will copy the remaining elements from the first SUB array INTO ARRAY B
        //B[k] in this case is the left side of the placeholder array
        while (i <= mid)
        {
            B[k] = A[i]; //cycle through left side of B[k], first SUB array
            i = i + 1; //cycle through first SUB array
            k = k + 1; //cycle through left side of B[k]
        }

        //If there are any, this will copy the remaining elements from the second SUB array INTO ARRAY B
        while (j <= right)
        {
            B[k] = A[j]; //cycle through right side of B[k], second SUB array
            j = j + 1; //cycle through second SUB array
            k = k + 1; //cycle through right side of B[k]
        }

        for (int x = left;
            x < right + 1;
            x++) //To finalize the sort, copy sorted elements from array B back into unsorted array A
            A[x] = B[x];
    }

    public void QuickSort(int[] A, int low, int high) 
    {
        if (low < high)
        {
            int pivot = Parition(A, low, high); //compute the pivot index (partitioning element). Gets called multiple times
            QuickSort(A, low, pivot - 1); //Sort the left side of the pivot element
            QuickSort(A, pivot + 1, high); //Sort the right side of the pivot element
        }
    }

    public int Parition(int[] A, int low, int high)
    {
        int pivot = A[low]; //selects the first element in this (sub) array
        //moves from left to right. Initially refers to first element. Moves to the right 1 position at a time.
        // Compares the element at that position with the pivot
        //if it is smaller than the pivot then i will move to the next position
        //Comparision is performed again
        
        //if it is greater than the pivot then i will stop
        int i = low + 1; 
        
        //moves from right to left. Initially refers to beyond the last element. Compares with pivot. If smaller, stops. If bigger, moves and compares
        int j = high; 
        
        //once i and j have both stopped (i.e. a number larger and smaller than the pivot identified),
        //those numbers (bigger and smaller) are swapped.
        
        //perform partitioning of the elements
        do
        {
            //move i to the right if i and j don't cross and if Array[i] is less than or = to the pivot
            while (i <= j && A[i] <= pivot) //i stops when A[i] is greater than pivot
                i = i + 1;
            //move j to the left if i and j don't cross and if Array[i] is greater than the pivot
            while (i <= j && A[j] > pivot) //j stops when A[j] is less than pivot
                j = j - 1;
            if (i <= j)
                Swap(A, i, j); //called when i and j both stop. This swaps the values in i and j, sorting them.
        } while (i < j);

        //once the elements are swapped based to the pivot element,
        // the i and j positions cross over (i > j)
        //now we need to swap the pivot element and the element at index j
        Swap(A, low, j);
        return j; //more partitions are made based on this new pivot
    }

    public void Swap(int[] A, int i, int j)
    {
        int temp = A[i]; 
        A[i] = A[j];
        A[j] = temp;
    }
}