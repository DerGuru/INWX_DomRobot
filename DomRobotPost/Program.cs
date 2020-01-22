using DomRobot;
using System;
using System.IO;

namespace DomRobotPost
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            using (StreamReader sw = new StreamReader(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CurrentRecords.cfg")))
            {
                var loginParameters = new DomRobot.Account.Login.Parameters { Username = "USERNAME", Password = "PASSWORD" };
                using (DomrobotClient drc = new DomrobotClient("https://api.domrobot.com/jsonrpc/", loginParameters))
                {
                    while (!sw.EndOfStream)
                    {
                        ulong recId = ulong.Parse(sw.ReadLine());
                        var res =
                        DomRobot.NameServer.DeleteRecord.Execute(drc,
                            new DomRobot.NameServer.DeleteRecord.Parameters
                            {
                                RecordId = recId
                            });
                    }
                }
            }
            File.Delete("CurrentRecords.cfg");
        }
    }
}
