namespace WebServicesTests.Structures
{
    public class DeleteCollectionResponse
    {
        public DeleteCollection Collection { get; set; }
    }

    public class DeleteCollection
    {
        public string Id { get; set; }

        public string Uid { get; set; }
    }
}