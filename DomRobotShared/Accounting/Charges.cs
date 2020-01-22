using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRobot.Accounting
{
    public class Charges : DomRobot<Charges, Charges.Result>
    {
        public class Parameters : BasicParameters
        {
            [JsonProperty(PropertyName = "total")] public float Total { get; set; }
            [JsonProperty(PropertyName = "typ")] public string PaymentType { get; set; }
        }

        public class Result : IDomrobotResult<Charges>
        {
        }
    }
}
