using Newtonsoft.Json;

namespace DomRobot.Account
{
    public class Login  : DomRobot<Login,Login.Result> 
    {
        public class Parameters : BasicParameters
        {
            [JsonProperty (PropertyName ="user")] public string Username { get; set; }
            [JsonProperty(PropertyName = "pass")] public string Password { get; set; }

        }

        public class Result : IDomrobotResult<Login>
        {
            [JsonProperty(PropertyName = "customerId")] public int CustomerId { get; set; }
            [JsonProperty(PropertyName = "accountId")] public int AccountId { get; set; }
            [JsonProperty(PropertyName = "tfa")] public string TFA { get; set; }
            [JsonProperty(PropertyName = "builddate")] public string BuildDate { get; set; }
            [JsonProperty(PropertyName = "version")] public string Version { get; set; }
        }
    }
   
}
