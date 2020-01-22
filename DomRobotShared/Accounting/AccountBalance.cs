using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRobot.Accounting
{
    public class AccountBalance : DomRobot<AccountBalance, AccountBalance.Result>
    {
        public class Parameters : BasicParameters
        {

        }

        public class Result : IDomrobotResult<AccountBalance>
        {
            [JsonProperty(PropertyName = "total")] public float Total { get; set; }
            [JsonProperty(PropertyName = "available")] public float Available { get; set; }
            [JsonProperty(PropertyName = "locked")] public float Locked { get; set; }
            [JsonProperty(PropertyName = "creditLimit")] public float CreditLimit { get; set; }

        }
    }
}
