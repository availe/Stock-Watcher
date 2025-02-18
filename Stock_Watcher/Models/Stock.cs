namespace Stock_Watcher;

public class Stock
{
    private readonly string _ticker;
    private readonly string _name;
    private decimal _currentPrice;

    public Stock(string ticker)
    {
        _ticker = ticker.Trim().ToUpper();
        _name = "";
        _currentPrice = 0;
    }
}