namespace GasAndWaterSupplyApp.Data
{
    public class Customer : User
    {
        public Industries Department { get; set; }
        public string Patronymic { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        
        public Customer(string login, string password, string email, string telephone, string fName, string lName, string patronymic, Industries department) :
            base(login, password, email, telephone)
        {
            FName = fName;
            LName = lName;
            Patronymic = patronymic;
            Department = department;
        }

        public Customer(string fName, string lName, string patronymic, Industries department, User user) :
            base(user.Login, user.Password, user.Email, user.Telephone)
        {
            FName = fName;
            LName = lName;
            Patronymic = patronymic;
            Department = department;
        }

        public Customer(User user) : base(user.Login, user.Password, user.Email, user.Telephone)
        {
            Department = Industries.WaterSupply;
        }

        public override bool AllFieldsAreFilled()
        {
            return (Patronymic != String.Empty && LName != String.Empty && FName != String.Empty);
        }
    }
}
