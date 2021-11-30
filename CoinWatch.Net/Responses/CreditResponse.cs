using CoinWatch.Net.Models;

namespace CoinWatch.Net.Responses;

public class CreditResponse : BaseResponse
{
    public Credit? Credit { get; }
    
    public CreditResponse(Credit? credit)
    {
        Credit = credit;
    }

    public CreditResponse()
    {
    }
}