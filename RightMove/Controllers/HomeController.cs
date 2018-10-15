using System.Web.Mvc;

namespace RightMove.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rent()
        {
            ViewBag.Message = "Wynajmij mieszkanie";

            return View();
        }

        public ActionResult Buy()
        {
            ViewBag.Message = "Kup co tam chcesz";

            return View();
        }

        public ActionResult Sell()
        {
            ViewBag.Message = "Sprzedaj";

            return View();
        }

        public ActionResult Map()
        {
            ViewBag.Message = "Mapa";

            return View();
        }
    }
}