namespace Services.User
{
    public class UserService
    {
        public List<Core.Domain.User> Users { get; set; }

        public UserService()
        {
            Users = new List<Core.Domain.User>();
        }

        public List<Core.Domain.User> GetAll()
        {
            return Users;
        }
    }
}