using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _13285_Egzamin.Controllers
{
    public class Controller1 : Controller
    {
        // GET: Controller1
        public ActionResult Index()
        {
            return View();
        }

        // GET: Controller1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Controller1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Controller1/Create
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

        // GET: Controller1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Controller1/Edit/5
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

        // GET: Controller1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Controller1/Delete/5
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
