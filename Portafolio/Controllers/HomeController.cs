using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProjectsRepository projectsRepository;
        private readonly IMailService mailService;

        public HomeController(ILogger<HomeController> logger, IProjectsRepository projectsRepository, IMailService mailService)
        {
            _logger = logger;
            this.projectsRepository = projectsRepository;
            this.mailService = mailService;
        }

        public IActionResult Index()
        {
           

            var projects = projectsRepository.GetProjects().Take(2).ToList();
            var model = new HomeIndexViewModel() { Projects = projects };
            return View(model);

        }


        public IActionResult Projects()
        {
            var projects = projectsRepository.GetProjects();
            return View(projects);
        }

        public IActionResult Contact()
        {
            return View();
        }


        public IActionResult Thanks()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactViewModel contactViewModel)
        {
            await mailService.Send(contactViewModel);
            return RedirectToAction("Thanks");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
