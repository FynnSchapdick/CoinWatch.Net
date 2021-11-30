using System.Net;

namespace CoinWatch.Net.Responses;

public class BaseResponse
{
    public HttpStatusCode StatusCode { get; set; }
}