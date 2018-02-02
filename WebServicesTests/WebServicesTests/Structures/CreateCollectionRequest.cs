using System.Collections.Generic;
using Newtonsoft.Json;

namespace WebServicesTests.Structures
{
    public class CreateCollectionRequest
    {
        [JsonProperty("collection")]
        public CreateCollection Collection { get; set; }
    }

    public class CreateCollection
    {
        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("item")]
        public List<Item> Item { get; set; }
    }

    public class Info
    {
        [JsonProperty("name")]
        public string Name { get; set; } = "Test Collection";

        [JsonProperty("description")]
        public string Description { get; set; } = "Test Collection Description";

        [JsonProperty("schema")]
        public string Schema { get; set; } = "https://schema.getpostman.com/json/collection/v2.1.0/collection.json";
    }

    public class Item
    {
        [JsonProperty("name")]
        public string Name { get; set; } = "New Test Request";

        [JsonProperty("request")]
        public Request Request { get; set; }
    }

    public class Request
    {
        [JsonProperty("url")]
        public string Url { get; set; } = "https://postman-echo/get";

        [JsonProperty("method")]
        public string Method { get; set; } = "GET";

        [JsonProperty("description")]
        public string Description { get; set; } = "This is a sample GET Request";
    }
}