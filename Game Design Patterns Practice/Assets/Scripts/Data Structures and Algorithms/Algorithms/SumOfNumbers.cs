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

public class UseArray : MonoBehaviour
{
    protected int[] ArrayUnsorted = {84, 21, 47, 96, 15};
    protected int[] ArraySortedForSearch = {15, 21, 47, 84, 96};
}