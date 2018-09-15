using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using freeQuote3.Models;


namespace freeQuote3.Controllers
{
    public class GoodsReceiptVMsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GoodsReceiptVMs
        public ActionResult Index()
        {
            //return View(db.GoodsReceiptVMs.ToList());

            List<GoodsReceiptVM> ReceiptVMList = new List<GoodsReceiptVM>();

            var goodsRecList = (from quote in db.FreeQuotes
                                join book in db.Bookings on quote.freeQuote equals book.freeQuote

                                select new
                                {
                                    quote.weight,
                                    quote.commodity,
                                    book.specInstruct
                                }).ToList();

            foreach (var item in goodsRecList)
            {
                GoodsReceiptVM obj = new GoodsReceiptVM();

                obj.weight = item.weight;
                obj.commodity = item.commodity;
                obj.specInstruct = item.specInstruct;
                //obj.addressCol = item.adressCol();
                //obj.addressDel = item.adressDel();

                ReceiptVMList.Add(obj);
            }

            return View(ReceiptVMList.ToList());


        }

        // GET: GoodsReceiptVMs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoodsReceiptVM goodsReceiptVM = db.GoodsReceiptVMs.Find(id);
            if (goodsReceiptVM == null)
            {
                return HttpNotFound();
            }
            return View(goodsReceiptVM);
        }

        // GET: GoodsReceiptVMs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GoodsReceiptVMs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GoodsID,specInstruct,weight,commodity")] GoodsReceiptVM goodsReceiptVM)
        {
            if (ModelState.IsValid)
            {
                db.GoodsReceiptVMs.Add(goodsReceiptVM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(goodsReceiptVM);
        }

        // GET: GoodsReceiptVMs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoodsReceiptVM goodsReceiptVM = db.GoodsReceiptVMs.Find(id);
            if (goodsReceiptVM == null)
            {
                return HttpNotFound();
            }
            return View(goodsReceiptVM);
        }

        // POST: GoodsReceiptVMs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GoodsID,specInstruct,weight,commodity")] GoodsReceiptVM goodsReceiptVM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(goodsReceiptVM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(goodsReceiptVM);
        }

        // GET: GoodsReceiptVMs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoodsReceiptVM goodsReceiptVM = db.GoodsReceiptVMs.Find(id);
            if (goodsReceiptVM == null)
            {
                return HttpNotFound();
            }
            return View(goodsReceiptVM);
        }

        // POST: GoodsReceiptVMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GoodsReceiptVM goodsReceiptVM = db.GoodsReceiptVMs.Find(id);
            db.GoodsReceiptVMs.Remove(goodsReceiptVM);
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
