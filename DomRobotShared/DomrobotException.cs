using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomRobot
{
    public class JsonRpcException<ActionType, ResultType> : Exception where ActionType : DomRobot<ActionType,ResultType>, new() where ResultType : IDomrobotResult<ActionType>
    {
        public DomRobot<ActionType, ResultType>.DomRobotResult JsonRpcData { get; private set; }

        public JsonRpcException(DomRobot<ActionType, ResultType>.DomRobotResult data) : base(data.Message)
        {
            JsonRpcData = data;
        }

        public JsonRpcException(string message) : base(message)
        {
        }

        public JsonRpcException(string message, DomRobot<ActionType, ResultType>.DomRobotResult data) : base(message)
        {
            JsonRpcData = data;
        }

        public JsonRpcException(string message, Exception innerException) : base(message, innerException)
        {
        }
        public JsonRpcException(string message, Exception innerException, DomRobot<ActionType, ResultType>.DomRobotResult data) : base(message, innerException)
        {
            JsonRpcData = data;
        }
    }
}
