using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoesHat.DAL;
using ShoesHat.Models;

namespace ShoesHat.Controllers
{
    public class ShoeController : Controller
    {
        // GET: ShoeController
        public ActionResult Index()
        {
            return View((Data.Get.Shoes));
        }

        // GET: ShoeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShoeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // מטפל בשליחת הטופס ליצירת חבר חדש
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(Shoe shoe)
        {
            // מוסיף את החבר החדש למסד הנתונים ושומר שינויים
            Data.Get.Shoes.Add(shoe);
            Data.Get.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: ShoeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShoeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShoeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShoeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
