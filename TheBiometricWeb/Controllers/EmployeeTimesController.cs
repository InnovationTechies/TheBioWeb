using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheBiometricWeb.Models;

namespace TheBiometricWeb.Controllers
{
    public class EmployeeTimesController : Controller
    {
        private TheCitiModels db = new TheCitiModels();

        // GET: EmployeeTimes
        public ActionResult Index()
        {
            var employeeTimes = db.EmployeeTimes.Include(e => e.Employee);
            return View(employeeTimes.ToList());
        }

        // GET: EmployeeTimes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeTime employeeTime = db.EmployeeTimes.Find(id);
            if (employeeTime == null)
            {
                return HttpNotFound();
            }
            return View(employeeTime);
        }

        // GET: EmployeeTimes/Create
        public ActionResult Create()
        {
            ViewBag.EmpID = new SelectList(db.Employees, "EmpID", "FirstName");
            return View();
        }

        // POST: EmployeeTimes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpTimeID,EmpDate,EmpClockIn,EmpClockOut,EmpID,Present")] EmployeeTime employeeTime)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeTimes.Add(employeeTime);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmpID = new SelectList(db.Employees, "EmpID", "FirstName", employeeTime.EmpID);
            return View(employeeTime);
        }

        // GET: EmployeeTimes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeTime employeeTime = db.EmployeeTimes.Find(id);
            if (employeeTime == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmpID = new SelectList(db.Employees, "EmpID", "FirstName", employeeTime.EmpID);
            return View(employeeTime);
        }

        // POST: EmployeeTimes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpTimeID,EmpDate,EmpClockIn,EmpClockOut,EmpID,Present")] EmployeeTime employeeTime)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeTime).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmpID = new SelectList(db.Employees, "EmpID", "FirstName", employeeTime.EmpID);
            return View(employeeTime);
        }

        // GET: EmployeeTimes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeTime employeeTime = db.EmployeeTimes.Find(id);
            if (employeeTime == null)
            {
                return HttpNotFound();
            }
            return View(employeeTime);
        }

        // POST: EmployeeTimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeTime employeeTime = db.EmployeeTimes.Find(id);
            db.EmployeeTimes.Remove(employeeTime);
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
