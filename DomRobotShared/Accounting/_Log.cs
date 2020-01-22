using Newtonsoft.Json;


namespace DomRobot.Accounting
{
    public class LogEntry
    {
        [JsonProperty(PropertyName = "date")] public DateTimeOffset Date { get; set; }
        [JsonProperty(PropertyName = "amount")] public float Amount { get; set; }
        [JsonProperty(PropertyName = "type")] public string Type { get; set; }
        [JsonProperty(PropertyName = "details")] public string Details { get; set; }
    }
}
