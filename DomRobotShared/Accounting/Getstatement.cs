using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace DomRobot.Accounting
{
    public class GetStatement : DomRobot<GetStatement, GetStatement.Result>
    {
        public class Parameters : BasicParameters
        {
            [JsonProperty(PropertyName = "dateFrom")] public System.DateTime DateFrom { get; set; }
            [JsonProperty(PropertyName = "dateTo")] public System.DateTime DateTo { get; set; }
            [JsonProperty(PropertyName = "format", NullValueHandling = NullValueHandling.Ignore)][JsonConverter(typeof(StringEnumConverter))] public DocumentFormat Format { get; set; }
            [JsonProperty(PropertyName = "page", NullValueHandling = NullValueHandling.Ignore)] public int Page { get; set; }
            [JsonProperty(PropertyName = "pagelimit", NullValueHandling = NullValueHandling.Ignore)] public int PageLimit { get; set; }
        }

        public class Result : IDomrobotResult<GetStatement>
        {
            [JsonProperty(PropertyName = "log")] public LogEntry[] Log { get; set; }
            [JsonProperty(PropertyName = "pdf")] public string PdfBase64 { get; set; }
        }
    }
}
