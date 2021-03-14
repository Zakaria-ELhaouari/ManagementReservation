using ManagementReservation.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementReservation.Controllers
{
    public class TypeReservation : Controller
    {
        private readonly ApplicationDbContext _context;
        public TypeReservation(ApplicationDbContext context)
        {
            _context = context;
            //_reserveType = reserveType;
        }
        // GET: TypeReservation
        public ActionResult Index()
        {
            var Alltypes = _context.TypeReservation.ToList();
            return View(Alltypes);
        }

        // GET: TypeReservation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TypeReservation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeReservation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Models.TypeReservation TypeReservation)
        {
            try
            {
                _context.TypeReservation.Add(TypeReservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TypeReservation/Edit/5
        public ActionResult Edit(int id)
        {
            var type = _context.TypeReservation.Find(id);
            return View(type);
        }

        // POST: TypeReservation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Models.TypeReservation TypeReservation)
        {
            try
            {
                _context.TypeReservation.Update(TypeReservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TypeReservation/Delete/5
        public ActionResult Delete(int id)
        {
            var type = _context.TypeReservation.Find(id);
            return View(type);
        }

        // POST: TypeReservation/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Models.TypeReservation TypeReservation)
        {
            try
            {
                _context.TypeReservation.Remove(TypeReservation);
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
