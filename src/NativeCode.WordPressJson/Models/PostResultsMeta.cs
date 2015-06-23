namespace NativeCode.WordPressJson.Models
{
    using Newtonsoft.Json;

    public class PostResultsMeta : LinksMeta
    {
        [JsonProperty("next_page")]
        public string NextPage { get; set; }
    }
}