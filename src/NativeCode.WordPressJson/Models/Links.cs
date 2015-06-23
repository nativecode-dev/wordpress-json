namespace NativeCode.WordPressJson.Models
{
    using Newtonsoft.Json;

    public class Links
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("help")]
        public string Help { get; set; }

        [JsonProperty("posts")]
        public string Posts { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("xmlrpc")]
        public string XmlRpc { get; set; }
    }
}