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

        private Uri BuildUrl(string path, IReadOnlyDictionary<string, string> parameters = null)
        {
            var builder = new UriBuilder(this.BaseAddress.Scheme, this.BaseAddress.Host, this.BaseAddress.Port, this.BaseAddress.AbsolutePath);

            if (parameters != null && parameters.Any())
            {
                builder.Query = "?" + parameters.Select(kvp => string.Format("{0}={1}", kvp.Key, kvp.Value)).ToList();
            }

            return new Uri(builder.Uri, path);
        }
    }
}