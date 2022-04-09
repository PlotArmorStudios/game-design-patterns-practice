using UnityEditor;

public interface ICommand
{
    void Execute();

    void Undo();
}