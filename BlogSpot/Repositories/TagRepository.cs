using BlogSpot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpot.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
        private DataContext db;
        public TagRepository(DataContext db)
        {
            this.db = db;
        }

        public IEnumerable<Tag> GetAll()
        {
            return db.Tags;
        }

        public Tag GetById(int id)
        {
            return db.Tags.Single(c => c.TagId == id);
        }

        public void Create(Tag obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tag obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Tag obj)
        {
            throw new NotImplementedException();
        }
    }
}
