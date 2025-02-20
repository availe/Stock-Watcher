using Stock_Watcher.Models;

namespace Stock_Watcher.Commands;

public class RemoveStockCommand : ICommand
{
    private readonly Watchlist _watchlist;
    private readonly string _ticker;

    public RemoveStockCommand(Watchlist watchlist, string ticker)
    {
        _watchlist = watchlist;
        _ticker = ticker;
    }

    public bool Execute()
    {
        return _watchlist.RemoveStock(_ticker);
    }

    public void Undo()
    { 
        _watchlist.AddStock(_ticker);
    }
}