using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GymManagementDb.Data;
using GymManagementDb.Models;

namespace GymManagementDb.Controllers
{
    public class TrainerSpecialtiesController : Controller
    {
        private readonly GymManagementDbContext _context;

        public TrainerSpecialtiesController(GymManagementDbContext context)
        {
            _context = context;
        }

        // GET: TrainerSpecialties
        public async Task<IActionResult> Index()
        {
            var gymManagementDbContext = _context.TrainerSpecialty.Include(t => t.Trainers);
            return View(await gymManagementDbContext.ToListAsync());
        }

        // GET: TrainerSpecialties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainerSpecialty = await _context.TrainerSpecialty
                .Include(t => t.Trainers)
                .FirstOrDefaultAsync(m => m.TrainersSpecialtyID == id);
            if (trainerSpecialty == null)
            {
                return NotFound();
            }

            return View(trainerSpecialty);
        }

        // GET: TrainerSpecialties/Create
        public IActionResult Create()
        {
            ViewData["TrainerID"] = new SelectList(_context.Trainers, "TrainerID", "Name");
            return View();
        }

        // POST: TrainerSpecialties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TrainersSpecialtyID,TrainerID")] TrainerSpecialty trainerSpecialty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trainerSpecialty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TrainerID"] = new SelectList(_context.Trainers, "TrainerID", "Name", trainerSpecialty.TrainerID);
            return View(trainerSpecialty);
        }

        // GET: TrainerSpecialties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainerSpecialty = await _context.TrainerSpecialty.FindAsync(id);
            if (trainerSpecialty == null)
            {
                return NotFound();
            }
            ViewData["TrainerID"] = new SelectList(_context.Trainers, "TrainerID", "Name", trainerSpecialty.TrainerID);
            return View(trainerSpecialty);
        }

        // POST: TrainerSpecialties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TrainersSpecialtyID,TrainerID")] TrainerSpecialty trainerSpecialty)
        {
            if (id != trainerSpecialty.TrainersSpecialtyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trainerSpecialty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainerSpecialtyExists(trainerSpecialty.TrainersSpecialtyID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["TrainerID"] = new SelectList(_context.Trainers, "TrainerID", "Name", trainerSpecialty.TrainerID);
            return View(trainerSpecialty);
        }

        // GET: TrainerSpecialties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainerSpecialty = await _context.TrainerSpecialty
                .Include(t => t.Trainers)
                .FirstOrDefaultAsync(m => m.TrainersSpecialtyID == id);
            if (trainerSpecialty == null)
            {
                return NotFound();
            }

            return View(trainerSpecialty);
        }

        // POST: TrainerSpecialties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trainerSpecialty = await _context.TrainerSpecialty.FindAsync(id);
            if (trainerSpecialty != null)
            {
                _context.TrainerSpecialty.Remove(trainerSpecialty);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainerSpecialtyExists(int id)
        {
            return _context.TrainerSpecialty.Any(e => e.TrainersSpecialtyID == id);
        }
    }
}
