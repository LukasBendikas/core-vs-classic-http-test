using HttpLib;
using NUnit.Framework;
using System.Net;

namespace CoreTest
{
    [TestFixture]
    public class HttpTests
    {
        [Test]
        public void Get_ShouldNotThrowException()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");

            var (response, responseText) = new Http().Get(request);

            var logger = new Logger();

            Assert.DoesNotThrow(() => logger.LogHttpExchange(request, response));
        }
    }
}
