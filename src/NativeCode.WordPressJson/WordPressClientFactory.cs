namespace NativeCode.WordPressJson
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;

    using ModernHttpClient;

    public class WordPressClientFactory : IWordPressClientFactory
    {
        private static readonly Uri WordPressRestServiceUrl = new Uri("https://public-api.wordpress.com/rest/v1.1/");

        public IWordPressClient CreateClient(Uri site)
        {
            var handler = this.CreateClientHandler();
            var client = new WordPressClient(site, handler);

            try
            {
                client.BaseAddress = WordPressRestServiceUrl;
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return client;
            }
            catch
            {
                client.Dispose();
                throw;
            }
        }

        protected HttpMessageHandler CreateClientHandler()
        {
            var handler = new NativeMessageHandler();

            try
            {
                handler.CookieContainer = new CookieContainer();
                return handler;
            }
            catch
            {
                handler.Dispose();
                throw;
            }
        }
    }
}