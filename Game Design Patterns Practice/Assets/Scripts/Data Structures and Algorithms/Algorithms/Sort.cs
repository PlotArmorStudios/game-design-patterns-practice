using UnityEngine;

public class Sort : UseArray
{
    private void Start()
    {
        Debug.Log("Original array: ");
        Display(ArrayUnsorted);
        Debug.Log("Sorted array: ");
        SelectionSort(ArrayUnsorted);
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
}