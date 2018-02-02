using System.Net;
using WebServicesTests.Structures;

namespace WebServicesTests.Actions
{
    public class GetCollectionsActions : BaseActions
    {
        public GetCollectionsActions(string apikey)
        {
            _request = (HttpWebRequest) WebRequest.Create(_collesctionsUrl);
            _request.Headers.Add("X-Api-Key", apikey);
            _request.Method = "GET";
        }

        public CollectionsResponse GetAllCollentions()
        {
            return GetResponseData<CollectionsResponse>();
        }
    }
}