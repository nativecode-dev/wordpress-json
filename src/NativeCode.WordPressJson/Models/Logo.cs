namespace NativeCode.WordPressJson.Models
{
    using Newtonsoft.Json;

    public class Logo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sizes")]
        public object[] Sizes { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}