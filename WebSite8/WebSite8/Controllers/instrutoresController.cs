using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebSite8.Models;

namespace WebSite8.Controllers
{
    public class instrutoresController : Controller
    {
        private IESEntities db = new IESEntities();

        // GET: instrutores
        public ActionResult Index()
        {
            return View(db.instrutor.ToList());
        }

        // GET: instrutores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            instrutor instrutor = db.instrutor.Find(id);
            if (instrutor == null)
            {
                return HttpNotFound();
            }
            return View(instrutor);
        }

        // GET: instrutores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: instrutores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "instrutorID,nome,sobrenome,email")] instrutor instrutor)
        {
            if (ModelState.IsValid)
            {
                db.instrutor.Add(instrutor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(instrutor);
        }

        // GET: instrutores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            instrutor instrutor = db.instrutor.Find(id);
            if (instrutor == null)
            {
                return HttpNotFound();
            }
            return View(instrutor);
        }

        // POST: instrutores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "instrutorID,nome,sobrenome,email")] instrutor instrutor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(instrutor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(instrutor);
        }

        // GET: instrutores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            instrutor instrutor = db.instrutor.Find(id);
            if (instrutor == null)
            {
                return HttpNotFound();
            }
            return View(instrutor);
        }

        // POST: instrutores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            instrutor instrutor = db.instrutor.Find(id);
            db.instrutor.Remove(instrutor);
            db.SaveChanges();
            return RedirectToAction("Index");
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
