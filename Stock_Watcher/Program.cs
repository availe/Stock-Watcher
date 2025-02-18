using Stock_Watcher.Models;

namespace Stock_Watcher;

class Program {
    private static void Main()
    {
        Watchlist watchlist = Watchlist.Instance;

        Console.WriteLine(
            "Stock Watchlist Menu:\n" +
            "1) Add a stock\n" +
            "2) Remove a stock\n" +
            "3) View watchlist\n" +
            "4) Exit program\n");
        
        string userInput;
        do
        {
            Console.WriteLine("Enter stock ticker: ");
            string stockTicker = Console.ReadLine();

            Console.WriteLine("Do you wish to add another stock?: ");
            userInput = Console.ReadLine();

        } while (userInput == "Yes");
    }
}