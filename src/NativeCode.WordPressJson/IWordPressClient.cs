namespace NativeCode.WordPressJson
{
    using System;
    using System.Threading.Tasks;

    using NativeCode.WordPressJson.Models;

    /// <summary>
    /// Provides a contract for accessing WordPress sites.
    /// </summary>
    public interface IWordPressClient : IDisposable
    {
        Uri Site { get; }

        Task<PostResults> GetPostsAsync();

        Task<Site> GetSiteAsync();
    }
}