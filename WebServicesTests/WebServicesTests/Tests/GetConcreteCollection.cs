using System.Linq;
using System.Net;
using NUnit.Framework;
using WebServicesTests.Actions;


namespace WebServicesTests.Tests
{
    [TestFixture] 
    class GetConcreteCollection
    {
        private GetCollectionActions _collection;
        private const string CorrectApiKey = "0ebbe4a7113547d5a5081e2dfaff8df5";
       // private const string collectionid = "8a03c942-4c74-4fc9-8e92-c32c9eec039c";

        [Test]
        public void CheckCorrectStatusCodeGetCollection()
        {
            var collectionId = new GetCollectionsActions(CorrectApiKey).GetAllCollentions().Collections.First().Id;

            _collection = new GetCollectionActions(CorrectApiKey, collectionId);
            var actualStatusCode = _collection.GetCollectionResponse().StatusCode;
            const HttpStatusCode expectedStatusCode = HttpStatusCode.OK;

            Assert.AreEqual(expectedStatusCode, actualStatusCode, $"Actual status code{actualStatusCode} is not equal to expected {expectedStatusCode}");
        }

    }
}
