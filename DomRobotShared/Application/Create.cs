using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRobot.Application
{
    public class Create : DomRobot<Create, Create.Result>
    {
        [JsonProperty(PropertyName = "domain")] public string Domain { get; set; }
        [JsonProperty(PropertyName = "price")] public float? Price { get; set; }
        [JsonProperty(PropertyName = "registrant")] public int Registrant { get; set; }
        [JsonProperty(PropertyName = "admin")] public int AdminContact { get; set; }
        [JsonProperty(PropertyName = "tech")] public int TechnicalContact { get; set; }
        [JsonProperty(PropertyName = "billing")] public string BillingContact { get; set; }
        [JsonProperty(PropertyName = "ns")] public string NameServers { get; set; }
        [JsonProperty(PropertyName = "type", NullValueHandling =NullValueHandling.Ignore)] public string Type { get; set; }
        [JsonProperty(PropertyName = "extData", NullValueHandling = NullValueHandling.Ignore)] public ExtDataApplication ExtraData { get; set; }
        public class Result : IDomrobotResult<Create>
        {
            [JsonProperty(PropertyName = "roId")] public int RoId { get; set; }
        }
    }
}
