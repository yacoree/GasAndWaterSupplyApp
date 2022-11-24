namespace GasAndWaterSupplyApp.Data
{
    public class Designer : User
    {
        string Name { get; set; }
        string ChiefProjectEngineer { get; set; }
        string Director { get; set; }
        string OGRN { get; set; }
        string INN { get; set; }
        string KPP { get; set; }
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
    }
}
