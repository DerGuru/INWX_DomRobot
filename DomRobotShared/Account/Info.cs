using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DomRobot.Account
{
    public class Info  : DomRobot<Info, Info.Result> 
    {
        public class Parameters : BasicParameters
        {
        }

        public class Result : IDomrobotResult<Info>
        {
            [JsonProperty(PropertyName = "accountId")] public int AccountId { get; set; }
            [JsonProperty(PropertyName = "customerId")] public int CustomerId { get; set; }
            [JsonProperty(PropertyName = "username")] public string Username { get; set; }
            [JsonProperty(PropertyName = "title")] public string SalutationTitle { get; set; }
            [JsonProperty(PropertyName = "firstname")] public string CustomersFirstname { get; set; }
            [JsonProperty(PropertyName = "lastname")] public string CustomersLastname { get; set; }
            [JsonProperty(PropertyName = "org")] public string CustomersOrganisation { get; set; }
            [JsonProperty(PropertyName = "street")] public string CustomersStreet { get; set; }
            [JsonProperty(PropertyName = "pc")] public string CustomersPostalCode { get; set; }
            [JsonProperty(PropertyName = "city")] public string CustomersCity { get; set; }
            [JsonProperty(PropertyName = "cc")] [JsonConverter(typeof(StringEnumConverter))]public Country.Code CustomersCountry { get; set; }
            [JsonProperty(PropertyName = "voice")] public string CustomersPhoneNumber { get; set; }
            [JsonProperty(PropertyName = "fax")] public string CustomersFaxNumber { get; set; }
            [JsonProperty(PropertyName = "www")] public string CustomersWebAddress { get; set; }
            [JsonProperty(PropertyName = "email")] public string CustomersEmailAddress { get; set; }
            [JsonProperty(PropertyName = "servicePin")] public int CustomersServicePin { get; set; }
            [JsonProperty(PropertyName = "crDate")] public DateTimeOffset CustomersDateOfAccountCreation { get; set; }
            [JsonProperty(PropertyName = "secureMode")][JsonConverter(typeof(BoolIntConverter))] public bool CustomersSecureMode { get; set; }
            [JsonProperty(PropertyName = "signPdfs")] [JsonConverter(typeof(BoolIntConverter))] public bool CustomerGetsSignedPdfs { get; set; }
            [JsonProperty(PropertyName = "summaryInvoice")] [JsonConverter(typeof(BoolIntConverter))] public bool CustomerGetsSummaryInvoice { get; set; }
            [JsonProperty(PropertyName = "mailListId",NullValueHandling =NullValueHandling.Ignore)] public int[] ListOfSubscribedMailListIds { get; set; }
            [JsonProperty(PropertyName = "language")][JsonConverter(typeof(StringEnumConverter))] public LanguageCode CustomersLanguage { get; set; }
            [JsonProperty(PropertyName = "notificationEmail")] [JsonConverter(typeof(BoolIntConverter))] public bool CustomerGetsNotificationEmails { get; set; }
            [JsonProperty(PropertyName = "notificationQueue")] [JsonConverter(typeof(BoolIntConverter))] public bool CustomerUsesNotificationQueue { get; set; }
            [JsonProperty(PropertyName = "lowBalance")] public float CustomersLowBalanceNotificationValue { get; set; }
            [JsonProperty(PropertyName = "paymentType")] [JsonConverter(typeof(StringEnumConverter))] public PaymentType CustomersTypeOfPayment { get; set; }
            [JsonProperty(PropertyName = "bankAccHolder")] public string CustomersNameOfBankAccountHolder { get; set; }
            [JsonProperty(PropertyName = "bankName")] public string CustomersNameOfBank { get; set; }
            [JsonProperty(PropertyName = "bankCode")] public string CustomersBankCode { get; set; }
            [JsonProperty(PropertyName = "bankAccHolderNo")] public string CustomersBankAccountNumber { get; set; }
            [JsonProperty(PropertyName = "vat")] public float CustomersVat { get; set; }
            [JsonProperty(PropertyName = "vatNo")] public string CustomersCompanyVatNumber { get; set; }
            [JsonProperty(PropertyName = "whoisProvider")] public string DefaultWhoisProvider { get; set; }
            [JsonProperty(PropertyName = "whoisUrl")] public string DefaultWhoisUrl { get; set; }
            [JsonProperty(PropertyName = "defaultRegistrant")] public int DefaultRegistrantContactHandle { get; set; }
            [JsonProperty(PropertyName = "defaultAdmin")] public int DefaultAdministrativeContactHandle { get; set; }
            [JsonProperty(PropertyName = "defaultTech")] public int DefaultTechnicalContactHandle { get; set; }
            [JsonProperty(PropertyName = "defaultBilling")] public int DefaultBillingContactHandle { get; set; }
            [JsonProperty(PropertyName = "defaultNsset")] public int DefaultNameserverSet { get; set; }
            [JsonProperty(PropertyName = "defaultWeb")] public string DefaultWebNameserverEntry { get; set; }
            [JsonProperty(PropertyName = "defaultMail")] public string DefaultMailNameserverEntry { get; set; }
            [JsonProperty(PropertyName = "defaultImportNS")] [JsonConverter(typeof(BoolIntConverter))] public bool ImportNSInCaseOfDomainTransfer { get; set; }
            [JsonProperty(PropertyName = "lastLogin")] public DateTimeOffset DateOfLastLogin { get; set; }
            [JsonProperty(PropertyName = "loginCount")] public int CountOfLogins { get; set; }
            [JsonProperty(PropertyName = "rowsPerPage")] public int DefaultRowsPerPage { get; set; }
            [JsonProperty(PropertyName = "tfa")] public string TwoFactorAuthentificationMethod { get; set; }
            [JsonProperty(PropertyName = "lastIP")] public string CustomersIpAddressOfLastAccess { get; set; }
            [JsonProperty(PropertyName = "verification")] public int CustomersDataVerficationPendingFlag { get; set; }
            [JsonProperty(PropertyName = "emailBilling")] public string CustomersEmailAddressForBilling { get; set; }
            [JsonProperty(PropertyName = "emailAutomated")] public string EmailAddressForAutomatedEmails { get; set; }
            [JsonProperty(PropertyName = "currency")] [JsonConverter(typeof(StringEnumConverter)) ]public Currency Currency { get; set; }
            [JsonProperty(PropertyName = "isReseller")] [JsonConverter(typeof(BoolIntConverter))] public bool IsReseller { get; set; }
            [JsonProperty(PropertyName = "supplimentInvoiceText")] public string SupplimentTextToTheInvoice { get; set; }

        }
    }
   
}
