using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumOfNumbers : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Sum: " + SumOfN(5));
        Debug.Log("Sum iteration: " + SumNIteration(5));
        Debug.Log("Sum recursion: " + SumNRecursion(5));
    }

    public int SumOfN(int n)
    {
        return n * (n + 1) / 2;
    }

    public int SumNIteration(int n)
    {
        int total = 0;
        int i = 1;
        while (i <= n)
        {
            total = total + i;
            i = i + 1;
        }

        return total;
    }

    public int SumNRecursion(int n)
    {
        if (n == 0)
            return 0;
        return SumNRecursion(n - 1) + n;
    }
}

public class Factorial : UseArray
{
    private void Start()
    {
        Debug.Log("Factorial Iterative: " + FactorialIterative(5));
        Debug.Log("Factorial Recursive: " + FactorialRecursive(5));
    }

    public int FactorialIterative(int n)
    {
        int fact = 1;
        for (int i = 0; i < n; i++)
            fact *= i;
        return fact;
    }

    public int FactorialRecursive(int n)
    {
        if (n == 0) return 1;
        return FactorialRecursive(n - 1) * n;
    }
}

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

public class UseArray : MonoBehaviour
{
    protected int[] ArrayUnsorted = {84, 21, 47, 96, 15};
    protected int[] ArraySortedForSearch = {15, 21, 47, 84, 96};
}