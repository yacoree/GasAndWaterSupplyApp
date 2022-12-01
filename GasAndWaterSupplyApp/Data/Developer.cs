namespace GasAndWaterSupplyApp.Data
{
    public class Developer : User
    {
        public string HeadOfExecutiveCommitteeOfRT { get; set; }
        public string Adress { get; set; }
        public string OGRN { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public string Name { get; set; }

        public Developer(string login, string password, string email, string telephone,
            string name, string headOfExecutiveCommitteeOfRT, string adress, string oGRN, string iNN, string kPP) :
            base(login, password, email, telephone)
        {
            Name = name;
            HeadOfExecutiveCommitteeOfRT = headOfExecutiveCommitteeOfRT;
            Adress = adress;
            OGRN = oGRN;
            INN = iNN;
            KPP = kPP;
        }

        public Developer(string name, string headOfExecutiveCommitteeOfRT, string adress, string oGRN, string iNN, string kPP, User user) :
            base(user.Login, user.Password, user.Email, user.Telephone)
        {
            Name = name;
            HeadOfExecutiveCommitteeOfRT = headOfExecutiveCommitteeOfRT;
            Adress = adress;
            OGRN = oGRN;
            INN = iNN;
            KPP = kPP;
        }
    }
}
