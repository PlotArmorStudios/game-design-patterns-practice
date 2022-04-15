using UnityEngine;

public class Sort : UseArray
{
    private void Start()
    {
        Debug.Log("Original array: ");
        Display(ArrayUnsorted);

        //SelectionSort
        // Debug.Log("Sorted array: ");
        // SelectionSort(ArrayUnsorted);
        // Display(ArrayUnsorted);

        //InsertionSort
        // Debug.Log("Sorted array: ");
        // InsertionSort(ArrayUnsorted);
        // Display(ArrayUnsorted);
        Debug.Log("Sorted array: ");
        BubbleSort(ArrayUnsorted);
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
        for (int position = 0;
            position < array.Length - 1;
            position++) //i = array.Length - 1 because you don't want to compare the last element with all the other elements. It's already sorted
        {
            int currentNumber = position;
            //j = position + 1 because j is the position being checked and compared to i.
            for (int comparison = position + 1; comparison < array.Length; comparison++)
                if (array[comparison] < array[currentNumber]) //checking for selection
                    currentNumber = comparison; //stores smallest number found as the position to be swapped
            //swap smallest number into current position
            int temp = array[position];
            array[position] = array[currentNumber];
            array[currentNumber] = temp;
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
        for (int pass = array.Length - 1; pass >= 0; pass--) //pass = array.Length - 1 the idea idea the largest element will be in its place in the first pass
        {
            for (int j = 0; j < pass; j++)// j < pass because we only need to traverse until the second largest element. largest element is already sorted
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
}