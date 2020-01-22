using Newtonsoft.Json;


namespace DomRobot
{
    public class DateTimeOffset
    {
        [JsonProperty(PropertyName = "scalar")] public System.DateTimeOffset AsDateTimeOffset { get; set; }
        [JsonProperty(PropertyName = "xmlrpc_type")] public DateTimeOffset xmlrpc_type { get; set; }
        [JsonProperty(PropertyName = "timestamp")] public DateTimeOffset timestamp { get; set; }

        public override string ToString()
        {
            return AsDateTimeOffset.ToString("s");
        }

        public static implicit operator System.DateTimeOffset (DateTimeOffset dtr)
        {
            return dtr.AsDateTimeOffset;
        }
    }
}
