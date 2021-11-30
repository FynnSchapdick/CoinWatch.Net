using System.Text.Json.Serialization;
using CoinWatch.Net.Models;

namespace CoinWatch.Net.Serialisation;

[JsonSerializable(typeof(Credit))]
[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
public partial class CreditJsonContext : JsonSerializerContext
{
}