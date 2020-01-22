using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DomRobot.Account
{
    public class CreateAccount : DomRobot<CreateAccount, CreateAccount.Result>
    {
        public class Parameters : BasicParameters
        {
            [JsonProperty(PropertyName = "username")] public string Username { get; set; }
            [JsonProperty(PropertyName = "password")] public string Password { get; set; }
            [JsonProperty(PropertyName = "title")] public string Title { get; set; }
            [JsonProperty(PropertyName = "firstname")] public string Firstname { get; set; }
            [JsonProperty(PropertyName = "lastname")] public string Lastname { get; set; }
            [JsonProperty(PropertyName = "org",NullValueHandling =NullValueHandling.Ignore)] public string Organisation { get; set; }
            [JsonProperty(PropertyName = "street")] public string Street { get; set; }
            [JsonProperty(PropertyName = "pc")] public string PostalCode { get; set; }
            [JsonProperty(PropertyName = "city")] public string City { get; set; }
            [JsonProperty(PropertyName = "cc")] [JsonConverter(typeof(StringEnumConverter))] public Country.Code CountryCode { get; set; }
            [JsonProperty(PropertyName = "voice")] public string PhoneNumber { get; set; }
            [JsonProperty(PropertyName = "fax",NullValueHandling = NullValueHandling.Ignore)] public string Faxnumber { get; set; }
            [JsonProperty(PropertyName = "www", NullValueHandling = NullValueHandling.Ignore)] public string WebsiteUrl { get; set; }
            [JsonProperty(PropertyName = "email")] public string Emailaddress { get; set; }

            [JsonProperty(PropertyName = "mailListId", NullValueHandling = NullValueHandling.Ignore)] public int[] MailListId { get; set; }
            [JsonProperty(PropertyName = "language", NullValueHandling = NullValueHandling.Ignore)] public string InterfaceLanguage { get; set; }
            [JsonProperty(PropertyName = "frontend", NullValueHandling = NullValueHandling.Ignore)] public string FrontendUrlForValidationEmail { get; set; }

            [JsonProperty(PropertyName = "defaultImportNS", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(BoolIntConverter))]
            public bool? DefaultImportNameServerOnUpdate { get; set; }


            [JsonProperty(PropertyName = "alreadyVerified", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(BoolIntConverter))]
            public string AlreadyVerified { get; set; }
        }

        public class Result : IDomrobotResult<CreateAccount>
        {
           
        }
    }

}
