using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace ApiClient.Models
{
    public interface IClientModel
    {
        void LogIn(string url, string public_key, string private_key);
    }
}