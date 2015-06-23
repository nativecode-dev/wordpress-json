namespace NativeCode.WordPressJson.Models
{
    using Newtonsoft.Json;

    public class Icon
    {
        [JsonProperty("img")]
        public string ImageFileName { get; set; }

        [JsonProperty("ico")]
        public string IconFileName { get; set; }
    }
}