using _3DModels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace _3DModels.Repository
{
    public class UserRepo : IUser
    {
        private readonly ModelDbContext _dbContext;

        public UserRepo(ModelDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string CreateUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return "User created successfully.";
        }

        public string DeleteUserById(int id)
        {
            var user = _dbContext.Users.Find(id);
            if (user == null)
            {
                return "User not found.";
            }

            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
            return "User deleted successfully.";
        }

        public List<User> GetAllUser()
        {
            return _dbContext.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _dbContext.Users.Find(id);
        }

        public string UpdateUser(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
            return "User updated successfully.";
        }

        public User GetIdByEmail(string email)
        {
            return _dbContext.Users.FirstOrDefault(u => u.UserEmail == email);
        }
    }
}

