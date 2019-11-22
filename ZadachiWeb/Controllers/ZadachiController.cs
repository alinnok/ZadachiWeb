using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ZadachiData;
using ZadachiData.Entities;
using ZadachiWeb.Models;

namespace ZadachiWeb.Controllers
{
    public class ZadachiController : Controller
    {
        private readonly ZadachiContext _db;

        public ZadachiController(ZadachiContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create (Zadacha zadacha)
        {
            _db.Zadachi.Add(zadacha);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
        
        public IActionResult List()
        {
            var zadachi = _db.Zadachi.ToList();
            return View(new ZadachiViewModel(zadachi));
        }

        //("delete/{id:guid}")
        [HttpGet]
        public IActionResult Delete (Guid id)
        {
            var zadacha=_db.Zadachi.FirstOrDefault(x=>x.Id==id);

            if (zadacha != null)
            { 
                _db.Zadachi.Remove(zadacha);
                _db.SaveChanges();
            }
            
            return RedirectToAction("List");
        }
   
        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Search (string tag)
        {
            var zadachi=_db.Zadachi.Where(x=>x.Tag.Contains(tag)).ToList();
            
           if (zadachi.Count<=0)
            {
                return RedirectToAction("SearchFailed");
            }
            else
            {
                return View(zadachi);
           
            }
        }
     
        public IActionResult SearchFailed()
        {
            return View();
        }

    }
}