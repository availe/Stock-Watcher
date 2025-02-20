using Stock_Watcher.Models;

namespace Stock_Watcher.Commands;

public class RemoveStockCommand(Watchlist watchlist, string ticker) : ICommand
{
    public bool Execute()
    {
        return watchlist.RemoveStock(ticker);
    }

    public void Undo()
    { 
        watchlist.AddStock(ticker);
    }
}