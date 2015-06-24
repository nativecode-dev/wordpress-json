namespace NativeCode.WordPressJson
{
    using System;

    /// <summary>
    /// Provides a factory for creating <see cref="IWordPressClient" /> instances.
    /// </summary>
    public interface IWordPressClientFactory
    {
        /// <summary>
        /// Creates a new <see cref="IWordPressClient" /> instance.
        /// </summary>
        /// <param name="site">The site.</param>
        /// <returns>Returns a new <see cref="IWordPressClient" />.</returns>
        IWordPressClient CreateClient(Uri site);
    }
}