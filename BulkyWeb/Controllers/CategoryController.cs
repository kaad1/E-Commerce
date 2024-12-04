
﻿using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {

        private readonly AppDbContext _db;

        public CategoryController(AppDbContext db)
        {
            this._db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Category> objCategoryList = await _db.Categories.ToListAsync();

            return View(objCategoryList);

        }
        
        public async Task <IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category obj)
        {
           

            if (ModelState.IsValid)
            {
                _db.Categories.AddAsync(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
      

    }
}
