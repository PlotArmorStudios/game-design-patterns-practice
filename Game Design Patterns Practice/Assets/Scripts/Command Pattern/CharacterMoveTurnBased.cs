using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveTurnBased : MonoBehaviour
{
    [SerializeField] private List<Move> commandList = new List<Move>();

    public void AddCommand(ICommand command)
    {
        commandList.Add(command as Move);
    }
   
    public void DoMove()
    {
        StartCoroutine(DoMovesOverTime());
    }

    private IEnumerator DoMovesOverTime()
    {
        foreach (Move move in commandList)
        {
            move.Execute();

            //UpdateLine();
            //index++; //used for path drawing
            yield return new WaitForSeconds(0.5f);
        }
    }

    private void UpdateLine()
    {
        throw new System.NotImplementedException();
    }
}