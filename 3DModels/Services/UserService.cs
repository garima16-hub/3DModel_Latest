using _3DModels.Models;
using _3DModels.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace _3DModels.Services
{
    public class UserService
    {
        private readonly UserRepo _userRepo;

        public UserService(UserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public string CreateUser(User user)
        {
            return _userRepo.CreateUser(user);
        }

        public string DeleteUserById(int id)
        {
            return _userRepo.DeleteUserById(id);
        }

        public List<User> GetAllUser()
        {
            return _userRepo.GetAllUser();
        }

        public User GetUserById(int id)
        {
            return _userRepo.GetUserById(id);
        }

        public string UpdateUser(User user)
        {
            return _userRepo.UpdateUser(user);
        }

        public User GetIdByEmail(string email)
        {
            return _userRepo.GetIdByEmail(email);
        }
    }
}

