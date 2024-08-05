using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoesHat.DAL;
using ShoesHat.Models;

namespace ShoesHat.Controllers
{
    public class HatController1 : Controller
    {
        // GET: HatController1
        public ActionResult Index()
        {
            return View(Data.Get.Hats..BindingAddress);
        }

        // GET: HatController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HatController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HatController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hat hat )
        {
            Data.Get.Hats.Add(hat); // הוספת הספריה למסד נתונים
            Data.Get.SaveChanges(); // שמירת השינויים במסד נתונים
            return RedirectToAction("Index"); // הפנייה לעמוד הראשי
        
        }

        // GET: HatController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HatController1/Edit/5
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

        // GET: HatController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HatController1/Delete/5
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
