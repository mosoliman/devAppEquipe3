using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionStageEquipe3.Areas.Stages.Models;
using GestionStageEquipe3.Data;
using Microsoft.AspNetCore.Authorization;

namespace GestionStageEquipe3.Areas.Stages.Controllers
{
    [Area("Stages")]
    [Authorize(Roles = "ResponsableAdmin")]
    public class ResponsableAdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResponsableAdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Stages/ResponsableAdmin
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ResponsableAdmin.Include(r => r.Politesse).Include(r => r.Province).Include(r => r.Titre);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Stages/ResponsableAdmin/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var responsableAdmin = await _context.ResponsableAdmin
                .Include(r => r.Politesse)
                .Include(r => r.Province)
                .Include(r => r.Titre)
                .FirstOrDefaultAsync(m => m.ResponsableAdminId == id);
            if (responsableAdmin == null)
            {
                return NotFound();
            }

            return View(responsableAdmin);
        }

        // GET: Stages/ResponsableAdmin/Create
        public IActionResult Create()
        {
            ViewData["PolitesseId"] = new SelectList(_context.Politesse, "PolitesseId", "PolitesseId");
            ViewData["ProvinceId"] = new SelectList(_context.Province, "PolitesseId", "PolitesseId");
            ViewData["TitreId"] = new SelectList(_context.Titre, "TitreId", "TitreId");
            return View();
        }

        // POST: Stages/ResponsableAdmin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ResponsableAdminId,Prenom,Nom,PolitesseId,TitreId,Courriel,Telephone,Poste,Cellulaire,Telecopieur,Adresse,Ville,ProvinceId,CodePostal,Actif")] ResponsableAdmin responsableAdmin)
        {
            if (ModelState.IsValid)
            {
                responsableAdmin.ResponsableAdminId = Guid.NewGuid();
                _context.Add(responsableAdmin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PolitesseId"] = new SelectList(_context.Politesse, "PolitesseId", "PolitesseId", responsableAdmin.PolitesseId);
            ViewData["ProvinceId"] = new SelectList(_context.Province, "PolitesseId", "PolitesseId", responsableAdmin.ProvinceId);
            ViewData["TitreId"] = new SelectList(_context.Titre, "TitreId", "TitreId", responsableAdmin.TitreId);
            return View(responsableAdmin);
        }

        // GET: Stages/ResponsableAdmin/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var responsableAdmin = await _context.ResponsableAdmin.FindAsync(id);
            if (responsableAdmin == null)
            {
                return NotFound();
            }
            ViewData["PolitesseId"] = new SelectList(_context.Politesse, "PolitesseId", "PolitesseId", responsableAdmin.PolitesseId);
            ViewData["ProvinceId"] = new SelectList(_context.Province, "PolitesseId", "PolitesseId", responsableAdmin.ProvinceId);
            ViewData["TitreId"] = new SelectList(_context.Titre, "TitreId", "TitreId", responsableAdmin.TitreId);
            return View(responsableAdmin);
        }

        // POST: Stages/ResponsableAdmin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ResponsableAdminId,Prenom,Nom,PolitesseId,TitreId,Courriel,Telephone,Poste,Cellulaire,Telecopieur,Adresse,Ville,ProvinceId,CodePostal,Actif")] ResponsableAdmin responsableAdmin)
        {
            if (id != responsableAdmin.ResponsableAdminId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(responsableAdmin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResponsableAdminExists(responsableAdmin.ResponsableAdminId))
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
            ViewData["PolitesseId"] = new SelectList(_context.Politesse, "PolitesseId", "PolitesseId", responsableAdmin.PolitesseId);
            ViewData["ProvinceId"] = new SelectList(_context.Province, "PolitesseId", "PolitesseId", responsableAdmin.ProvinceId);
            ViewData["TitreId"] = new SelectList(_context.Titre, "TitreId", "TitreId", responsableAdmin.TitreId);
            return View(responsableAdmin);
        }

        // GET: Stages/ResponsableAdmin/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var responsableAdmin = await _context.ResponsableAdmin
                .Include(r => r.Politesse)
                .Include(r => r.Province)
                .Include(r => r.Titre)
                .FirstOrDefaultAsync(m => m.ResponsableAdminId == id);
            if (responsableAdmin == null)
            {
                return NotFound();
            }

            return View(responsableAdmin);
        }

        // POST: Stages/ResponsableAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var responsableAdmin = await _context.ResponsableAdmin.FindAsync(id);
            _context.ResponsableAdmin.Remove(responsableAdmin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResponsableAdminExists(Guid id)
        {
            return _context.ResponsableAdmin.Any(e => e.ResponsableAdminId == id);
        }
    }
}
