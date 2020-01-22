using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace DomRobot.Accounting
{
    public class InfoPayment : DomRobot<InfoPayment, InfoPayment.Result>
    {
        public class Parameters : BasicParameters
        {
            [JsonProperty(PropertyName = "id")] public string PaymentId { get; set; }
            [JsonProperty(PropertyName = "typ")] public string PaymentType { get; set; }
        }

        public class Result : IDomrobotResult<InfoPayment>
        {
        }

    }
}
