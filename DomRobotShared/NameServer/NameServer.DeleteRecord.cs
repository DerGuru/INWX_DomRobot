using Newtonsoft.Json;

namespace DomRobot.NameServer
{
    public class DeleteRecord : DomRobot<DeleteRecord, DeleteRecord.Result>
    {
        public class Parameters : TestableParameters
        {
            [JsonProperty(PropertyName = "id")] public ulong RecordId { get; set; }
        }
        public class Result : IDomrobotResult<DeleteRecord>
        {
        }
    }
    
}
