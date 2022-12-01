using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GasAndWaterSupplyApp.Data
{
    public class Document
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId id;
        public bool Approved { get; set; }
        public DocumentType Type { get; set; }
        public string FileId { get; set; }

        public Document(DocumentType type)
        {
            Type = type;
            Approved = false;
        }
    }
}
