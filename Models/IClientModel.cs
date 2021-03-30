using System.Collections.Generic;

namespace ApiClient.Models
{
    public interface IClientModel
    {
        Tokens LogIn(string url, string public_key, string private_key);

        List<Order> GetOrders(string url, Tokens tokens);
    }
}