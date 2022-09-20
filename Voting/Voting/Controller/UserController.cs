using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting.Data;
using Voting.Entities;

namespace Voting.Controller
{
    public class UserController
    {
        public User GetUserByName(string name)
        {
            return InMemory.Users.FirstOrDefault(x => x.Name == name);
        }

        public List<User> GetAllUsers()
        {

            return InMemory.Users.ToList();   
        }

        public User UserLogin(string name, string password)
        {
            
            User user = GetUserByName(name);

            if (password == user.Password)
            {
                Console.WriteLine("Hoşgeldiniz");
            }

            return user;
        }

        public void AddUser(string name, string password)
        {
            User eklenecekUser = new User
            {
                Id = InMemory.Users.Count,
                Name = name,
                Password = password,
            };

            InMemory.Users.Add(eklenecekUser);
        }

       



    }
}
