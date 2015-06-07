using System.Web.Mvc;

namespace sessionliang_EF.Web.Controllers
{
    public class HomeController : sessionliang_EFControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}