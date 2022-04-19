using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GridShifter 
{
    public static List<List<int>> ShiftGrid(int[][] grid, int k)
    {
        int numRows = grid.Length;
        int numColumns = grid[0].Length;
        int elements = numRows*numColumns;
        k = k % elements;
        
        List<List<int>> result = new List<List<int>>();
        
        for(int i = 0; i < numRows; i++)
        {
            List<int> rows = new List<int>();
            
            for(int j = 0; j < numColumns; j++)
            {
                int index = FindShiftedIndex(i, j, numColumns, k, elements);
                rows.Add(grid[index/numColumns][index%numColumns]);
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

