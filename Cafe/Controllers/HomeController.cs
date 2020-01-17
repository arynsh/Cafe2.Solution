using Microsoft.AspNetCore.Mvc;

namespace Cafe.Controllers
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