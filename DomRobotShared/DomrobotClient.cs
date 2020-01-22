using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DomRobot
{
    public class DomrobotClient : HttpClient
    {
        private HttpClientHandler _handler;
        private string _apiUrl;
        public DomrobotClient(string apiUrl, Account.Login.Parameters loginParameters) : this(apiUrl, loginParameters, new HttpClientHandler()) { }
        public DomrobotClient(string apiUrl, Account.Login.Parameters loginParameters, HttpClientHandler handler) : base(handler, false)
        {
            _handler = handler;
            _apiUrl = apiUrl;
            Do(loginParameters);
                
        }

        internal DomRobot<ActionType, ResultType>.DomRobotResult Do<ActionType,ResultType>(DomRobot<ActionType,ResultType>.BasicParameters parameters) where ActionType: DomRobot<ActionType,ResultType>, new() where ResultType:IDomrobotResult<ActionType>
        {
            ActionType action = new ActionType(){Parameter = parameters};
            var result = this.PostAsJsonAsync(_apiUrl, action).Result;
#if DEBUG
            var s = result.Content.ReadAsStringAsync().Result;
            var res = Newtonsoft.Json.JsonConvert.DeserializeObject<DomRobot<ActionType, ResultType>.DomRobotResult>(s);
#else
            var res = result.Content.ReadAsAsync<DomRobot<ActionType, ResultType>.DomRobotResult>().Result;
#endif
            if ((int)res.Code < 2000) return res;
            else throw new JsonRpcException<ActionType,ResultType>(res);
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
               Do(new Account.Logout.Parameters());
            }
            catch (JsonRpcException<Account.Logout, Account.Logout.Result> ex)
            {
                if (ex.JsonRpcData.Code != ResultCode.CommandUseError)
                    throw;
                else
                {
                    //we are most likely already logged out
                }
            }
            base.Dispose(disposing);
        }
    }
}
