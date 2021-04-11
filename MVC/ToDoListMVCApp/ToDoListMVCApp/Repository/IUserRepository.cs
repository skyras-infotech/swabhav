using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListMVCApp.Models;

namespace ToDoListMVCApp.Repository
{
    interface IUserRepository
    {
        List<Users> GetUsers();
        void AddUser(Users users);
        void EditUser(Users users);
        void DeleteUser(Guid id);
        Users GetUserByID(Guid id);
    }
}
