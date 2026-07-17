using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace DevOpsDashboard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.CurrentTime = DateTime.Now.ToString("dd MMM yyyy hh:mm:ss tt");
            ViewBag.Machine = Environment.MachineName;
            ViewBag.OS = RuntimeInformation.OSDescription;
            ViewBag.Framework = RuntimeInformation.FrameworkDescription;
            ViewBag.Environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";

            return View();
        }
    }
}