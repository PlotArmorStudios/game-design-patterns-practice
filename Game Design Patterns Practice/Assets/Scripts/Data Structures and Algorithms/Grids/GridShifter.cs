using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GridShifter 
{
    public static List<List<int>> ShiftGrid(int[][] grid, int k)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int elements = m*n;
        k = k % elements;
        
        List<List<int>> result = new List<List<int>>();
        
        for(int i = 0; i < m; i++)
        {
            List<int> rows = new List<int>();
            
            for(int j = 0; j < n; j++)
            {
                int index = FindShiftedIndex(i, j, n, k, elements);
                rows.Add(grid[index/n][index%n]);
            }
            
            result.Add(rows);
        }
        
        return result;
    }
    
    private static int FindShiftedIndex(int i, int j, int col, int k, int elements)
    {
        return (i * col + j - k + elements) % elements;
    }
}

