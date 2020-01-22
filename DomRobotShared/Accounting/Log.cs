using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace DomRobot.Accounting
{
    public class Log : DomRobot<Log, Log.Result>
    {
        public class Parameters : BasicParameters
        {
            [JsonProperty(PropertyName = "dateFrom")] public System.DateTime DateFrom { get; set; }
            [JsonProperty(PropertyName = "dateTo")] public System.DateTime DateTo { get; set; }
            [JsonProperty(PropertyName = "priceMin", NullValueHandling = NullValueHandling.Ignore)] public float? PriceMin { get; set; }
            [JsonProperty(PropertyName = "priceMax", NullValueHandling = NullValueHandling.Ignore)] public float? PriceMax { get; set; }
            [JsonProperty(PropertyName = "page", NullValueHandling = NullValueHandling.Ignore)] public int Page { get; set; }
            [JsonProperty(PropertyName = "pagelimit", NullValueHandling = NullValueHandling.Ignore)] public int PageLimit { get; set; }
        }

        public class Result : IDomrobotResult<Log>
        {
            [JsonProperty(PropertyName = "count")] public int Count { get; set; }
            [JsonProperty(PropertyName = "sum")] public float Sum { get; set; }
            [JsonProperty(PropertyName = "log")] public LogEntry[] Log { get; set; }
        }
    }
}
