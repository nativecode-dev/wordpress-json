namespace NativeCode.WordPressJson.Models
{
    using Newtonsoft.Json;

    public class MetaData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
    }
}