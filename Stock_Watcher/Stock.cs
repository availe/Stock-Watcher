namespace Stock_Watcher;

public class Stock
{
    private readonly string _ticker;
    private readonly string _name;
    private decimal _currentPrice;

    public Stock(string ticker)
    {
        if (string.IsNullOrWhiteSpace(ticker))
        {
            throw new ArgumentException("Ticker can not be null or empty.");
        }

        _ticker = ticker.Trim().ToUpper();
        _name = "";
        _currentPrice = 0;
    }
}