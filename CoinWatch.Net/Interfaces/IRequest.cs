using CoinWatch.Net.Responses;

namespace CoinWatch.Net.Interfaces;

public interface IRequest<out TResponse> where TResponse : BaseResponse
{
    string ApiKey { set; }
    string? EndpointUrl { get; }
    HttpMethod Method { get; }
    
    public string Params { get; set; }
}