using CoinWatch.Net.Models;

namespace CoinWatch.Net.Responses;

public class SingleCoinHistoryResponse : BaseResponse
{
    public SingleCoinHistory SingleCoinHistory { get; }
    public SingleCoinHistoryResponse(SingleCoinHistory singleCoinHistory)
    {
        SingleCoinHistory = singleCoinHistory;
    }

    public SingleCoinHistoryResponse()
    {
    }
}