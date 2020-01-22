using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRobot.Accounting
{
    public class GetInvoice : DomRobot<GetInvoice, GetInvoice.Result>
    {
        public class Parameters : BasicParameters
        {
            [JsonProperty(PropertyName = "invoiceId")] public string PaymentType { get; set; }
        }

        public class Result : IDomrobotResult<GetInvoice>
        {
            [JsonProperty(PropertyName = "pdf")] public string PdfBase64 { get; set; }
        }
    }
}
