﻿using GlassStore.Data;
using GlassStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlassStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db) 
        { 
          _db = db;
        }
        public IActionResult Index()
        {
            //var objCategoryList = _db.Categories.ToList();
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
