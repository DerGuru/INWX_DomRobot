using DomRobot;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace DomRobotPre
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Execute DOMAIN RECORDNAME VALUE (ZONE)
            if (args.Length < 3) return;
            var domain = args[0].TrimStart('*','.');
            var recordName = args[1];
            var recordvalue = args[2];

            using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CurrentRecords.cfg"),true))
            {
                var loginParameters = new DomRobot.Account.Login.Parameters { Username = "USERNAME", Password = "PASSWORD" };
                using (DomrobotClient drc = new DomrobotClient("https://api.domrobot.com/jsonrpc/", loginParameters))
                {
                    var res =
                        DomRobot.NameServer.CreateRecord.Execute(drc,
                            new DomRobot.NameServer.CreateRecord.Parameters
                            {
                                DomainName = domain,
                                RecordName = recordName,
                                Content = recordvalue,
                                RecordType = DnsRecordType.TXT
                            });
                    sw.WriteLine(res.Result.RecordIdentifier);
                }
                sw.Flush();
            }
        }
    }
}
