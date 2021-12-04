namespace CoinWatch.Net.Models
{
    public class Credit
    {
        public int DailyCreditsLimit { get; set; } = default!;

        public int DailyCreditsRemaining { get; set; } = default!;
    }
}