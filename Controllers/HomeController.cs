using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("")]       //type of request
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }

        [HttpGet("contact")]

        public IActionResult Contact()
        {
            return View("Contact");
        }
    }
}