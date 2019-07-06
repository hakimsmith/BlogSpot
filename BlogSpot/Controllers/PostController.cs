using BlogSpot.Models;
using BlogSpot.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpot.Controllers
{
    public class PostController : Controller
    {
        IRepository<Post> postRepos;
        public PostController(IRepository<Post> postRepos)
        {
            this.postRepos = postRepos;
        }

        public ViewResult AllPosts()
        {
            var model = postRepos.GetAll();
            return View(model);
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = postRepos.GetById(id);
            return View(model);
        }
        public ViewResult Post(int Postid)
        {
            var model = postRepos.GetById(Postid);
            return View(model);
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = postRepos.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Post post)
        {
            postRepos.Edit(post);
            return RedirectToAction("..Post/PostIndex/" + post.CategoryId);
        }

        [HttpPost]
        public ActionResult Delete(Post post)
        {
            int rbid = post.PostId;
            postRepos.Delete(post);

            return RedirectToAction("PostIndex");
        }

        [HttpGet]
        public ViewResult Create(int id)
        {
            ViewBag.CatID = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            postRepos.Create(post);
            return RedirectToAction("PostIndex");
        }
    }
}
