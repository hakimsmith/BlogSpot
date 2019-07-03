using BlogSpot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpot.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private DataContext db;
        public CategoryRepository(DataContext db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        }
        public void Create(Category obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
