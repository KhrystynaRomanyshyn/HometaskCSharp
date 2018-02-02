using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebServicesTests.Structures;

namespace WebServicesTests.Actions
{
    public class UpdateCollectionActions : BaseActions
    {
        public UpdateCollectionActions(string apikey, string collectionUid)
        {
            _request = (HttpWebRequest)WebRequest.Create(_collesctionsUrl + collectionUid);
            _request.Headers.Add("X-Api-Key", apikey);
            _request.Method = "PUT";
        }

        public CreateCollectionResponse UpdateCollectiosWithObject(UpdateCollectionRequest request)
        {
            var body = JsonConvert.SerializeObject(request);

            FormAndWriteRequestBody(body);

            return GetRequestResponse();
        }

        public CreateCollectionResponse UpdateCollectiosWithFile(string fileName)
        {
            var path = Path.Combine(Environment.CurrentDirectory, @"Resources\", fileName);
            var requestObject = JObject.Parse(File.ReadAllText(path));
            var body = JsonConvert.SerializeObject(requestObject);

            FormAndWriteRequestBody(body);

            return GetRequestResponse();
        }

        public CreateCollectionResponse GetRequestResponse()
        {
            return GetResponseData<CreateCollectionResponse>();
        }
    }
}