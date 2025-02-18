namespace Stock_Watcher;

class Program {
    private static void Main()
    {
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