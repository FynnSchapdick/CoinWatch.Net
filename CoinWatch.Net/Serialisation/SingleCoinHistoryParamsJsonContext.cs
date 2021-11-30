using System.Text.Json.Serialization;
using CoinWatch.Net.Models;

namespace CoinWatch.Net.Serialisation;

[JsonSerializable(typeof(SingleCoinHistoryParams))]
[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Serialization, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
public partial class SingleCoinHistoryParamsJsonContext : JsonSerializerContext
{
    
}