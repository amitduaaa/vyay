namespace Dvinci.VYAY.DataModel.Subscription;

public class SubscriptionItem : BaseEntity
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    [JsonPropertyName("price")]
    public decimal? Price { get; set; }
    [JsonPropertyName("cycle")]
    public SubscriptionCycle? Cycle { get; set; }
    [JsonPropertyName("category")]
    public string? Category { get; set; }
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }
    [JsonPropertyName("date")]
    public DateOnly Date { get; set; }

    public DateTimeOffset CreationDate { get; set; }
    public DateTimeOffset UpdationDate { get; set; }
}

public enum SubscriptionCycle
{
    Monthly,
    Yearly
}
