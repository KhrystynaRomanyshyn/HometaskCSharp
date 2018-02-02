using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebServicesTests.Structures;

namespace WebServicesTests.Actions
{
    public class CreateCollectionActions : BaseActions
    {
        public CreateCollectionActions(string apikey)
        {
            _request = (HttpWebRequest)WebRequest.Create(_collesctionsUrl);
            _request.Headers.Add("X-Api-Key", apikey);
            _request.Method = "POST";
        }


        public CreateCollectionResponse CreateCollectiosWithObject(CreateCollectionRequest request)
        {
            var body = JsonConvert.SerializeObject(request);

            FormAndWriteRequestBody(body);

            return GetRequestResponse();
        }

        public CreateCollectionResponse CreateCollectiosWithFile(string fileName)
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