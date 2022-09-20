using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting.Data;
using Voting.Entities;

namespace Voting.Controller
{
    public class CategoryController
    {
        public List<Category> GetAllCategories()
        {
            return InMemory.Categories.ToList();
        }

        public void RaiseVoteCount(Category category)
        {
            category.VoteCount++;
        }

        public Category GetCategoryById(int id)
        {
            return InMemory.Categories.FirstOrDefault(x => x.CategoryId == id);
        }

        

    }
}
