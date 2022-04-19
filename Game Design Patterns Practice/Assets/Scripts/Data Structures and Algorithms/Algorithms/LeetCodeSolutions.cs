using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeetCodeSolutions : MonoBehaviour
{
    private int[] nums = new[] {1, 2, 5, 2, 3};

    private int[][] grid = new int[][]
    {
        new int[] {4,3,2,-1},
        new int[] {3,2,1,-1},
        new int[] {1,1,-1,-2},
        new int[] {-1,-1,-2,-3},
    };
    
    void Start()
    {
        // SortArray(nums);
        // Display(nums);

        //Display(TargetIndices(nums, 2));
    }

    public IList<int> TargetIndices(int[] nums, int target)
    {
        List<int> indices = new List<int>();
        int index = 0;

        SortArray(nums);

        while (index < nums.Length)
        {
            if (nums[index] == target)
                indices.Add(index);
            index = index + 1;
        }

        return indices;
    }

    private void SortArray(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            int position = i;

            for (int j = i + 1; j < nums.Length; j++) if (nums[j] < nums[position]) position = j;

            int temp = nums[i];
            nums[i] = nums[position];
            nums[position] = temp;
        }
    }

    public void Display(IList<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i].ToString());
        }
    }

    public void Display(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i].ToString());
        }
    }

    public int CountNegatives(int[][] grid)
    {
        int count = 0;
        
        
        return count;
    }
}