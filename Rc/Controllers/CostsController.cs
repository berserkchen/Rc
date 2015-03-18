using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rc.Models;
using PagedList;

using System.Data.Entity.Infrastructure;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Rc.Controllers
{
    
    public class CostsController : Controller
    {
        private RcContext db = new RcContext();
        public CostsController()
        {
            context = new ApplicationDbContext();
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
        }

        public CostsController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            UserManager = userManager;
            RoleManager = roleManager;
        }

        public UserManager<ApplicationUser> UserManager { get; private set; }
        public RoleManager<IdentityRole> RoleManager { get; private set; }
        public ApplicationDbContext context { get; private set; }

        // GET: Costs
        public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            string dep;
            var costs = from s in db.Costs
                        select s;
            if (User.Identity.GetUserId() != null)
            {
                dep = UserManager.FindById(User.Identity.GetUserId()).Department;
                costs = from s in db.Costs
                            where s.Column_C == dep
                            select s;
            }
            

            if (searchString != null)            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;


            if (!String.IsNullOrEmpty(searchString))
            {
                costs = costs.Where(s => s.Column_C.Contains(searchString)
                                       || s.Column_E.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    costs = costs.OrderByDescending(s => s.Column_C);
                    break;
                case "Date":
                    costs = costs.OrderBy(s => s.Column_C);
                    break;
                case "date_desc":
                    costs = costs.OrderByDescending(s => s.Column_C);
                    break;
                default:  // Name ascending 
                    costs = costs.OrderBy(s => s.CostID);
                    break;
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(costs.ToPagedList(pageNumber, pageSize));
        }

        // GET: Costs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cost cost = db.Costs.Find(id);
            if (cost == null)
            {
                return HttpNotFound();
            }
            return View(cost);
        }

        // GET: Costs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Costs/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CostID,Column_A,Column_B,Column_C,Column_D,Column_E,Column_F,Column_G,Column_H,Column_I,Column_J,Column_K,Column_L,Column_M,Column_N,Column_O,Column_P,Column_Q,Column_R,Column_S,Column_T,Column_U,Column_V,Column_W,Column_X,Column_Y,Column_Z,Column_AA,Column_AB,Column_AC,Column_AD,Column_AE,Column_AF")] Cost cost)
        {
            if (ModelState.IsValid)
            {
                db.Costs.Add(cost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cost);
        }

        // GET: Costs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cost cost = db.Costs.Find(id);
            if (cost == null)
            {
                return HttpNotFound();
            }
            return View(cost);
        }

        // POST: Costs/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CostID,Column_A,Column_B,Column_C,Column_D,Column_E,Column_F,Column_G,Column_H,Column_I,Column_J,Column_K,Column_L,Column_M,Column_N,Column_O,Column_P,Column_Q,Column_R,Column_S,Column_T,Column_U,Column_V,Column_W,Column_X,Column_Y,Column_Z,Column_AA,Column_AB,Column_AC,Column_AD,Column_AE,Column_AF")] Cost cost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cost);
        }

        // GET: Costs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cost cost = db.Costs.Find(id);
            if (cost == null)
            {
                return HttpNotFound();
            }
            return View(cost);
        }

        // POST: Costs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cost cost = db.Costs.Find(id);
            db.Costs.Remove(cost);
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
