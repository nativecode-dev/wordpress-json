namespace NativeCode.WordPressJson.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PostQuery
    {
        public PostQuery()
        {
            this.Fields = new List<string>();
        }

        public int? AuthorId { get; set; }

        public List<string> Fields { get; private set; }

        public int? MaxPosts { get; set; }

        public string PageHandle { get; set; }

        public PostStatus? Status { get; set; }

        public IReadOnlyDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>();

            if (this.AuthorId.HasValue)
            {
                parameters.Add("author", this.AuthorId.Value.ToString());
            }

            if (this.Fields.Any())
            {
                parameters.Add("fields", string.Join(",", this.Fields));
            }

            if (this.MaxPosts.HasValue)
            {
                parameters.Add("number", this.MaxPosts.Value.ToString());
            }

            if (!string.IsNullOrWhiteSpace(this.PageHandle))
            {
                parameters.Add("page_handle", this.PageHandle);
            }

            if (this.Status.HasValue)
            {
                parameters.Add("status", Enum.GetName(typeof(PostStatus), this.Status).ToLower());
            }

            return parameters;
        }
    }
}