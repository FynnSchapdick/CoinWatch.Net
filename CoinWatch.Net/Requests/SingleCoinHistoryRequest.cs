using System.Text.Json;
using CoinWatch.Net.Enums;
using CoinWatch.Net.Models;
using CoinWatch.Net.Responses;
using CoinWatch.Net.Serialisation;

namespace CoinWatch.Net.Requests
{
    public class SingleCoinHistoryRequest : BaseRequest<SingleCoinHistoryResponse>
    {
        public Currency Currency { get; }

        public Code Code { get; }

        public DateTime Start { get; }

        public DateTime End { get; }

        public SingleCoinHistoryRequest(Currency currency, Code code, DateTime start, DateTime end)
        {
            Currency = currency;
            Code = code;
            Start = start;
            End = end;
            EndpointUrl = "/coins/single/history";
#if (NET6_0 || NET6_0_WINDOWS)
                Params =
 JsonSerializer.Serialize(new SingleCoinHistoryParams(currency, code, start, end), SingleCoinHistoryParamsJsonContext.Default.SingleCoinHistoryParams);
#else
            Params = JsonSerializer.Serialize(new SingleCoinHistoryParams(currency, code, start, end));
#endif
        }
    }
}