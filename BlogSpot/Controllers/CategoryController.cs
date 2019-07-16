﻿using BlogSpot.Models;
using BlogSpot.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpot.Controllers
{
    public class CategoryController : Controller
    {
        IRepository<Category> categoryRepo;
        public CategoryController(IRepository<Category> categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        public ViewResult CategoryIndex()
        {
            var model = categoryRepo.GetAll();
            return View(model);
        }

        public ActionResult CategoryDetails(int id)
        {
            var model = categoryRepo.GetById(id);
            return View(model);
        }
    }
}
