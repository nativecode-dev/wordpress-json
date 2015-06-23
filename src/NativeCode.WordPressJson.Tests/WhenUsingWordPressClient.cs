namespace NativeCode.WordPressJson.Tests
{
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
                Assert.AreEqual("http://www.secretlifeof.net", site.Url);
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
    }
}