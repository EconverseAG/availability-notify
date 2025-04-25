using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvailabilityNotify.Models
{
    public class MasterdataResponse
    {
        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("Href")]
        public string Href { get; set; }
        [JsonProperty("DocumentId")]
        public string DocumentId { get; set; }
    }
}
