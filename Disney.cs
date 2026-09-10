using System.Text.Json.Serialization;

namespace ConsumerDisneyApi.Models;

public class DisneyResponse
{
    [JsonPropertyName("info")]
    public InfoDisney? Info { get; set; }

    [JsonPropertyName("data")]
    public DataDisney? Data { get; set; }
}

public class InfoDisney
{
    [JsonPropertyName ("count")]
    public int? count { get; set;}
}

public class DataDisney
{
    [JsonPropertyName ("_id")]
    public int? _id { get; set;}

    [JsonPropertyName ("name")]
    public string? name { get; set;}

    [JsonPropertyName ("imageUrl")]
    public string? imageUrl { get; set;}
}