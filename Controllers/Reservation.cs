using ManagementReservation.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementReservation.Controllers
{
    public class Reservation : Controller
    {
        private readonly ApplicationDbContext _context;
        public Reservation(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Reservation
        public ActionResult Index(string sortOrder)
        {
            var allReserve = _context.Reservation.
                Include(x => x.TypeReservation)
                .Include(x => x.User)
                .ToList();
            ViewBag.sortDate = String.IsNullOrEmpty(sortOrder) ? "date_sort" : "";
            switch (sortOrder)
            {
                case "date_sort":
                    allReserve = _context.Reservation.OrderBy(b => b.date).ToList();
                    break;
                default:
                    allReserve = _context.Reservation.ToList();
                    break;
            }
            return View(allReserve);
        }

        // GET: Reservation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reservation/Create
        public ActionResult Create()
        {
            var type = _context.TypeReservation.ToList();
            ViewBag.TypeReservation = new SelectList(type, "id", "name");
            return View();
        }

        // POST: Reservation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Models.Reservation Reservation)
        {
            try
            {
                _context.Reservation.Add(Reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Reservation/Edit/5
        public ActionResult Edit(int id)
        {
            var type = _context.TypeReservation.ToList();
            ViewBag.TypeReservation = new SelectList(type, "id", "name");
            var reserve = _context.Reservation.Find(id);
            return View(reserve);
        }

        // POST: Reservation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Models.Reservation Reservation)
        {
            try
            {
                _context.Reservation.Update(Reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Reservation/Delete/5
        public ActionResult Delete(int id)
        {
            var reserve = _context.Reservation.Find(id);
            return View(reserve);
        }

        // POST: Reservation/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Models.Reservation Reservation)
        {
            try
            {
                _context.Reservation.Remove(Reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
