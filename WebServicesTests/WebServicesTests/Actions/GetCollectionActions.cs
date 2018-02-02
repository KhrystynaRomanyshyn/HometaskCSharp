using System.Net;
using WebServicesTests.Structures;

namespace WebServicesTests.Actions
{
    public class GetCollectionActions : BaseActions
    {

        public GetCollectionActions(string apikey, string collectionId)
        {
            _request = (HttpWebRequest)WebRequest.Create(_collesctionsUrl + collectionId);
            _request.Headers.Add("X-Api-Key", apikey);
            _request.Method = "GET";
        }

        public Collection GetAllCollentions()
        {
            return GetResponseData<Collection>();
        }
    }
}