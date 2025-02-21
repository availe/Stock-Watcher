using Stock_Watcher.Commands;
using Stock_Watcher.Models;

namespace Stock_Watcher;

class Program {
    private static void Main()
    {
        Watchlist watchlist = Watchlist.Instance;
        CommandInvoker invoker = CommandInvoker.Instance;

        Console.WriteLine(
            "Stock Watchlist Menu:\n" +
            "1) Add a stock\n" +
            "2) Remove a stock\n" +
            "3) View watchlist\n" +
            "4) Undo last action\n" +
            "5) Exit program\n\n");

        while (true)
        {
            Console.Write("Select an action: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Enter stock ticker: ");
                    string addTicker = Console.ReadLine();
                    ICommand addCommand = new AddStockCommand(watchlist, addTicker);
                    invoker.ExecuteCommand(addCommand);
                    Console.WriteLine($"{addTicker} added.");
                    break;
                
                case "2":
                    Console.Write("Enter stock ticker: ");
                    string removeTicker = Console.ReadLine();
                    ICommand removeCommand = new RemoveStockCommand(watchlist, removeTicker);
                    invoker.ExecuteCommand(removeCommand);
                    Console.WriteLine($"{removeTicker} removed.");
                    break;

                case "3":
                    Console.WriteLine("Current Watchlist:");
                    foreach (var stock in watchlist.Stocks)
                    {
                        Console.WriteLine(stock);
                    }

                    break;

                case "4":
                    invoker.UndoLastCommand();
                    Console.WriteLine("Last action undone.");
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}