using GmailStackDemo.Models;
using GmailStackDemo.Services; // Import the namespace for your services
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics; // Import ILogger

namespace GmailStackDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMailService _mailService; // Inject IMailService

        public HomeController(ILogger<HomeController> logger, IMailService mailService) // Add IMailService parameter
        {
            _logger = logger;
            _mailService = mailService; // Assign mailService to _mailService
        }

        public IActionResult Index()
        {
            // Fetch emails using the mail service
            var emails = _mailService.GetAllMails();

            // Pass the emails to the view
            return View(emails);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
