using CoinWatch.Net.Enums;

namespace CoinWatch.Net.Models
{
    public class SingleCoinHistoryParams
    {
        public string Currency { get; set; }
    
        public string Code { get; set; }
    
        public long Start { get; set; }
    
        public long End { get; set; }

        public SingleCoinHistoryParams(Currency currency, Code code, DateTime start, DateTime end)
        {
            Currency = currency.ToString();
            Code = code.ToString();
            Start = (long)start.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
            End = (long)end.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
        }
    }
}