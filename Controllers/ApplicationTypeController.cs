using Microsoft.AspNetCore.Mvc;
using NoelRocky.Data;
using NoelRocky.Models;
using System.Collections.Generic;
using System.Linq;

namespace NoelRocky.Controllers
{
    public class ApplicationTypeController : Controller
    {
          private readonly ApplicationDbContext _db;

          public ApplicationTypeController(ApplicationDbContext db)
          {
               _db = db;
          }

          //GET  Index
          public IActionResult Index()
          {
                IEnumerable<ApplicationType> objList = _db.ApplicationType;
                ViewBag.Message = "My name is LeeNoelLian";
                return View(objList);
          }

          //GET Create
          public IActionResult Create()
          {
               return View();
          }

          //POST Create
          [HttpPost]
          [ValidateAntiForgeryToken]
          public IActionResult Create(ApplicationType obj)
          {
               _db.ApplicationType.Add(obj);
               _db.SaveChanges();
               return RedirectToAction("Index");
          }

          //GET Edit
          public IActionResult Edit(int? id)
          {
               if (id == null || id == 0)
               {
                    return NotFound();
               }
               ApplicationType obj = _db.ApplicationType.Find(id);
               if (obj == null)
               {
                    return NotFound();
               }
               return View(obj);
          }


          //POST Edit
          [HttpPost]
          [ValidateAntiForgeryToken]
          public IActionResult Edit(ApplicationType obj)
          {
               if (ModelState.IsValid)
               {
                    _db.ApplicationType.Update(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
               }
               return View(obj);

          }

          //GET Delete
          public IActionResult Delete(int? id)
          {
               if (id == null || id == 0)
               {
                    return NotFound();
               }
               ApplicationType obj = _db.ApplicationType.Find(id);
               if (obj == null)
               {
                    return NotFound();
               }
               return View(obj);

          }

          //POST Delete
          [HttpPost]
          [ValidateAntiForgeryToken]
          public IActionResult Delete(ApplicationType obj) 
          {
               if (obj == null)
               {
                    return NotFound();
               }
               _db.ApplicationType.Remove(obj);
               _db.SaveChanges();
               return RedirectToAction("Index");
          }
     }
}
