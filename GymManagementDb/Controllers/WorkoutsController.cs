using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GymManagementDb.Models;
using GymManagementDb.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;

namespace GymManagementDb.Controllers
{
    [Authorize(Roles = "Admin")]
    public class WorkoutsController : Controller
    {
        private readonly GymManagementDbContext _context;

        public WorkoutsController(GymManagementDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Search(string x)
        {
            var y = await _context.Workouts
                                  .Where(a => a.Name == x)
                                  .ToListAsync();

            return View("Index", y);
        }

        // GET: Workouts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Workouts.Include(a => a.Trainers).ToArrayAsync());
        }

        // GET: Workouts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workouts = await _context.Workouts
                .FirstOrDefaultAsync(m => m.WorkoutID == id);
            if (workouts == null)
            {
                return NotFound();
            }

            return View(workouts);
        }

        // GET: Workouts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Workouts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WorkoutID,Name,Type,Duration,TrainerID")] Workouts workouts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workouts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workouts);
        }

        // GET: Workouts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workouts = await _context.Workouts.FindAsync(id);
            if (workouts == null)
            {
                return NotFound();
            }
            return View(workouts);
        }

        // POST: Workouts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WorkoutID,Name,Type,Duration,TrainerID")] Workouts workouts)
        {
            if (id != workouts.WorkoutID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workouts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkoutsExists(workouts.WorkoutID))
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
            return View(workouts);
        }

        // GET: Workouts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workouts = await _context.Workouts
                .FirstOrDefaultAsync(m => m.WorkoutID == id);
            if (workouts == null)
            {
                return NotFound();
            }

            return View(workouts);
        }

        // POST: Workouts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workouts = await _context.Workouts.FindAsync(id);
            if (workouts != null)
            {
                _context.Workouts.Remove(workouts);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkoutsExists(int id)
        {
            return _context.Workouts.Any(e => e.WorkoutID == id);
        }
    }
}
