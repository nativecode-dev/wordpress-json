namespace NativeCode.WordPressJson
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using NativeCode.WordPressJson.Models;

    using Newtonsoft.Json;

    internal class WordPressClient : HttpClient, IWordPressClient
    {
        public WordPressClient(Uri site, HttpMessageHandler handler) : base(handler, true)
        {
            this.Site = site;
        }

        public Uri Site { get; private set; }

        public async Task<IReadOnlyList<Post>> GetAllPostsAsync()
        {
            var results = await this.GetPostsAsync();
            var posts = new List<Post>(results.Count);

            posts.AddRange(results.Posts);

            while (posts.Count < results.Count)
            {
                var query = new PostQuery { Offset = posts.Count };
                results = await this.GetPostsAsync(query);
                posts.AddRange(results.Posts);
            }

            return posts;
        }

        public Task<PostResults> GetPostsAsync()
        {
            return this.GetPostsAsync(new PostQuery());
        }

        public Task<PostResults> GetPostsAsync(PostQuery query)
        {
            var path = string.Format("sites/{0}/posts", this.Site.Authority);
            var url = this.BuildUrl(path, query.GetParameters());

            return this.GetResponseAsync<PostResults>(url);
        }

        public Task<Site> GetSiteAsync()
        {
            var path = string.Format("sites/{0}", this.Site.Authority);
            var url = this.BuildUrl(path);

            return this.GetResponseAsync<Site>(url);
        }

        private async Task<T> GetResponseAsync<T>(Uri url)
        {
            var response = await this.GetAsync(url).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonConvert.DeserializeObject<T>(content);
        }

        private Uri BuildUrl(string relativePath, IReadOnlyDictionary<string, string> parameters = null)
        {
            var query = string.Empty;

            if (parameters != null && parameters.Any())
            {
                var @params = parameters.Select(kvp => string.Format("{0}={1}", kvp.Key, kvp.Value));
                query = string.Join("&", @params);
            }

            var scheme = this.BaseAddress.Scheme;
            var host = this.BaseAddress.Host;
            var port = this.BaseAddress.Port;
            var path = this.BaseAddress.AbsolutePath + relativePath;

            var builder = new UriBuilder(scheme, host, port, path) { Query = query };

            return builder.Uri;
        }
    }
}