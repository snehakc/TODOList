using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TODOLIST.Context;
using TODOLIST.Models;

namespace TODOLIST.Controllers
{
    public class ToDoModelsController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: ToDoModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToDoModels/Create To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IsCompleted,Item,Priority")] ToDoModel toDoModel)
        {
            if (ModelState.IsValid)
            {
                db.ToDoList.Add(toDoModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(toDoModel);
        }

        // GET: ToDoModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ToDoModel toDoModel = db.ToDoList.Find(id);
            if (toDoModel == null)
            {
                return HttpNotFound();
            }
            return View(toDoModel);
        }

        // POST: ToDoModels/DeleteAll
        [HttpPost, ActionName("DeleteAll")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteAll(IEnumerable<int> ids)
        {
            foreach (var id in ids)
            {
                var row = db.ToDoList.Single(s => s.Id == id);

                db.ToDoList.Remove(row);
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: ToDoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ToDoModel toDoModel = db.ToDoList.Find(id);
            db.ToDoList.Remove(toDoModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: ToDoModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ToDoModel toDoModel = db.ToDoList.Find(id);
            if (toDoModel == null)
            {
                return HttpNotFound();
            }
            return View(toDoModel);
        }

        // GET: ToDoModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ToDoModel toDoModel = db.ToDoList.Find(id);
            if (toDoModel == null)
            {
                return HttpNotFound();
            }
            return View(toDoModel);
        }

        // POST: ToDoModels/Edit/5 To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IsCompleted,Item,Priority")] ToDoModel toDoModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(toDoModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(toDoModel);
        }

        // GET: ToDoModels
        public ActionResult Index()
        {
            return View(db.ToDoList.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}