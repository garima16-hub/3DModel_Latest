using _3DModels.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace _3DModels.Repository
{
    public interface IUser
    {
        public List<User> GetAllUser();
        public User GetUserById(int id);
        public string UpdateUser(User user);
        public string CreateUser(User user);
        public string DeleteUserById(int id);
        public User GetIdByEmail(string email);
    }
}