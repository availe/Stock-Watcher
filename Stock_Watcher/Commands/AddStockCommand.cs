using Stock_Watcher.Models;

namespace Stock_Watcher.Commands;

public class AddStockCommand(Watchlist watchlist, string ticker) : ICommand
{
    public bool Execute()
    {
        return watchlist.AddStock(ticker);
    }

    public void Undo()
    {
        watchlist.RemoveStock(ticker);
    }
}