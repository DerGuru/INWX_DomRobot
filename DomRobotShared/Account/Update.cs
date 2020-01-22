using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DomRobot.Account
{
    public class Update : DomRobot<Update, Update.Result>
    {
        public class Parameters : TestableParameters
        {
            [JsonProperty(PropertyName = "username", NullValueHandling = NullValueHandling.Ignore)] public string Username { get; set; }
            [JsonProperty(PropertyName = "password", NullValueHandling = NullValueHandling.Ignore)] public string Password { get; set; }
            [JsonProperty(PropertyName = "title", NullValueHandling = NullValueHandling.Ignore)] public string SalutationTitle { get; set; }
            [JsonProperty(PropertyName = "firstname", NullValueHandling = NullValueHandling.Ignore)] public string CustomersFirstname { get; set; }
            [JsonProperty(PropertyName = "lastname", NullValueHandling = NullValueHandling.Ignore)] public string CustomersLastname { get; set; }
            [JsonProperty(PropertyName = "org", NullValueHandling = NullValueHandling.Ignore)] public string CustomersOrganisation { get; set; }
            [JsonProperty(PropertyName = "street", NullValueHandling = NullValueHandling.Ignore)] public string CustomersStreet { get; set; }
            [JsonProperty(PropertyName = "pc", NullValueHandling = NullValueHandling.Ignore)] public string CustomersPostalCode { get; set; }
            [JsonProperty(PropertyName = "city", NullValueHandling = NullValueHandling.Ignore)] public string CustomersCity { get; set; }
            [JsonProperty(PropertyName = "cc", NullValueHandling = NullValueHandling.Ignore)] [JsonConverter(typeof(StringEnumConverter))] public Country.Code CustomersCountry { get; set; }
            [JsonProperty(PropertyName = "voice", NullValueHandling = NullValueHandling.Ignore)] public string CustomersPhoneNumber { get; set; }
            [JsonProperty(PropertyName = "fax", NullValueHandling = NullValueHandling.Ignore)] public string CustomersFaxNumber { get; set; }
            [JsonProperty(PropertyName = "www", NullValueHandling = NullValueHandling.Ignore)] public string CustomersWebAddress { get; set; }
            [JsonProperty(PropertyName = "email", NullValueHandling = NullValueHandling.Ignore)] public string CustomersEmailAddress { get; set; }
            [JsonProperty(PropertyName = "servicePin", NullValueHandling = NullValueHandling.Ignore)] public int CustomersServicePin { get; set; }
            [JsonProperty(PropertyName = "summaryInvoice", NullValueHandling = NullValueHandling.Ignore)] [JsonConverter(typeof(BoolIntConverter))] public bool CustomerGetsSummaryInvoice { get; set; }
            [JsonProperty(PropertyName = "mailListId", NullValueHandling = NullValueHandling.Ignore)] public int[] ListOfSubscribedMailListIds { get; set; }
            [JsonProperty(PropertyName = "language", NullValueHandling = NullValueHandling.Ignore)] [JsonConverter(typeof(StringEnumConverter))] public LanguageCode CustomersLanguage { get; set; }
            [JsonProperty(PropertyName = "notificationEmail", NullValueHandling = NullValueHandling.Ignore)] [JsonConverter(typeof(BoolIntConverter))] public bool CustomerGetsNotificationEmails { get; set; }
            [JsonProperty(PropertyName = "notificationQueue", NullValueHandling = NullValueHandling.Ignore)] [JsonConverter(typeof(BoolIntConverter))] public bool CustomerUsesNotificationQueue { get; set; }
            [JsonProperty(PropertyName = "lowBalance", NullValueHandling = NullValueHandling.Ignore)] public float CustomersLowBalanceNotificationValue { get; set; }
            [JsonProperty(PropertyName = "bankAccHolder", NullValueHandling = NullValueHandling.Ignore)] public string CustomersNameOfBankAccountHolder { get; set; }
            [JsonProperty(PropertyName = "bankName", NullValueHandling = NullValueHandling.Ignore)] public string CustomersNameOfBank { get; set; }
            [JsonProperty(PropertyName = "bankCode", NullValueHandling = NullValueHandling.Ignore)] public string CustomersBankCode { get; set; }
            [JsonProperty(PropertyName = "bankAccHolderNo", NullValueHandling = NullValueHandling.Ignore)] public string CustomersBankAccountNumber { get; set; }
            [JsonProperty(PropertyName = "vatNo", NullValueHandling = NullValueHandling.Ignore)] public string CustomersCompanyVatNumber { get; set; }
            [JsonProperty(PropertyName = "whoisProvider", NullValueHandling = NullValueHandling.Ignore)] public string DefaultWhoisProvider { get; set; }
            [JsonProperty(PropertyName = "whoisUrl", NullValueHandling = NullValueHandling.Ignore)] public string DefaultWhoisUrl { get; set; }
            [JsonProperty(PropertyName = "defaultRegistrant", NullValueHandling = NullValueHandling.Ignore)] public int DefaultRegistrantContactHandle { get; set; }
            [JsonProperty(PropertyName = "defaultAdmin", NullValueHandling = NullValueHandling.Ignore)] public int DefaultAdministrativeContactHandle { get; set; }
            [JsonProperty(PropertyName = "defaultTech", NullValueHandling = NullValueHandling.Ignore)] public int DefaultTechnicalContactHandle { get; set; }
            [JsonProperty(PropertyName = "defaultBilling", NullValueHandling = NullValueHandling.Ignore)] public int DefaultBillingContactHandle { get; set; }
            [JsonProperty(PropertyName = "defaultNsset", NullValueHandling = NullValueHandling.Ignore)] public int DefaultNameserverSet { get; set; }
            [JsonProperty(PropertyName = "defaultWeb", NullValueHandling = NullValueHandling.Ignore)] public string DefaultWebNameserverEntry { get; set; }
            [JsonProperty(PropertyName = "defaultMail", NullValueHandling = NullValueHandling.Ignore)] public string DefaultMailNameserverEntry { get; set; }
            [JsonProperty(PropertyName = "defaultImportNS", NullValueHandling = NullValueHandling.Ignore)] [JsonConverter(typeof(BoolIntConverter))] public bool ImportNSInCaseOfDomainTransfer { get; set; }
            [JsonProperty(PropertyName = "rowsPerPage", NullValueHandling = NullValueHandling.Ignore)] public int DefaultRowsPerPage { get; set; }
            [JsonProperty(PropertyName = "emailBilling", NullValueHandling = NullValueHandling.Ignore)] public string CustomersEmailAddressForBilling { get; set; }
            [JsonProperty(PropertyName = "emailAutomated", NullValueHandling = NullValueHandling.Ignore)] public string EmailAddressForAutomatedEmails { get; set; }
            [JsonProperty(PropertyName = "isReseller", NullValueHandling = NullValueHandling.Ignore)] [JsonConverter(typeof(BoolIntConverter))] public bool IsReseller { get; set; }
            [JsonProperty(PropertyName = "supplimentInvoiceText", NullValueHandling = NullValueHandling.Ignore)] public string SupplimentTextToTheInvoice { get; set; }
        }

        public class Result : IDomrobotResult<Update>
        {
           
        }
    }

}
