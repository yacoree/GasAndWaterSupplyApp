using MongoDB.Driver;
using GasAndWaterSupplyApp.Data;

namespace GasAndWaterSupplyApp.Data
{
    public class UsersDB
    {
        static string dataBaseName = "UsersBase";
        static string userCollectionName = "Users";
        static MongoClient client;
        static IMongoDatabase database;
        static IMongoCollection<User> userCollection;

        static UsersDB()
        {
            client = new MongoClient();
            database = client.GetDatabase(dataBaseName);
            userCollection = database.GetCollection<User>(userCollectionName);
        }

        public static void AddUserToDataBase(User user)
        {
            userCollection.InsertOne(user);
        }

        public static List<User> FindAllUsers()
        {
            return userCollection.Find(x => true).ToList();
        }

        public static List<User> FindAllCustomer()
        {
            return userCollection.Find(x => x is Customer).ToList();
        }

        public static List<User> FindAllDeveloper()
        {
            return userCollection.Find(x => x is Developer).ToList();
        }

        public static List<User> FindAllDesigner()
        {
            return userCollection.Find(x => x is Designer).ToList();
        }

        public static void ReplaceUser(string login, User user)
        {
            userCollection.ReplaceOne(x => x.Login == login, user);
        }

        public static User FindUserByLogin(string login)
        {
            return userCollection.Find(x => x.Login == login).FirstOrDefault();
        }

        public static User FindUserByEmail(string email)
        {
            return userCollection.Find(x => x.Email == email).FirstOrDefault();
        }

        public static User FindUserByTelephone(string telephone)
        {
            return userCollection.Find(x => x.Telephone == telephone).FirstOrDefault();
        }
    }
}