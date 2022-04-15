using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftAGrid : MonoBehaviour
{
    private int[][] grid = new int[][]
    {
        new int[] {1, 2, 3, 4},
        new int[] {5, 6, 7, 8}
    };

    private void Start()
    {
    }

    [ContextMenu("Shift grid")]
    public void Shift()
    {
        Debug.Log(GridShifter.ShiftGrid(grid, 5));
    }
}
