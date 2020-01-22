using Newtonsoft.Json;

namespace DomRobot.NameServer
{
    public class CreateRecord : DomRobot<CreateRecord, CreateRecord.Result>
    {
        public class Parameters : TestableParameters
        {
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domain")] public string DomainName { get; set; }
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roId")] public int? DnsDomainIdentifier { get; set; }
            [JsonProperty(PropertyName = "type")] [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))] public DnsRecordType RecordType{ get; set; }
            [JsonProperty(PropertyName = "content")] public string Content { get; set; }
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")] public string RecordName { get; set; }
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ttl")] public int? TimeToLive { get; set; }
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prio")] public int? Priority { get; set; }
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "urlRedirectType")] [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))] public UrlRedirectType? UrlRedirectType { get; set; }
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "urlRedirectTitle")] public string UrlRedirectTitle { get; set; }
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "urlRedirectDescription")] public string UrlRedirectDescription { get; set; }
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "urlRedirectFavIcon")] public string UrlRedirectFavIcon { get; set; }
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "urlRedirectKeywords")] public string UrlRedirectKeywords { get; set; }
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "urlAppend")] public bool? UrlAppend { get; set; }
        }
        public class Result : IDomrobotResult<CreateRecord>
        {
            [JsonProperty(PropertyName = "id")] public ulong RecordIdentifier{ get; set; }
        }
    }
    
}
