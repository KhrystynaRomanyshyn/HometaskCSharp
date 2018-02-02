using System.Net;
using NUnit.Framework;
using WebServicesTests.Actions;

namespace WebServicesTests.Tests
{
    [TestFixture]
    class GetAllCollection
    {
        private GetCollectionsActions _collections;
        private const string CorrectApiKey = "0ebbe4a7113547d5a5081e2dfaff8df5";
        private const string InCorrectApiKey = "aff8df5";

        [Test]
        public void CheckCorrectStatusCodeGetAllCollection()
        {
            _collections = new GetCollectionsActions(CorrectApiKey);
            var actualStatusCode = _collections.GetCollectionResponse().StatusCode;
            const HttpStatusCode expectedStatusCode = HttpStatusCode.OK;

            Assert.AreEqual(actualStatusCode, expectedStatusCode, $"Actual status code{actualStatusCode} is not equal to expected {expectedStatusCode}");
        }  

        [Test]
        public void CheckNotAutorizedStatusCodeGetAllCollection()
        {
            _collections = new GetCollectionsActions(InCorrectApiKey);
            var actualStatusCode = _collections.GetCollectionResponse().StatusCode;
            const HttpStatusCode expectedStatusCode = HttpStatusCode.Unauthorized;

            Assert.AreEqual(actualStatusCode, expectedStatusCode, $"Actual status code{actualStatusCode} is not equal to expected {expectedStatusCode}");
        }

    }
}
