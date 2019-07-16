using BlogSpot.Models;
using BlogSpot.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpot.Controllers
{
    public class TagController : Controller
    {
        IRepository<Tag> tagrepos;

        public TagController(IRepository<Tag> tagrepos)
        {
            this.tagrepos = tagrepos;
        }

        public ViewResult AllTags()
        {
            var model = tagrepos.GetAll();
            return View(model);
        }

        public ActionResult SingleTag(int id)
        {
            var model = tagrepos.GetById(id);
            return View(model);
        }
    }
}
