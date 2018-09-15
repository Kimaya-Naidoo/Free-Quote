using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace freeQuote3.Models
{
    public class FreeQuotesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FreeQuotes
        public ActionResult Index()
        {
            return View(db.FreeQuotes.ToList());
        }

        // GET: FreeQuotes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FreeQuote freeQuote = db.FreeQuotes.Find(id);
            if (freeQuote == null)
            {
                return HttpNotFound();
            }
            return View(freeQuote);
        }

        // GET: FreeQuotes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FreeQuotes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "freeQuote,CompanyName,ConsumerName,email,phoneNumber,delDate,equipment,quantity,CargoType,weight,dimension,commodity,specInstruct,CollectionDate,testtext,two,Collection,Dropoff,final")] FreeQuote freeQuote)
        {
            if (ModelState.IsValid)
            {
                db.FreeQuotes.Add(freeQuote);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(freeQuote);
        }

        // GET: FreeQuotes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FreeQuote freeQuote = db.FreeQuotes.Find(id);
            if (freeQuote == null)
            {
                return HttpNotFound();
            }
            return View(freeQuote);
        }

        // POST: FreeQuotes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "freeQuote,CompanyName,ConsumerName,email,phoneNumber,delDate,equipment,quantity,CargoType,weight,dimension,commodity,specInstruct,CollectionDate,testtext,two,Collection,Dropoff,final")] FreeQuote freeQuote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(freeQuote).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(freeQuote);
        }

        // GET: FreeQuotes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FreeQuote freeQuote = db.FreeQuotes.Find(id);
            if (freeQuote == null)
            {
                return HttpNotFound();
            }
            return View(freeQuote);
        }

        // POST: FreeQuotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FreeQuote freeQuote = db.FreeQuotes.Find(id);
            db.FreeQuotes.Remove(freeQuote);
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
