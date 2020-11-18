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
using System.Data;
using System.Security.Claims;

namespace GestionStageEquipe3.Areas.Stages.Controllers
{
    [Area("Stages")]
    [Authorize(Roles = "Coordonnateur, ResponsableAdmin, Etudiant")]
    public class MilieuStagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MilieuStagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Stages/MilieuStages
        [Authorize(Roles = "Coordonnateur, Etudiant")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.MilieuStage.ToListAsync());
        }

        // GET: Stages/MilieuStages/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var milieuStage = await _context.MilieuStage
                .FirstOrDefaultAsync(m => m.MilieuStageId == id);
            if (milieuStage == null)
            {
                return NotFound();
            }

            return View(milieuStage);
        }

        [HttpPost]
        public IActionResult Appliquer(Guid id, EtudiantsMilieuStage etudiantsMilieuStage)
        {

            
            etudiantsMilieuStage.MilieuStageId = id;
            etudiantsMilieuStage.DataCanditature = DateTime.Now;
            etudiantsMilieuStage.Actif = true;


            // trouver le id du utilisateur en cours
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
            var userId = claim.Value;

            etudiantsMilieuStage.Id = userId;

            _context.EtudiantsMilieuStage.Add(etudiantsMilieuStage);
            _context.SaveChanges();
            
            return RedirectToAction(nameof(Index));
        }


        // GET: Stages/MilieuStages/Create
        [Authorize(Roles = "Coordonnateur")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stages/MilieuStages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Coordonnateur")]
        public async Task<IActionResult> Create([Bind("MilieuStageId,NumeroMilieuStage,NomMilieuStage,NomEntreprise,AdresseEntreprise,VilleEntreprise,ProvinceEntrepriseId,RegionAdministrativeEntrepriseId,CodepostaleEntreprise,Actif,NombreMaximumEtudiant,PolitesseResponsableId,PrenomResponsable,NomResponsable,TitreResponsableId,CourrielResponsable,TelephoneResponsable,PosteResponsable,CellulaireResponsable,TelecopieurResponsable,AdresseResponsable,VilleResponsable,CodePostalResponsable")] MilieuStage milieuStage)
        {
            if (ModelState.IsValid)
            {
                milieuStage.MilieuStageId = Guid.NewGuid();
                _context.Add(milieuStage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(milieuStage);
        }

        // GET: Stages/MilieuStages/Edit/5
        [Authorize(Roles = "Coordonnateur, ResponsableAdmin")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var milieuStage = await _context.MilieuStage.FindAsync(id);
            if (milieuStage == null)
            {
                return NotFound();
            }
            return View(milieuStage);
        }

        // POST: Stages/MilieuStages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Coordonnateur, ResponsableAdmin")]
        public async Task<IActionResult> Edit(Guid id, [Bind("MilieuStageId,NumeroMilieuStage,NomMilieuStage,NomEntreprise,AdresseEntreprise,VilleEntreprise,ProvinceEntrepriseId,RegionAdministrativeEntrepriseId,CodepostaleEntreprise,Actif,NombreMaximumEtudiant,PolitesseResponsableId,PrenomResponsable,NomResponsable,TitreResponsableId,CourrielResponsable,TelephoneResponsable,PosteResponsable,CellulaireResponsable,TelecopieurResponsable,AdresseResponsable,VilleResponsable,CodePostalResponsable")] MilieuStage milieuStage)
        {
            if (id != milieuStage.MilieuStageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(milieuStage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MilieuStageExists(milieuStage.MilieuStageId))
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
            return View(milieuStage);
        }

        // GET: Stages/MilieuStages/Delete/5
        [Authorize(Roles = "Coordonnateur")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var milieuStage = await _context.MilieuStage
                .FirstOrDefaultAsync(m => m.MilieuStageId == id);
            if (milieuStage == null)
            {
                return NotFound();
            }

            return View(milieuStage);
        }

        // POST: Stages/MilieuStages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Coordonnateur")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var milieuStage = await _context.MilieuStage.FindAsync(id);
            _context.MilieuStage.Remove(milieuStage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MilieuStageExists(Guid id)
        {
            return _context.MilieuStage.Any(e => e.MilieuStageId == id);
        }
    }
}
