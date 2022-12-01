namespace GasAndWaterSupplyApp.Data
{
    public class SingletonUserService
    {
        User currentUser;
        Project project;

        public User GetUser()
        {
            return currentUser;
        }

        public void SetUser(User newUser)
        {
            currentUser = newUser;
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
