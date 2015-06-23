namespace NativeCode.WordPressJson.Tests
{
    using System;

    public abstract class Testing
    {
        protected static readonly Uri TestSite = new Uri("https://www.secretlifeof.net");

        protected Testing()
        {
            this.ClientFactory = new WordPressClientFactory();
        }

        public IWordPressClientFactory ClientFactory { get; private set; }
    }
}