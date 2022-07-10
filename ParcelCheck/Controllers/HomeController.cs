using Microsoft.AspNetCore.Mvc;

namespace ParcelCheck.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}