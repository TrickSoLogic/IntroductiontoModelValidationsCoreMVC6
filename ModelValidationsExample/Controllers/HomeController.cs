using Microsoft.AspNetCore.Mvc;
using IntroductiontoModelValidationsCoreMVC6.Models;

namespace IntroductiontoModelValidationsCoreMVC6.Controllers
{
  public class HomeController : Controller
  {
    [Route("register")]
    public IActionResult Index(Person person)
    {
      return Content($"{person}");
    }
  }
}
