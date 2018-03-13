using System.Web.Mvc;

namespace mLizard.Web.Controllers
{
    public class AboutController : mLizardControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}