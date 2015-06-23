namespace NativeCode.WordPressJson.Models
{
    using System;

    using Newtonsoft.Json;

    public class Post
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("site_ID")]
        public int SiteId { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("modified")]
        public DateTime Modified { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("URL")]
        public string Url { get; set; }

        [JsonProperty("short_URL")]
        public string ShortUrl { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("excerpt")]
        public string Excerpt { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("sticky")]
        public bool Sticky { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("likes_enabled")]
        public bool LikesEnabled { get; set; }

        [JsonProperty("sharing_enabled")]
        public bool SharingEnabled { get; set; }

        [JsonProperty("like_count")]
        public int LikeCount { get; set; }

        [JsonProperty("i_like")]
        public bool IsLiked { get; set; }

        [JsonProperty("is_reblogged")]
        public bool IsReblogged { get; set; }

        [JsonProperty("is_following")]
        public bool IsFollowing { get; set; }

        [JsonProperty("global_ID")]
        public string GlobalId { get; set; }

        [JsonProperty("featured_image")]
        public string FeaturedImage { get; set; }

        [JsonProperty("post_thumbnail")]
        public object PostThumbnail { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("geo")]
        public string Geo { get; set; }

        [JsonProperty("menu_order")]
        public int MenuOrder { get; set; }

        [JsonProperty("page_template")]
        public string PageTemplate { get; set; }
    }
}