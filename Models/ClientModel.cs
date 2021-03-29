using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;


namespace ApiClient.Models
{
    public class ClientModel : IClientModel
    {

        public void LogIn(string url, string public_key, string private_key)
        {
            WebRequest request = WebRequest.Create($"{url}/oauth/requesttoken");
            request.Method = "GET";
            string content;

            WebResponse response = request.GetResponse();

            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    content = reader.ReadToEnd();
                }
            }

            var tokens = JsonConvert.DeserializeObject<Tokens>(content);

            var hash = SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(tokens.RequestToken + private_key));

            request = WebRequest.Create($"{url}/oauth/accesstoken?" +
                $"oauth_token={tokens.RequestToken}&" +
                $"grant_type=api&" +
                $"username={public_key}&" +
                $"password={string.Concat(hash.Select(b => b.ToString("X2")))}");
            request.Method = "GET"; // для отправки используется метод get

            response = request.GetResponse();

            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    content = reader.ReadToEnd();
                }
            }

            tokens = JsonConvert.DeserializeObject<Tokens>(content);
        }
        
    }
}