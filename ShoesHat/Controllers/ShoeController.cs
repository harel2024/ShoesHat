using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShoesHat.Controllers
{
    public class ShoeController : Controller
    {
        // GET: ShoeController
        public ActionResult Index()
        {
            return View();
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

        // POST: ShoeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
