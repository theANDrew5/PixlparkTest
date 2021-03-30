using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ApiClient.Models
{
    public class OrdersReply
    {
        [JsonProperty("ApiVersion")]
        public string ver { get; set; }

        [JsonProperty("Result")]

        public List<Order> Orders { get; set; }

        [JsonProperty("ResponseCode")]
        public int Code { get; set; }
    }
}