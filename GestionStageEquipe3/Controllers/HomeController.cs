using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GestionStageEquipe3.Models;
using GestionStageEquipe3.Services.Courriels;

namespace GestionStageEquipe3.Controllers
{
    //test
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public IEmailService _EmailService { get; }

        public HomeController(ILogger<HomeController> logger, IEmailService emailService)
        {
            // Mon commentaire
            _logger = logger;
            _EmailService = emailService;
            //UserManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Privacy()
        //public async Task<IActionResult> Privacy()
        public async Task<ActionResult> Privacy()
        {
            Exception erreur = await _EmailService.Send(new EmailMessage { Content = "Allo<br/><br/>Toi", FromAddresses = { new EmailAddress { Address = "rastanolet@gmail.com", Name = "Coordonateur" } }, ToAddresses = { new EmailAddress { Address = "rastanolet@gmail.com", Name = "Simon Nolet" } }, Subject = "Veuillez confirmer votre milieu de stage" });
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
