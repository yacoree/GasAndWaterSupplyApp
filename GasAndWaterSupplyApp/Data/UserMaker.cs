namespace GasAndWaterSupplyApp.Data
{
    public class UserMaker
    {
        public static Dictionary<string, Roles> dictionary;

        static UserMaker()
        {
            dictionary = new Dictionary<string, Roles>();
            dictionary.Add("Customer", Roles.Customer);
            dictionary.Add("Developer", Roles.Developer);
            dictionary.Add("Designer", Roles.Designer);
        }

        
    }
}
