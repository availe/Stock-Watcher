using System.Collections.Concurrent;

namespace Stock_Watcher.Models;

public class Watchlist
{
    private static readonly Lazy<Watchlist> _instance = new(() => new Watchlist());
    private readonly ConcurrentDictionary<string, Stock> _stocks = new();

    private Watchlist() {}

    public static Watchlist Instance => _instance.Value;

    public bool AddStock(string ticker)
    {
        if (string.IsNullOrWhiteSpace(ticker))
        {
            ArgumentException.ThrowIfNullOrEmpty("Ticker cannot be null or empty.");
        }

        ticker = ticker.Trim().ToUpper();
        return _stocks.TryAdd(ticker, new Stock(ticker));
    }

    public bool RemoveStock(string ticker)
    {
        ticker = ticker.Trim().ToUpper();
        return _stocks.TryRemove(ticker, out _);
    }
}