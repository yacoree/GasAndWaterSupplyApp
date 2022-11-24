namespace GasAndWaterSupplyApp.Data
{
    public enum Industries
    {
        WaterSupply,
        GasSupply
    }

    public class Customer : User
    {
        string FName { get; set; }
        string LName { get; set; }
        string Patronymic { get; set; }
        Industries Department { get; set; }

        public Customer(string login, string password, string email, string telephone, string fName, string lName, string patronymic, Industries department) :
            base(login, password, email, telephone)
        {
            FName = fName;
            LName = lName;
            Patronymic = patronymic;
            Department = department;
        }
    }
}
