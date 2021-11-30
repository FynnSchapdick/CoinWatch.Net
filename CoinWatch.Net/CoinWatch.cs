using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using CoinWatch.Net.Extensions;
using CoinWatch.Net.Models;
using CoinWatch.Net.Requests;
using CoinWatch.Net.Responses;
using CoinWatch.Net.Serialisation;

namespace CoinWatch.Net;

public class CoinWatch
{
    private readonly string _apiKey;
    private readonly HttpClient _client;
    private readonly Uri _baseUri;

    public CoinWatch(string apiKey, HttpClient client)
    {
        _apiKey = apiKey;
        _baseUri = new Uri("https://api.livecoinwatch.com");
        _client = client;
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public async Task<TResponse?> SendRequestAsync<TRequest, TResponse>(TRequest request)
        where TResponse : BaseResponse, new() where TRequest : BaseRequest<TResponse>
    {
        TResponse? response = new TResponse();
        HttpResponseMessage result;
        string content;
        
        request.ApiKey = _apiKey;

        using HttpRequestMessage message = new HttpRequestMessage { Method = request.Method };

        switch (request)
        {
            case StatusRequest statusRequest:
                message.RequestUri = _baseUri.AddUriEndpoint(request?.EndpointUrl);
                message.Content = new StringContent(statusRequest.Params, Encoding.UTF8, "application/json");
                result = await _client.SendAsync(message);
                response.StatusCode = result.StatusCode;
                break;
            
            case CreditRequest creditRequest:
                message.RequestUri = _baseUri.AddUriEndpoint(request?.EndpointUrl);
                message.Content = new StringContent(creditRequest.Params, Encoding.UTF8, "application/json");
                message.Content.Headers.Add("x-api-key", new []{ creditRequest.ApiKey });
                result = await _client.SendAsync(message);
                content = await result.Content.ReadAsStringAsync();
                Credit? credit = JsonSerializer.Deserialize(content, CreditJsonContext.Default.Credit) as Credit;
                response = new CreditResponse(credit) as TResponse;
                response.StatusCode = result.StatusCode;
                break;
            
            case SingleCoinHistoryRequest singleCoinHistoryRequest:
                message.RequestUri = _baseUri.AddUriEndpoint(request?.EndpointUrl);
                message.Content = new StringContent(singleCoinHistoryRequest.Params, Encoding.UTF8, "application/json");
                message.Content.Headers.Add("x-api-key", new []{ singleCoinHistoryRequest.ApiKey });
                result = await _client.SendAsync(message);
                content = await result.Content.ReadAsStringAsync();
                SingleCoinHistory? singleCoinHistory = JsonSerializer.Deserialize(content, SingleCoinHistoryJsonContext.Default.SingleCoinHistory) as SingleCoinHistory;
                response = new SingleCoinHistoryResponse(singleCoinHistory) as TResponse;
                response.StatusCode = result.StatusCode;
                break;
        }

        return response;
    }
}