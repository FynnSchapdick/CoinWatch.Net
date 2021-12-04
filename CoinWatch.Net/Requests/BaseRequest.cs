using CoinWatch.Net.Interfaces;
using CoinWatch.Net.Responses;

namespace CoinWatch.Net.Requests
{
    public class BaseRequest<TResponse> : IRequest<BaseResponse> where TResponse : BaseResponse
    {
        public string ApiKey { get; set; }
        public string? EndpointUrl { get; set; }
        public HttpMethod Method { get; set; } = HttpMethod.Post;
        public string Params { get; set; } = String.Empty;
    }
}