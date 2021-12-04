using System.Text.Json.Serialization;
using CoinWatch.Net.Models;

namespace CoinWatch.Net.Serialisation
{
#if (NET6_0 || NET6_0_WINDOWS)
    [JsonSerializable(typeof(CoinHistory))]
    [JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
    public partial class CoinHistoryJsonContext : JsonSerializerContext
    {
    
    }
#endif
}