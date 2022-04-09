using UnityEngine;
using UnityEngine.UI;

public class InputManagerTurnBased : MonoBehaviour
{
    [SerializeField] private Button up, down, left, right, doTurn, undo;

    [SerializeField] private CharacterMoveTurnBased character;
    [SerializeField] private UICommandList uiCommandList;
    [SerializeField] private CharacterMoveUndo characterUndo;

    private void OnEnable()
    {
        up?.onClick.AddListener(() => SendMoveCommand(character.transform, Vector3.forward, 1f));
        down?.onClick.AddListener(() => SendMoveCommand(character.transform, Vector3.back, 1f));
        left?.onClick.AddListener(() => SendMoveCommand(character.transform, Vector3.left, 1f));
        right?.onClick.AddListener(() => SendMoveCommand(character.transform, Vector3.right, 1f));

        doTurn?.onClick.AddListener(() => character.DoMove());
        undo?.onClick.AddListener(() => characterUndo?.UndoCommand());
    }

    private void SendMoveCommand(Transform objectToMove, Vector3 direction, float distance)
    {
        ICommand movement = new Move(objectToMove, direction, distance);
        character?.AddCommand(movement);
        uiCommandList.AddCommand(movement);
    }
}