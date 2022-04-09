using System.Collections.Generic;
using UnityEngine;

public class UICommandList : MonoBehaviour
{
    [SerializeField] private List<Move> commandList = new List<Move>();

    public void AddCommand(ICommand command)
    {
        commandList.Add(command as Move);
    }
}