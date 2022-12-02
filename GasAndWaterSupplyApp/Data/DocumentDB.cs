using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System.IO;

namespace GasAndWaterSupplyApp.Data
{
    public class DocumentDB
    {
        static string documentDBName = "DocumentsBase";
        static string fileDBName = "FilesBase";
        static string documentCollectionName = "Documents";
        static string fileCollectionName = "Files";
        static string documentTypeCollectionName = "DocumentTypes";
        static MongoClient documentClient;
        static IMongoDatabase documentsDB;
        static IMongoDatabase filesDB;
        static IMongoCollection<Document> documentCollection;
        static IMongoCollection<DocumentType> documentTypeCollection;
        static IGridFSBucket fileGridFSBucket;

        static DocumentDB()
        {
            documentClient = new MongoClient();
            documentsDB = documentClient.GetDatabase(documentDBName);
            filesDB = documentClient.GetDatabase(fileDBName);
            documentCollection = documentsDB.GetCollection<Document>(documentCollectionName);
            documentTypeCollection = documentsDB.GetCollection<DocumentType>(documentTypeCollectionName);
            fileGridFSBucket = new GridFSBucket(filesDB);
        }

        public static void AddDocumentToDataBase(Document document)
        {
            documentCollection.InsertOne(document);
        }

        public static void AddDocumentTypeToDataBase(DocumentType documentType)
        {
            documentTypeCollection.InsertOne(documentType);
        }

        public static ObjectId AddFileToDataBase(string path, string name)
        {
            using Stream fs = File.OpenRead(path);
            ObjectId id = fileGridFSBucket.UploadFromStream(name, fs);
            return id;
        }

        public static List<DocumentType> FindAllDocumentTypes()
        {
            return documentTypeCollection.Find(x => true).ToList();
        }

        public static List<DocumentType> FindDocumentTypes(Roles role, Industries industries)
        {
            return documentTypeCollection.Find(x => x.Industry == industries && x.Role == role).ToList();
        }

        public static List<DocumentType> FindDocumentTypesForProject(Industries industries)
        {
            return documentTypeCollection.Find(x => x.Industry == industries).ToList();
        }

        public static void FindFile(string id, string path)
        {
            using Stream fs = File.OpenWrite(path);
            fileGridFSBucket.DownloadToStream(new ObjectId(id), fs);
            //var filter = Builders<GridFSFileInfo>.Filter.Eq(info => info.Id, new ObjectId(id));
            //var fileInfos = fileGridFSBucket.Find(filter);
            //var fileInfo = fileInfos.FirstOrDefault();
            //return fileInfo;
        }

        //public static List<Document> FindDocuments(User user)
        //{
        //    return documentCollection.Find(x => x.Cust).ToList();
        //}

        public static void ReplaceFile(ObjectId id, string path, string name)
        {
            using FileStream fs = File.OpenRead(path);
            fileGridFSBucket.UploadFromStream(name, fs,
                    new GridFSUploadOptions { Metadata = new BsonDocument("id", id) });
        }
    }
}
