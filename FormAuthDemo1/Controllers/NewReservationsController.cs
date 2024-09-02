using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FormAuthDemo1.Data;
using FormAuthDemo1.Models;

namespace FormAuthDemo1.Controllers
{
    public class NewReservationsController : Controller
    {
        private EmployeeContext db = new EmployeeContext();

        // GET: NewReservations
        public async Task<ActionResult> Index()
        {
            return View(await db.NewReservations.ToListAsync());
        }

        // GET: NewReservations/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewReservation newReservation = await db.NewReservations.FindAsync(id);
            if (newReservation == null)
            {
                return HttpNotFound();
            }
            return View(newReservation);
        }

        // GET: NewReservations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewReservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,UserID,GymClassID,ReservationDate,IsCancelled")] NewReservation newReservation)
        {
            if (ModelState.IsValid)
            {
                db.NewReservations.Add(newReservation);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(newReservation);
        }

        // GET: NewReservations/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewReservation newReservation = await db.NewReservations.FindAsync(id);
            if (newReservation == null)
            {
                return HttpNotFound();
            }
            return View(newReservation);
        }

        // POST: NewReservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,UserID,GymClassID,ReservationDate,IsCancelled")] NewReservation newReservation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newReservation).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(newReservation);
        }

        // GET: NewReservations/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewReservation newReservation = await db.NewReservations.FindAsync(id);
            if (newReservation == null)
            {
                return HttpNotFound();
            }
            return View(newReservation);
        }

        // POST: NewReservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            NewReservation newReservation = await db.NewReservations.FindAsync(id);
            db.NewReservations.Remove(newReservation);
            await db.SaveChangesAsync();
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
