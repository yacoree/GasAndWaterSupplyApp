using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GasAndWaterSupplyApp.Data
{
    public class Project
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId id;
        public string Name { get; set; }
        public Customer Customer { get; set; }
        public Designer Designer { get; set; }
        public Developer Developer { get; set; }
        public List<Document> Documents { get; set; }

        public Project(Customer customer, string name)
        {
            Customer = customer;
            Name = name;
            //create List<Document>
            Documents = new List<Document>();
            var DocTypes = DocumentDB.FindDocumentTypesForProject(Customer.Department);
            foreach(var docType in DocTypes)
            {
                Documents.Add(new Document(docType));
            }
        }
    }
}
