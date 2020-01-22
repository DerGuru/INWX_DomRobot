using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRobot.Accounting
{
    public class Refund : DomRobot<Refund, Refund.Result>
    {
        public class Parameters : BasicParameters
        {
            [JsonProperty(PropertyName = "type")] public String RefundType { get; } = "BANKTRANSFER";
            [JsonProperty(PropertyName = "amount")] public string Amount { get; set; }
            [JsonProperty(PropertyName = "accountCC")] public Country.Code AccountCountryCode{ get; set; }
            [JsonProperty(PropertyName = "accountHolder")] public string AccountHolder { get; set; }
            [JsonProperty(PropertyName = "accountNumber", NullValueHandling = NullValueHandling.Ignore)] public string AccountNumber { get; set; }
            [JsonProperty(PropertyName = "bankCode", NullValueHandling = NullValueHandling.Ignore)] public string BankCode { get; set; }
            [JsonProperty(PropertyName = "accountIBAN", NullValueHandling = NullValueHandling.Ignore)] public string AccountIBAN { get; set; }
            [JsonProperty(PropertyName = "SWIFT-BIC", NullValueHandling = NullValueHandling.Ignore)] public string SWIFT_BIC { get; set; }
        }

        public class Result : IDomrobotResult<Refund>
        {
        }
    }
}
