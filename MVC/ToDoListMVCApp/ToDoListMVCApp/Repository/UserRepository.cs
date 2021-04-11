using ToDoListMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ToDoListMVCApp.Repository
{
    class UserRepository : IUserRepository
    {
        public TaskDBContext db;

        public UserRepository(TaskDBContext db)
        {
            this.db = db;
        }

        public void AddUser(Users users)
        {
            db.Users.Add(users);
            db.SaveChanges();
        }

        public void DeleteUser(Guid id)
        {
            db.Users.Remove(db.Users.Where(x => x.ID == id).SingleOrDefault());
            db.SaveChanges();
        }

        public void EditUser(Users users)
        {
            Users user  = db.Users.Where(x => x.ID == users.ID).SingleOrDefault();
            user.Username = users.Username;
            user.Role = users.Role;
            user.Password = users.Password;
            db.SaveChanges();
        }

        public Users GetUserByID(Guid id)
        {
            return db.Users.Where(x => x.ID == id).SingleOrDefault();
        }

        public List<Users> GetUsers()
        {
            return db.Users.ToList();
        }
    }
}
