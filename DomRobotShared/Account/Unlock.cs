using Newtonsoft.Json;

namespace DomRobot.Account
{
    public class Unlock : DomRobot<Unlock, Unlock.Result> 
    {
        public class Parameters : BasicParameters
        {
           
        }

        public class Result : IDomrobotResult<Unlock>
        {
            [JsonProperty(PropertyName = "tan", NullValueHandling = NullValueHandling.Ignore)] public string TransactionNumber { get; set; }
        }
    }
   
}
