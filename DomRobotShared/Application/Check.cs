using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRobot.Application
{
    public class Check : DomRobot<Check, Check.Result>
    {

        [JsonProperty(PropertyName = "domain")] public string Domain { get;set; }
        public class Result : IDomrobotResult<Check>
        {
            [JsonProperty(PropertyName = "domain")] public string Domain { get; set; }
            [JsonProperty(PropertyName = "price")] public float Price { get; set; }
            [JsonProperty(PropertyName = "period")] public int Period { get; set; }
            [JsonProperty(PropertyName = "status")] public string Status { get; set; }
            [JsonProperty(PropertyName = "appCount")] public int AppCount { get; set; }

        }
    }
}
