namespace NativeCode.WordPressJson.Tests
{
    using System;
    using System.Threading.Tasks;

    using NUnit.Framework;

    [TestFixture]
    public class WhenUsingWordPressClient : Testing
    {
        [Test]
        public async Task ShouldReturnSiteInformation()
        {
            // Arrange
            using (var client = this.ClientFactory.CreateClient(TestSite))
            {
                // Act
                var site = await client.GetSiteAsync();

                // Assert
                Assert.AreEqual(TestSite.AbsoluteUri, new Uri(site.Url).AbsoluteUri);
            }
        }

        [Test]
        public async Task ShouldReturnSitePosts()
        {
            // Arrange
            using (var client = this.ClientFactory.CreateClient(TestSite))
            {
                // Act
                var posts = await client.GetPostsAsync();

                // Assert
                Assert.Greater(posts.Count, 0);
            }
        }

        [Test]
        public async Task ShouldReturnAllSitePosts()
        {
            // Arrange
            using (var client = this.ClientFactory.CreateClient(TestSite))
            {
                // Act
                var posts = await client.GetAllPostsAsync();

                // Assert
                Assert.Greater(posts.Count, 0);
            }
        }
    }
}