using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRobot
{
    public class ExtDataApplication
    {
        [JsonProperty(PropertyName = "ORIGINAL-NAME", NullValueHandling = NullValueHandling.Ignore)] public string OriginalName { get; set; }
        [JsonProperty(PropertyName = "ACCEPT-TRUSTEE-TAC", NullValueHandling = NullValueHandling.Ignore)] [JsonConverter(typeof(BoolIntConverter))] public bool? AcceptTrusteeTac { get; set; }
        [JsonProperty(PropertyName = "BIRTH-DATE", NullValueHandling = NullValueHandling.Ignore)] public DateTime BirthDate { get; set; }
        [JsonProperty(PropertyName = "BIRTH-CITY", NullValueHandling = NullValueHandling.Ignore)] public string BirthCity { get; set; }
        [JsonProperty(PropertyName = "BIRTH-COUNTRY", NullValueHandling = NullValueHandling.Ignore)] public string BirthCountry { get; set; }
        [JsonProperty(PropertyName = "BIRTH-PC", NullValueHandling = NullValueHandling.Ignore)] public string BirthPostalCode { get; set; }

    }
}
