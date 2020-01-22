﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace DomRobot.Application
{
    public class Info : DomRobot<Info, Info.Result>
    {
        [JsonProperty(PropertyName = "roId")] public int RoId { get; set; }
        [JsonProperty(PropertyName = "wide", NullValueHandling = NullValueHandling.Ignore)] public int? Details{ get; set; }

        public class Result : IDomrobotResult<Info>
        {
            [JsonProperty(PropertyName = "roId")] public int RoId { get; set; }
            [JsonProperty(PropertyName = "domain")] public string Domain { get; set; }
            [JsonProperty(PropertyName = "domain-ace")] public string DomainAce { get; set; }
            [JsonProperty(PropertyName = "type")] public string Type { get; set; }
            [JsonProperty(PropertyName = "crDate", NullValueHandling = NullValueHandling.Ignore)] public DateTime? Created { get; set; }
            [JsonProperty(PropertyName = "upDate", NullValueHandling = NullValueHandling.Ignore)] public DateTime? Updated{ get; set; }
            [JsonProperty(PropertyName = "closedDate", NullValueHandling = NullValueHandling.Ignore)] public DateTime? Details { get; set; }
            [JsonProperty(PropertyName = "extData", NullValueHandling = NullValueHandling.Ignore)] public ExtDataApplication ExtData{ get; set; }
            [JsonProperty(PropertyName = "price", NullValueHandling = NullValueHandling.Ignore)] public float? Price { get; set; }
            [JsonProperty(PropertyName = "status", NullValueHandling = NullValueHandling.Ignore)] public string Status { get; set; }
            [JsonProperty(PropertyName = "registrant", NullValueHandling = NullValueHandling.Ignore)] public int? RegistrantRoId { get; set; }
            [JsonProperty(PropertyName = "admin", NullValueHandling = NullValueHandling.Ignore)] public int? AdminRoId { get; set; }
            [JsonProperty(PropertyName = "tech", NullValueHandling = NullValueHandling.Ignore)] public int? TechnicalContactRoId { get; set; }
            [JsonProperty(PropertyName = "billing", NullValueHandling = NullValueHandling.Ignore)] public int? BillingContactRoId { get; set; }
            [JsonProperty(PropertyName = "ns", NullValueHandling = NullValueHandling.Ignore)] public string NameServers { get; set; }
            [JsonProperty(PropertyName = "appPosition", NullValueHandling = NullValueHandling.Ignore)] public string ApplicationQueuePosition { get; set; }
            [JsonProperty(PropertyName = "appCount", NullValueHandling = NullValueHandling.Ignore)] public int? EquivalentApplicationCount{ get; set; }
            [JsonProperty(PropertyName = "appPrices", NullValueHandling = NullValueHandling.Ignore)] public float[] HighestApplicationPrices { get; set; }
            [JsonProperty(PropertyName = "contact", NullValueHandling = NullValueHandling.Ignore)] public Contacts Contacts { get; set; }
        }

        public class Contacts
        {
            [JsonProperty(PropertyName = "registrant", NullValueHandling = NullValueHandling.Ignore)] public Contact RegistrantRoId { get; set; }
            [JsonProperty(PropertyName = "admin", NullValueHandling = NullValueHandling.Ignore)] public Contact AdminRoId { get; set; }
            [JsonProperty(PropertyName = "tech", NullValueHandling = NullValueHandling.Ignore)] public Contact TechnicalContactRoId { get; set; }
            [JsonProperty(PropertyName = "billing", NullValueHandling = NullValueHandling.Ignore)] public Contact BillingContactRoId { get; set; }

        }
    }
}
