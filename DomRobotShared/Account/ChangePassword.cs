using Newtonsoft.Json;

namespace DomRobot.Account
{
    public class ChangePassword  : DomRobot<ChangePassword, ChangePassword.Result> 
    {
        public class Parameters : TestableParameters
        {
            [JsonProperty(PropertyName ="username")] public string Username { get; set; }
            [JsonProperty(PropertyName = "currentpassword")] public string CurrentPassword { get; set; }
            [JsonProperty(PropertyName = "password")] public string NewPassword { get; set; }

        }

        public class Result :IDomrobotResult<ChangePassword>
        {
        }
    }
   
}
