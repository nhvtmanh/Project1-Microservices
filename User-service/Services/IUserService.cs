﻿using User_service.Models;

namespace User_service.Services
{
    public interface IUserService
    {
        public IEnumerable<User> GetUserList();
        public User GetUserById(int id);
        public User AddUser(User product);
        public User UpdateUser(User product);
        public bool DeleteUser(int Id);
    }
}
