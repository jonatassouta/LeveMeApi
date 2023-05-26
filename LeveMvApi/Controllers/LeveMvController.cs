using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeveMv.Data.Context;
using LeveMv.Domain.Models;

namespace LeveMvApi.Controllers
{


    public class LeveMvController : Controller
    {
        private readonly LeveMvContext _context;

        public LeveMvController(LeveMvContext context)
        {
            _context = context;
        }

        // GET: LeveMv
        public async Task<IActionResult> Index()
        {
              return _context.LeveMvs != null ? 
                          View(await _context.LeveMvs.ToListAsync()) :
                          Problem("Entity set 'LeveMvContext.LeveMvs'  is null.");
        }

        // GET: LeveMv/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.LeveMvs == null)
            {
                return NotFound();
            }

            var leMv = await _context.LeveMvs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (leMv == null)
            {
                return NotFound();
            }

            return View(leMv);
        }

        // GET: LeveMv/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeveMv/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nome")] LeMv leMv)
        {
            if (ModelState.IsValid)
            {
                leMv.ID = Guid.NewGuid();
                _context.Add(leMv);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leMv);
        }

        // GET: LeveMv/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.LeveMvs == null)
            {
                return NotFound();
            }

            var leMv = await _context.LeveMvs.FindAsync(id);
            if (leMv == null)
            {
                return NotFound();
            }
            return View(leMv);
        }

        // POST: LeveMv/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,Nome")] LeMv leMv)
        {
            if (id != leMv.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leMv);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeMvExists(leMv.ID))
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
            return View(leMv);
        }

        // GET: LeveMv/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.LeveMvs == null)
            {
                return NotFound();
            }

            var leMv = await _context.LeveMvs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (leMv == null)
            {
                return NotFound();
            }

            return View(leMv);
        }

        // POST: LeveMv/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.LeveMvs == null)
            {
                return Problem("Entity set 'LeveMvContext.LeveMvs'  is null.");
            }
            var leMv = await _context.LeveMvs.FindAsync(id);
            if (leMv != null)
            {
                _context.LeveMvs.Remove(leMv);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeMvExists(Guid id)
        {
          return (_context.LeveMvs?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
