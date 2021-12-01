using System.Text.Json.Serialization;
using CoinWatch.Net.Models;

namespace CoinWatch.Net.Serialisation;
[JsonSerializable(typeof(SingleCoinHistory))]
[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
public partial class SingleCoinHistoryJsonContext : JsonSerializerContext
{
    
}