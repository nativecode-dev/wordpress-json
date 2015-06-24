namespace NativeCode.WordPressJson
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using NativeCode.WordPressJson.Models;

    /// <summary>
    /// Provides a contract for accessing WordPress sites.
    /// </summary>
    public interface IWordPressClient : IDisposable
    {
        /// <summary>
        /// Gets the current WordPress site.
        /// </summary>
        Uri Site { get; }

        /// <summary>
        /// Gets all posts asynchronous.
        /// </summary>
        /// <returns>Returns a collection of <see cref="Post" />s.</returns>
        Task<IReadOnlyList<Post>> GetAllPostsAsync();

        /// <summary>
        /// Gets the posts asynchronous.
        /// </summary>
        /// <returns>Returns a <see cref="PostResults" />.</returns>
        Task<PostResults> GetPostsAsync();

        /// <summary>
        /// Gets the posts asynchronous.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>Returns a <see cref="PostResults" />.</returns>
        Task<PostResults> GetPostsAsync(PostQuery query);

        /// <summary>
        /// Gets the site asynchronous.
        /// </summary>
        /// <returns>Returns a <see cref="Site" />.</returns>
        Task<Site> GetSiteAsync();
    }
}