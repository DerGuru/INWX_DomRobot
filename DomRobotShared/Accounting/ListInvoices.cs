using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace DomRobot.Accounting
{
    public class ListInvoices : DomRobot<ListInvoices, ListInvoices.Result>
    {
        public class Parameters : BasicParameters
        {
            
        }

        public class Result : IDomrobotResult<ListInvoices>
        {
            [JsonProperty(PropertyName = "count")] public int Count{ get; set; }
            [JsonProperty(PropertyName = "invoice")] public Invoice[] Invoices { get; set; }
        }

        public class Invoice
        {
            [JsonProperty(PropertyName = "invoiceId")] public string InvoiceId { get; set; }
            [JsonProperty(PropertyName = "date")] public System.DateTime Date { get; set; }
            [JsonProperty(PropertyName = "type")] public string Type { get; set; }
            [JsonProperty(PropertyName = "afterTax")] public float AfterTax { get; set; }
            [JsonProperty(PropertyName = "preTax")] public float PreTax { get; set; }
        }
    }
}
