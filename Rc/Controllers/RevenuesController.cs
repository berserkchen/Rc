using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rc.Models;

namespace Rc.Controllers
{
    
    public class RevenuesController : Controller
    {
        private RcContext db = new RcContext();

        // GET: Revenues
        public ActionResult Index()
        {
            return View(db.Revenues.ToList());
        }

        // GET: Revenues/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Revenue revenue = db.Revenues.Find(id);
            if (revenue == null)
            {
                return HttpNotFound();
            }
            return View(revenue);
        }

        // GET: Revenues/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Revenues/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RevenueID,Column_A,Column_B,Column_C,Column_D,Column_E,Column_F,Column_G,Column_H,Column_I,Column_J,Column_K,Column_L,Column_M,Column_N,Column_O,Column_P,Column_Q,Column_R,Column_S,Column_T,Column_U,Column_V,Column_W,Column_X,Column_Y,Column_Z,Column_AA,Column_AB,Column_AC")] Revenue revenue)
        {
            if (ModelState.IsValid)
            {
                db.Revenues.Add(revenue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(revenue);
        }

        // GET: Revenues/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Revenue revenue = db.Revenues.Find(id);
            if (revenue == null)
            {
                return HttpNotFound();
            }
            return View(revenue);
        }

        // POST: Revenues/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RevenueID,Column_A,Column_B,Column_C,Column_D,Column_E,Column_F,Column_G,Column_H,Column_I,Column_J,Column_K,Column_L,Column_M,Column_N,Column_O,Column_P,Column_Q,Column_R,Column_S,Column_T,Column_U,Column_V,Column_W,Column_X,Column_Y,Column_Z,Column_AA,Column_AB,Column_AC")] Revenue revenue)
        {
            if (ModelState.IsValid)
            {
                db.Entry(revenue).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(revenue);
        }

        // GET: Revenues/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Revenue revenue = db.Revenues.Find(id);
            if (revenue == null)
            {
                return HttpNotFound();
            }
            return View(revenue);
        }

        // POST: Revenues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Revenue revenue = db.Revenues.Find(id);
            db.Revenues.Remove(revenue);
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
