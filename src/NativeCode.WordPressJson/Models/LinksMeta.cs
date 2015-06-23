namespace NativeCode.WordPressJson.Models
{
    using Newtonsoft.Json;

    public class LinksMeta : Meta
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }
}