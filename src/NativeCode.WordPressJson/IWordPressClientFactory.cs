namespace NativeCode.WordPressJson
{
    using System;

    /// <summary>
    /// Provides a factory for creating <see cref="IWordPressClient" /> instances.
    /// </summary>
    public interface IWordPressClientFactory
    {
        IWordPressClient CreateClient(Uri site);
    }
}