using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRobot.Accounting
{
    public class AddPayment : DomRobot<AddPayment, AddPayment.Result>
    {
        public class Parameters : TestableParameters
        {
            [JsonProperty(PropertyName = "total")] public float Total { get; set; }
            [JsonProperty(PropertyName = "typ")] public string PaymentType { get; set; }
            [JsonProperty(PropertyName = "transactionId" ,NullValueHandling = NullValueHandling.Ignore)] public string TransactionId { get; set; }
            [JsonProperty(PropertyName = "urlapprove", NullValueHandling = NullValueHandling.Ignore)] public string UrlToApprove { get; set; }
            [JsonProperty(PropertyName = "urlcancel", NullValueHandling = NullValueHandling.Ignore)] public string UrlToCancel { get; set; }
        }

        public class Result : IDomrobotResult<AddPayment>
        {
        }
    }
}
