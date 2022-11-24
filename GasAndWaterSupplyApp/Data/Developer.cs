namespace GasAndWaterSupplyApp.Data
{
    public class Developer : User
    {
        string Name { get; set; }
        string HeadOfExecutiveCommitteeOfRT { get; set; }
        string Adress { get; set; }
        string OGRN { get; set; }
        string INN { get; set; }
        string KPP { get; set; }
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
    }
}
