using System.Text.Json.Serialization;
using CoinWatch.Net.Models;

namespace CoinWatch.Net.Serialisation;

[JsonSerializable(typeof(CoinHistory))]
[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
public partial class CoinHistoryJsonContext : JsonSerializerContext
{
    
}