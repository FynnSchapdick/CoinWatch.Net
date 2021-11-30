namespace CoinWatch.Net.Models;

public class CoinHistory
{
    public long Date { get; set; }
    
    public decimal Rate { get; set; }
    
    public decimal Volume { get; set; }
    
    public decimal Cap { get; set; }
}