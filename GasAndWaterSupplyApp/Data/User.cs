using Microsoft.AspNetCore.Routing;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Threading;

namespace GasAndWaterSupplyApp.Data
{
    public enum Roles
    {
        Customer,
        Designer,
        Developer,
    }

    public enum Industries
    {
        WaterSupply,
        GasSupply
    }
    [BsonKnownTypes(typeof(Customer), typeof(Designer), typeof(Developer))]
    public class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId id;

        public string Password { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }

        public User() : this("guest", "", "", "")
        {
        }

        public User(string login, string password, string email, string telephone)
        {
            Login = login;
            Password = password;
            Email = email;
            Telephone = telephone;
        }
    }
}
