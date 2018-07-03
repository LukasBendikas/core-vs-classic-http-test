using System;
using System.Net;
using System.Text;

namespace HttpLib
{
    public class Http
    {
        public (HttpWebResponse response, string responseText) Get(HttpWebRequest request)
        {
            var response = (HttpWebResponse)request.GetResponse();

            string responseText = string.Empty;

            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                responseText = reader.ReadToEnd();
            }

            // Expecting to close the stream only as per docs 
            // https://docs.microsoft.com/en-us/dotnet/api/system.net.httpwebresponse.close?view=netcore-2.1#System_Net_HttpWebResponse_Close
            response.Close();

            return (response, responseText);
        }
    }
}
