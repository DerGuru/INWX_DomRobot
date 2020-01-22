using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRobot.Accounting
{
    public class LockedFunds : DomRobot<LockedFunds, LockedFunds.Result>
    {
        public class Parameters : BasicParameters
        {
            [JsonProperty(PropertyName = "dateFrom")] public System.DateTime DateFrom { get; set; } 
            [JsonProperty(PropertyName = "dateTo")] public System.DateTime DateTo { get; set; }
            [JsonProperty(PropertyName = "page", NullValueHandling = NullValueHandling.Ignore)] public int? Page { get; set; }
            [JsonProperty(PropertyName = "pagelimit", NullValueHandling = NullValueHandling.Ignore)] public int? Pagelimit { get; set; }
        }

        public class Result : IDomrobotResult<LockedFunds>
        {
            [JsonProperty(PropertyName = "locked")] public Lock[] Locks { get; set; }
        }

        public class Lock
        {
            [JsonProperty(PropertyName = "date")] public System.DateTime Date { get; set; }
            [JsonProperty(PropertyName = "domain")] public string Domain { get; set; }
            [JsonProperty(PropertyName = "amount")] public float Amount { get; set; }
            [JsonProperty(PropertyName = "status")] public string Status { get; set; }
        }
    }
}
