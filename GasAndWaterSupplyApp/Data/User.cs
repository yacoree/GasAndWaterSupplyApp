namespace GasAndWaterSupplyApp.Data
{
    public class User
    {
        string Login { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string Telephone { get; set; }

        public User(string login, string password, string email, string telephone)
        {
            Login = login;
            Password = password;
            Email = email;
            Telephone = telephone;
        }
    }
}
