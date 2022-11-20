using Microsoft.AspNetCore.Mvc;
using NoelRocky.Data;
using NoelRocky.Models;
using System.Collections;
using System.Collections.Generic;

namespace NoelRocky.Controllers
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
               IEnumerable<Category> objList = _db.Category;
               return View(objList);
          }

          //GET - CREATE
          public IActionResult Create()
          {
               return View();
          }

          //POST - CREATE
          [HttpPost]
          [ValidateAntiForgeryToken]
          public IActionResult Create(Category obj)
          {
               if (ModelState.IsValid)
               {
                    _db.Category.Add(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
               }
               return View(obj);
               
          }

          //GET - Edit
          public IActionResult Edit(int? id)
          {
               if(id==null || id == 0)
               {
                    return NotFound();
               }
               Category obj = _db.Category.Find(id);
               if (obj == null)
               {
                    return NotFound();
               }
               return View(obj);

          }

          //POST - EDIT
          [HttpPost]
          [ValidateAntiForgeryToken]
          public IActionResult Edit(Category obj)
          {
               if (ModelState.IsValid)
               {
                    _db.Category.Update(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
               }
               return View(obj);

          }

          //GET - Delete
          public IActionResult Delete(int? id)
          {
               if (id == null || id == 0)
               {
                    return NotFound();
               }
               Category obj = _db.Category.Find(id);
               if (obj == null)
               {
                    return NotFound();
               }
               return View(obj);

          }

          //POST - Delete
          //[HttpPost]
          //[ValidateAntiForgeryToken]
          //public IActionResult DeletePost(int? id)
          //{
          //     var obj = _db.Category.Find(id);
          //     if (obj == null)
          //     {
          //          return NotFound();
          //     }
          //     _db.Category.Remove(obj);
          //     _db.SaveChanges();
          //     return RedirectToAction("Index");
          //}

          //POST - Delete
          [HttpPost]
          [ValidateAntiForgeryToken]
          public IActionResult Delete(Category obj) // <---Use Category obj instead of Id
          { 
               if (obj == null)
               {
                    return NotFound();
               }
               _db.Category.Remove(obj);
               _db.SaveChanges();
               return RedirectToAction("Index");
          }

          public IActionResult IndexTwo()
          {
               return View();
          }
     }
}
