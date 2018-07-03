using System.Net;

namespace HttpLib
{
    public class Logger
    {
        public void LogHttpExchange(HttpWebRequest request, HttpWebResponse response)
        {
            var url = request.RequestUri.AbsoluteUri;
            var method = request.Method;
            var requestLength = request.ContentLength;

            var responseLength = response.ContentLength;
            var status = response.StatusCode.ToString();

            // Some imaginary code to log all this
        }
    }
}
