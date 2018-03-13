using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace mLizard.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : mLizardControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}