using System.Text.Json;
using CoinWatch.Net.Enums;
using CoinWatch.Net.Models;
using CoinWatch.Net.Responses;
using CoinWatch.Net.Serialisation;

namespace CoinWatch.Net.Requests;

public class SingleCoinHistoryRequest : BaseRequest<SingleCoinHistoryResponse>
{
    public SingleCoinHistoryRequest(Currency currency, Code code, DateTime start, DateTime end)
    {
        EndpointUrl = "/coins/single/history";
        Params = JsonSerializer.Serialize(new SingleCoinHistoryParams(currency, code, start, end), SingleCoinHistoryParamsJsonContext.Default.SingleCoinHistoryParams);
    }
}