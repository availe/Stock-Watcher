namespace Stock_Watcher.Commands;

public interface ICommand
{
    bool Execute();
    void Undo();
}