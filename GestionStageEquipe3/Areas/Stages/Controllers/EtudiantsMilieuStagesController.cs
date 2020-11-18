using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionStageEquipe3.Areas.Stages.Models;
using GestionStageEquipe3.Data;

namespace GestionStageEquipe3.Areas.Stages.Controllers
{
    [Area("Stages")]
    public class EtudiantsMilieuStagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EtudiantsMilieuStagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Stages/EtudiantsMilieuStages
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.EtudiantsMilieuStage.Include(e => e.ApplicationUser).Include(e => e.MilieuStage);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Stages/EtudiantsMilieuStages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var etudiantsMilieuStage = await _context.EtudiantsMilieuStage
                .Include(e => e.ApplicationUser)
                .Include(e => e.MilieuStage)
                .FirstOrDefaultAsync(m => m.MilieuStageEtudiantId == id);
            if (etudiantsMilieuStage == null)
            {
                return NotFound();
            }

            return View(etudiantsMilieuStage);
        }

        // GET: Stages/EtudiantsMilieuStages/Create
        public IActionResult Create()
        {
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["MilieuStageId"] = new SelectList(_context.MilieuStage, "MilieuStageId", "MilieuStageId");
            return View();
        }

        // POST: Stages/EtudiantsMilieuStages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MilieuStageEtudiantId,Id,MilieuStageId,DataCanditature,Actif")] EtudiantsMilieuStage etudiantsMilieuStage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(etudiantsMilieuStage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id", etudiantsMilieuStage.Id);
            ViewData["MilieuStageId"] = new SelectList(_context.MilieuStage, "MilieuStageId", "MilieuStageId", etudiantsMilieuStage.MilieuStageId);
            return View(etudiantsMilieuStage);
        }

        // GET: Stages/EtudiantsMilieuStages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var etudiantsMilieuStage = await _context.EtudiantsMilieuStage.FindAsync(id);
            if (etudiantsMilieuStage == null)
            {
                return NotFound();
            }
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id", etudiantsMilieuStage.Id);
            ViewData["MilieuStageId"] = new SelectList(_context.MilieuStage, "MilieuStageId", "MilieuStageId", etudiantsMilieuStage.MilieuStageId);
            return View(etudiantsMilieuStage);
        }

        // POST: Stages/EtudiantsMilieuStages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MilieuStageEtudiantId,Id,MilieuStageId,DataCanditature,Actif")] EtudiantsMilieuStage etudiantsMilieuStage)
        {
            if (id != etudiantsMilieuStage.MilieuStageEtudiantId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(etudiantsMilieuStage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EtudiantsMilieuStageExists(etudiantsMilieuStage.MilieuStageEtudiantId))
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
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id", etudiantsMilieuStage.Id);
            ViewData["MilieuStageId"] = new SelectList(_context.MilieuStage, "MilieuStageId", "MilieuStageId", etudiantsMilieuStage.MilieuStageId);
            return View(etudiantsMilieuStage);
        }

        // GET: Stages/EtudiantsMilieuStages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var etudiantsMilieuStage = await _context.EtudiantsMilieuStage
                .Include(e => e.ApplicationUser)
                .Include(e => e.MilieuStage)
                .FirstOrDefaultAsync(m => m.MilieuStageEtudiantId == id);
            if (etudiantsMilieuStage == null)
            {
                return NotFound();
            }

            return View(etudiantsMilieuStage);
        }

        // POST: Stages/EtudiantsMilieuStages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var etudiantsMilieuStage = await _context.EtudiantsMilieuStage.FindAsync(id);
            _context.EtudiantsMilieuStage.Remove(etudiantsMilieuStage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EtudiantsMilieuStageExists(int id)
        {
            return _context.EtudiantsMilieuStage.Any(e => e.MilieuStageEtudiantId == id);
        }
    }
}
