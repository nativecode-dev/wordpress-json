namespace NativeCode.WordPressJson.Models
{
    using Newtonsoft.Json;

    public class PostResults
    {
        [JsonProperty("found")]
        public int Count { get; set; }

        [JsonProperty("posts")]
        public Post[] Posts { get; set; }

        [JsonProperty("meta")]
        public PostResultsMeta Meta { get; set; }
    }
}