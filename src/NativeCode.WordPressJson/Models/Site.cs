namespace NativeCode.WordPressJson.Models
{
    using Newtonsoft.Json;

    public class Site
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("URL")]
        public string Url { get; set; }

        [JsonProperty("jetpack")]
        public bool JetPackEnabled { get; set; }

        [JsonProperty("subscribers_count")]
        public int SubscriberCount { get; set; }

        [JsonProperty("icon")]
        public Icon Icon { get; set; }

        [JsonProperty("logo")]
        public Logo Logo { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("is_following")]
        public bool IsFollowing { get; set; }

        [JsonProperty("meta")]
        public LinksMeta Meta { get; set; }
    }
}