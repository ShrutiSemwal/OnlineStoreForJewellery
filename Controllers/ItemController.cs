using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization; 
using OnlineStoreForJewellery.Models;
using OnlineStoreForJewellery.Utility;
using OnlineStoreForJewellery.Repository.IRepository;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStoreForJewellery.Controllers
{
   
    [Authorize]
    public class ItemController : Controller
    {
        
        private readonly IUnitOfWork _unitOfWork;

        public ItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> objItemList = _unitOfWork.Item.GetAll();
            return View(objItemList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                _unitOfWork.Item.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Item created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //var categoryFromDb = _db.Categories.Find(id);
            var itemFromDbFirst = _unitOfWork.Item.GetFirstOrDefault(u => u.Id == id);
            //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);

            if (itemFromDbFirst == null)
            {
                return NotFound();
            }

            return View(itemFromDbFirst);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Item obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                _unitOfWork.Item.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Item updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //var categoryFromDb = _db.Categories.Find(id);
            var itemFromDbFirst = _unitOfWork.Item.GetFirstOrDefault(u => u.Id == id);
            //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);

            if (itemFromDbFirst == null)
            {
                return NotFound();
            }

            return View(itemFromDbFirst);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _unitOfWork.Item.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.Item.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Item deleted successfully";
            return RedirectToAction("Index");
        }
        
    }
}
