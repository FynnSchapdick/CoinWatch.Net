using CoinWatch.Net.Responses;

namespace CoinWatch.Net.Requests
{
    public class StatusRequest : BaseRequest<StatusResponse>
    {
        public StatusRequest()
        {
            EndpointUrl = "/status";
        }
    }
}