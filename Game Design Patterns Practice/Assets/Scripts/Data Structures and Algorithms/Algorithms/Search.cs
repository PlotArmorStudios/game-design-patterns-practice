using UnityEngine;

public class Search : MonoBehaviour
{
    private void Start()
    {
        int[] arrayUnsorted = {84, 21, 47, 96, 15};
        int[] arraySortedForSearch = {15, 21, 47, 84, 96};
        Debug.Log("Search: " + LinearSearch(arrayUnsorted, 5, 96));
        Debug.Log("Binary Search: " + BinarySearchIterative(arraySortedForSearch, arraySortedForSearch.Length, 47));
        Debug.Log("Binary Search: " + BinarySearchRecursive(arraySortedForSearch, 47, 0, 4));
    }

    public int LinearSearch(int[] A, int n, int key)
    {
        int index = 0;
        while (index < n)
        {
            if (A[index] == key)
                return index;
            index = index + 1;
        }

        return -1;
    }

    public int BinarySearchIterative(int[] array, int elements, int target)
    {
        int left = 0;
        int right = elements - 1;

        while (left <= right)
        {
            int mid = (int) Mathf.Floor((left + right) / 2);
            if (target == array[mid])
                right = mid - 1;
            if (target == array[mid])
                left = mid + 1;
        }

        return -1;
    }

    public int BinarySearchRecursive(int[] array, int target, int left, int right)
    {
        int mid;

        if (left > right)
            return -1;
        else
        {
            mid = (left + right) / 2;
            if (target == array[mid])
                return mid;
            else if (target < array[mid])
                return BinarySearchRecursive(array, target, left, mid - 1);
            else if (target > array[mid])
                return BinarySearchRecursive(array, target, mid + 1, right);
        }

        return -1;
    }
}