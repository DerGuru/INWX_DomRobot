using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace DomRobot
{
    public abstract class DomRobot<ActionType, ResultType> where ActionType : DomRobot<ActionType, ResultType>, new() where ResultType : IDomrobotResult<ActionType>
    {
        [JsonProperty(PropertyName = "method", Order = 0)]
        public string Method => typeof(ActionType).FullName.Replace("DomRobot.", "").ToLowerInvariant();

        [JsonProperty(PropertyName = "params", Order = 1, NullValueHandling = NullValueHandling.Ignore)]
        public BasicParameters Parameter { get; set; }

        public DomRobot() { }

        public DomRobot(BasicParameters parameters) 
        {
            Parameter = parameters;
        }

        public static DomRobotResult Execute(DomrobotClient drc, BasicParameters parameters) 
        { 
            return drc.Do(parameters);
        }

        public class BasicParameters
        {
            [JsonProperty(PropertyName = "lang", NullValueHandling = NullValueHandling.Ignore)] public string Language { get; set; }
            [JsonProperty(PropertyName = "clTRID", NullValueHandling = NullValueHandling.Ignore)] public string ClientTransactionIdentifier { get; set; }
        }

        public class TestableParameters : BasicParameters
        {
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "testing")]
            [JsonConverter(typeof(BoolIntConverter))]
            public bool? AsTest{get;set;}
        }

        public class DomRobotResult 
        {
            [JsonProperty(PropertyName = "code")] public ResultCode Code { get; set; }
            [JsonProperty(PropertyName = "msg")] public string Message { get; set; }
            [JsonProperty(PropertyName = "reasonCode")] public int ReasonCode { get; set; }
            [JsonProperty(PropertyName = "reason")] public String Reason { get; set; }
            [JsonProperty(PropertyName = "resData")] public ResultType Result { get; set; }
            [JsonProperty(PropertyName = "svTRID")] public string ServerTransactionIdentifier { get; set; }
        }
    }
}
