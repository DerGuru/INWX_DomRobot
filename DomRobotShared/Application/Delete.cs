using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace DomRobot.Application
{
    public class Delete : DomRobot<Delete, Delete.Result>
    {
        [JsonProperty(PropertyName = "roId")] public int RoId { get; set; }
        public class Result : IDomrobotResult<Delete>
        {

        }
    }
}
