using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberOfGoodPairs : MonoBehaviour
{
    private void Start()
    {
        int[] nums = new[] {1, 2, 3, 1, 1, 3};
        int numGoodPairs = NumIdenticalPairs(nums);
        Debug.Log(numGoodPairs);
    }

    public int NumIdenticalPairs(int[] nums)
    {
        int goodPairs = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] == nums[j] && i < j)
                {
                    goodPairs++;
                }
            }
        }

        return goodPairs;
    }
}