using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace WebServicesTests.Actions
{
    public class BaseActions
    {
        protected readonly string _collesctionsUrl = "https://api.getpostman.com/collections/";
        protected HttpWebRequest _request;

        public HttpWebResponse GetCollectionResponse()
        {
            try
            {
                return (HttpWebResponse)_request.GetResponse();
            }
            catch (WebException e)
            {
                WebResponse response = e.Response;
                return (HttpWebResponse)response;
            }
        }

        public T GetResponseData<T>()
        {
            var response = GetCollectionResponse();

            var resp = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return JsonConvert.DeserializeObject<T>(resp);
        }

        protected void FormAndWriteRequestBody(string body)
        {
            var requestBody = Encoding.UTF8.GetBytes(body);
            _request.ContentLength = requestBody.Length;
            _request.ContentType = "application/json";

            var requesrtStream = _request.GetRequestStream();
            requesrtStream.Write(requestBody, 0, requestBody.Length);
        }
    }
}