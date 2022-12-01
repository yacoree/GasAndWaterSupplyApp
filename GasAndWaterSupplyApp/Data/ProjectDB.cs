using MongoDB.Driver;

namespace GasAndWaterSupplyApp.Data
{
    public class ProjectDB
    {
        static string dataBaseName = "ProjectBase";
        static string userCollectionName = "Projects";
        static MongoClient client;
        static IMongoDatabase database;
        static IMongoCollection<Project> userCollection;

        static ProjectDB()
        {
            client = new MongoClient();
            database = client.GetDatabase(dataBaseName);
            userCollection = database.GetCollection<Project>(userCollectionName);
        }

        public static void AddProjectToDataBase(Project project)
        {
            userCollection.InsertOne(project);
        }

        public static List<Project> FindAllProject()
        {
            return userCollection.Find(x => true).ToList();
        }

        public static List<Project> FindAllProjectsByUser(User user)
        {
            return userCollection.Find(x => x.Customer.Login == user.Login 
            || x.Developer.Login == user.Login 
            || x.Designer.Login == user.Login).ToList();
        }

        public static Project FindProject(string name)
        {
            return userCollection.Find(x => x.Name == name).FirstOrDefault();
        }

        public static void ReplaceProject(string name, Project project)
        {
            userCollection.ReplaceOne(x => x.Name == name, project);
        }
    }
}
