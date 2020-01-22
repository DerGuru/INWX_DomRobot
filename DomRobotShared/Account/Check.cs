using Newtonsoft.Json;

namespace DomRobot.Account
{
    public class Check  : DomRobot<Check, Check.Result> 
    {
        public class Parameters : BasicParameters
        {
        }

        public class Result :IDomrobotResult<Check>
        {
            [JsonProperty(PropertyName ="user")] public string Username { get; set; }
        }
    }
   
}
