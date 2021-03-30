using Newtonsoft.Json;

namespace ApiClient.Models
{
    public class Order
    {
            //        <td>ID</td>
            //<td>Имя</td>
            //<td>Статус</td>
            //<td>Тип доставки</td>
            //<td>Город</td>
            //<td>Адресс</td>
        [JsonProperty ("Id")]
        public int Id { get; set; }

        [JsonProperty("Title")]
        public string Name { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("ShippingType")]
        public string Shipping_type { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("AddressLine1")]
        public string Adress { get; set; }

    }
}