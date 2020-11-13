using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IncomeExpenses.Data;
using IncomeExpenses.Models;

namespace IncomeExpenses.Controllers
{
    public class IncomeExpensesController : Controller
    {
        private AppDBContext db = new AppDBContext();

        // GET: IncomeExpenses
        public ActionResult Index()
        {
            double income, expenses, net;
            income = db.incomeExpenses.Where(m => m.IsIncome == true).Select(p => p.Value).Sum();
            expenses = db.incomeExpenses.Where(m => m.IsIncome == false).Select(p => p.Value).Sum();
            net = income - expenses;
            ViewBag.Income = income;
            ViewBag.Expenses = expenses;
            ViewBag.Net = net;

            return View(db.incomeExpenses.ToList());
        }

        // GET: IncomeExpenses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeExpensesEM incomeExpensesEM = db.incomeExpenses.Find(id);
            if (incomeExpensesEM == null)
            {
                return HttpNotFound();
            }
            return View(incomeExpensesEM);
        }

        // GET: IncomeExpenses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IncomeExpenses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description,IsIncome,Value")] IncomeExpensesEM incomeExpensesEM)
        {
            if (ModelState.IsValid)
            {
                incomeExpensesEM.DateIncome = DateTime.Now;
                db.incomeExpenses.Add(incomeExpensesEM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(incomeExpensesEM);
        }

        // GET: IncomeExpenses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeExpensesEM incomeExpensesEM = db.incomeExpenses.Find(id);
            if (incomeExpensesEM == null)
            {
                return HttpNotFound();
            }
            return View(incomeExpensesEM);
        }

        // POST: IncomeExpenses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,IsIncome,Value")] IncomeExpensesEM incomeExpensesEM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(incomeExpensesEM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(incomeExpensesEM);
        }

        // GET: IncomeExpenses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeExpensesEM incomeExpensesEM = db.incomeExpenses.Find(id);
            if (incomeExpensesEM == null)
            {
                return HttpNotFound();
            }
            return View(incomeExpensesEM);
        }

        // POST: IncomeExpenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IncomeExpensesEM incomeExpensesEM = db.incomeExpenses.Find(id);
            db.incomeExpenses.Remove(incomeExpensesEM);
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
