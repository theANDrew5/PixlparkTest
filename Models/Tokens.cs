using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiClient.Models
{
    public class Tokens
    {
        public string RequestToken { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}