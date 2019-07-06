using BlogSpot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpot.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private DataContext db;
        public PostRepository(DataContext db)
        {
            this.db = db;
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts;
        }

        public Post GetById(int id)
        {
            return db.Posts.Single(c => c.PostId == id);
        }

        public void Create(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
        }

        public void Delete(Post post)
        {
            db.Posts.Remove(post);
            db.SaveChanges;
        }

        public void Edit(Post post)
        {
            db.Posts.Update(post);
            db.SaveChanges;
        }

    }
}
