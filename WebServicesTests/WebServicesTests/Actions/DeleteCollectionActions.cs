using System.Net;
using WebServicesTests.Structures;

namespace WebServicesTests.Actions
{
    public class DeleteCollectionActions : BaseActions
    {
        public DeleteCollectionActions(string apikey, string collectionUid)
        {
            _request = (HttpWebRequest)WebRequest.Create(_collesctionsUrl + collectionUid);
            _request.Headers.Add("X-Api-Key", apikey);
            _request.Method = "DELETE";
        }

        public DeleteCollectionResponse DeleteCollection()
        {
            return GetResponseData<DeleteCollectionResponse>();
        }
    }
}