namespace NativeCode.WordPressJson
{
    using System;
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
            var url = new Uri(this.BaseAddress, string.Format("sites/{0}/posts", this.Site.Authority));

            return this.GetResponseAsync<PostResults>(url);
        }

        public Task<Site> GetSiteAsync()
        {
            var url = new Uri(this.BaseAddress, string.Format("sites/{0}", this.Site.Authority));

            return this.GetResponseAsync<Site>(url);
        }

        private async Task<T> GetResponseAsync<T>(Uri url)
        {
            var response = await this.GetAsync(url).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}