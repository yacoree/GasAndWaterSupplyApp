namespace GasAndWaterSupplyApp.Data
{
    public class SingletonUserService
    {
        User currentUser;
        Roles role;
        Project project;

        public User GetUser()
        {
            return currentUser;
        }

        public void SetUser(User newUser)
        {
            currentUser = newUser;
        }

        public Roles GetRole()
        {
            return role;
        }

        public void SetRole(Roles role)
        {
            this.role = role;
        }

        public Project GetProject()
        {
            return project;
        }

        public void SetProject(Project project)
        {
            this.project = project;
        }
    }
}
