using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRobot.Accounting
{
    public class SendByPost : DomRobot<SendByPost, SendByPost.Result>
    {
        public class Parameters : TestableParameters
        {
            [JsonProperty(PropertyName = "invoiceId")] public String InvoiceId { get; set; } 
            [JsonProperty(PropertyName = "acceptCosts", NullValueHandling = NullValueHandling.Ignore)] public bool? AcceptCosts { get; set; }
            [JsonProperty(PropertyName = "sendTwice", NullValueHandling = NullValueHandling.Ignore)] public bool? SendTwice { get; set; }
           
        }

        public class Result : IDomrobotResult<SendByPost>
        {
        }
    }
}
