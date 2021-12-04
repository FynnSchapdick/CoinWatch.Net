
using CoinWatch.Net.Responses;

namespace CoinWatch.Net.Requests
{
    public class CreditRequest : BaseRequest<CreditResponse>
    {
        public CreditRequest()
        {
            EndpointUrl = "/credits";
        }
    }
}