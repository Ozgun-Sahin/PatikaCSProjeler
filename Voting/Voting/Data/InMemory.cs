using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting.Entities;

namespace Voting.Data
{
    public class InMemory
    {
        private static List<User> _users;
        private static List<Category> _categories;

        static InMemory()
        {
            _users = new List<User>
            {
                new User{Id = 1, Name = "Özgün", Password = "1234"},
                new User{Id = 2, Name = "Damla", Password = "5678"},
            };

            _categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Aksiyon", VoteCount=0},
                new Category{CategoryId=2, CategoryName="Komedi", VoteCount=0},
                new Category{CategoryId=3, CategoryName="Dram", VoteCount=0},
                new Category{CategoryId=4, CategoryName="Bilim-Kurgu", VoteCount=0},
            };
        }

        public static List<User> Users
        {
            get { return _users; }
        }

        public static List<Category> Categories 
        { 
            get { return _categories; } 
        }

    }
}
