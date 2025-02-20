namespace Stock_Watcher.Commands;

public class CommandInvoker
{
    private static readonly Lazy<CommandInvoker> _instance = new(() => new CommandInvoker());
    private readonly Stack<ICommand> _commandHistory = new();

    private CommandInvoker() { }
    public static CommandInvoker Instance => _instance.Value;

    public void ExecuteCommand(ICommand command)
    {
        if (command.Execute())
        {
            _commandHistory.Push(command);
        }
    }

    public void UndoLastCommand()
    {
        if (_commandHistory.Count <= 0) return;
        ICommand lastCommand = _commandHistory.Pop();
        lastCommand.Undo();
    }
}