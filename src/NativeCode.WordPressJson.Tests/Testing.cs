namespace NativeCode.WordPressJson.Tests
{
    using System;

    public abstract class Testing
    {
        protected static readonly Uri TestSite = new Uri("http://www.doubtlessfaith.com/");

        protected Testing()
        {
            this.ClientFactory = new WordPressClientFactory();
        }

        public IWordPressClientFactory ClientFactory { get; private set; }
    }
}