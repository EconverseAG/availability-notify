using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvailabilityNotify.Models
{
    public class Export
    {
        [JsonProperty("dateRequest")]
        public DateTime DateRequest { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class AttachmentsResponseWrapper
    {
        public string FileName { get; set; }
        public string FileUrl { get; set; }
    }
}
