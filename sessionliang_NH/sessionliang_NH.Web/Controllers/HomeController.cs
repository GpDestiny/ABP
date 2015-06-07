using System.Web.Mvc;

namespace sessionliang_NH.Web.Controllers
{
    public class HomeController : sessionliang_NHControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}