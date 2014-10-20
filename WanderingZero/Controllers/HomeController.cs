using System.Web.Mvc;

namespace WanderingZero.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Shows()
        {
            return View("/Views/Shows/Index.cshtml");
        }

        public ActionResult Media()
        {
            return View("/Views/Media/Index.cshtml");
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}