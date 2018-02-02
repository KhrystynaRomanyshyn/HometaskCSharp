using System.Collections.Generic;
using Newtonsoft.Json;

namespace WebServicesTests.Structures
{
    public class UpdateCollectionRequest
    {
        [JsonProperty("collection")]
        public UpdateCollection Collection { get; set; }
    }

    public class UpdateCollection
    {
        [JsonProperty("info")]
        public UpdateInfo Info { get; set; }

        [JsonProperty("item")]
        public List<Item> Item { get; set; }
    }

    public class UpdateInfo : Info
    {
        [JsonProperty("_postman_id")]
        public string PostmanId { get; set; }
    }
}