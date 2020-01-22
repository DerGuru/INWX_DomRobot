using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DomRobot
{
    public class Contact
    {
        [JsonProperty(PropertyName = "roId")] public int RoId { get; set; }
        [JsonProperty(PropertyName = "id")] public string Id { get; set; }
        [JsonProperty(PropertyName = "type")] [JsonConverter(typeof(StringEnumConverter))]public ContactType ContactType { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "org")] public string Organisation { get; set; }
        [JsonProperty(PropertyName = "street")] public string Street { get; set; }
        [JsonProperty(PropertyName = "city")] public string City { get; set; }
        [JsonProperty(PropertyName = "pc")] public string PostalCode { get; set; }
        [JsonProperty(PropertyName = "sp")] public string StateProvince { get; set; }
        [JsonProperty(PropertyName = "cc")] public Country.Code Country { get; set; }
        [JsonProperty(PropertyName = "voice")] public string Phone { get; set; }
        [JsonProperty(PropertyName = "fax")] public string Fax { get; set; }
        [JsonProperty(PropertyName = "email")] public string EmailAddress { get; set; }
        [JsonProperty(PropertyName = "remarks")] public string Remarks { get; set; }
        [JsonProperty(PropertyName = "protection")] [JsonConverter(typeof(BoolIntConverter))] public bool Protection { get; set; }
    }

    public enum ContactType
    {
        ORG,PERSON,ROLE
    }
}
