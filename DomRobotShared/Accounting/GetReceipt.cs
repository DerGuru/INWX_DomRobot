using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRobot.Accounting
{
    public class GetReceipt : DomRobot<GetReceipt, GetReceipt.Result>
    {
        public class Parameters : BasicParameters
        {
            [JsonProperty(PropertyName = "id")] public int PaymentId{ get; set; }
            [JsonProperty(PropertyName = "amount")] public string Amount { get; set; }
            [JsonProperty(PropertyName = "details")] public string Details{ get; set; }
            [JsonProperty(PropertyName = "date")] public string Date { get; set; }
        }

        public class Result : IDomrobotResult<GetReceipt>
        {
            [JsonProperty(PropertyName = "pdf")] public string PdfBase64 { get; set; }
        }
    }
}
