using Microsoft.AspNetCore.Mvc;
using Triangles.Models;

namespace Triangles.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Form()
        {
            return View();
        }

        [Route("/result")]
        public ActionResult Result()
        {
            Triangle myTriangle = new Triangle();
            myTriangle.SetSides(Request.Query["sideA"], Request.Query["sideB"], Request.Query["sideC"]);
            return View("Result", myTriangle);
        }
    }
}
