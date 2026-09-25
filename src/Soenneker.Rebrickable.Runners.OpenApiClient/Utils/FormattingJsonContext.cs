using System.Text.Json;
using System.Text.Json.Serialization;

namespace Soenneker.Rebrickable.Runners.OpenApiClient.Utils;

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(JsonDocument))]
internal partial class FormattingJsonContext : JsonSerializerContext;
