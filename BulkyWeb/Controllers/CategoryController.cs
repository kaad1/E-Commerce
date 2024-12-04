
﻿using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

﻿using Microsoft.AspNetCore.Mvc;


namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {

        private readonly AppDbContext _db;

        public CategoryController(AppDbContext db)
        {
            this._db = db;
        }
        public async Task <IActionResult> Index()
        {
           List<Category> objCategoryList=await _db.Categories.ToListAsync();
           
           return View(objCategoryList);

        public IActionResult Index()
        {
            return View();

        }
    }
}
