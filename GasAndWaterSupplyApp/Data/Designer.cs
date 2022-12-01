namespace GasAndWaterSupplyApp.Data
{
    public class Designer : User
    {
        public string ChiefProjectEngineer { get; set; }
        public string Director { get; set; }
        public string OGRN { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public string Name { get; set; }

        public Designer(string login, string password, string email, string telephone, 
            string name, string chiefProjectEngineer, string director, string oGRN, string iNN, string kPP) :
            base(login, password, email, telephone)
        {
            Name = name;
            ChiefProjectEngineer = chiefProjectEngineer;
            Director = director;
            OGRN = oGRN;
            INN = iNN;
            KPP = kPP;
        }

        public Designer(string name, string chiefProjectEngineer, string director, string oGRN, string iNN, string kPP, User user) :
            base(user.Login, user.Password, user.Email, user.Telephone)
        {
            Name = name;
            ChiefProjectEngineer = chiefProjectEngineer;
            Director = director;
            OGRN = oGRN;
            INN = iNN;
            KPP = kPP;
        }

        public Designer(User user) : base(user.Login, user.Password, user.Email, user.Telephone) { }

        public override bool AllFieldsAreFilled()
        {
            return (Name != String.Empty && KPP != String.Empty && INN != String.Empty && 
                OGRN != String.Empty && Director != String.Empty && ChiefProjectEngineer != String.Empty);
        }
    }
}
