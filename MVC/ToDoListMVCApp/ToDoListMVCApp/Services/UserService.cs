using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoListMVCApp.Repository;
using ToDoListMVCApp.Models;

namespace ToDoListMVCApp.Services
{
    public class UserService
    {
        private static UserService _userService;
        private UserRepository repository = new UserRepository(new TaskDBContext());

        public static UserService GetInstance
        {
            get
            {
                if (_userService == null)
                {
                    _userService = new UserService();
                }
                return _userService;
            }
        }

        public void AddUser(Users user)
        {
            repository.AddUser(user);
        }

        public void DeleteUser(int id)
        {
            repository.DeleteUser(id);
        }

        public List<Users> GetUsers()
        {
            return repository.GetUsers();
        }

        public Users GetUserByID(int id)
        {
            return repository.GetUserByID(id);
        }

        public void UpdateUser(Users user)
        {
            repository.EditUser(user);
        }
    }
}