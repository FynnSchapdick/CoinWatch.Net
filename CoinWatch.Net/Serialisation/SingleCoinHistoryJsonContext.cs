using System.Text.Json.Serialization;
using CoinWatch.Net.Models;

namespace CoinWatch.Net.Serialisation
{
#if (NET6_0 || NET6_0_WINDOWS)
    [JsonSerializable(typeof(SingleCoinHistory))]
    [JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
    public partial class SingleCoinHistoryJsonContext : JsonSerializerContext
    {
    
    }
#endif
}