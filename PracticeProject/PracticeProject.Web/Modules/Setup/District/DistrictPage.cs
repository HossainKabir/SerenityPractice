
namespace PracticeProject.Setup.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.DistrictRow))]
    public class DistrictController : Controller
    {
        [Route("Setup/District")]
        public ActionResult Index()
        {
            return View("~/Modules/Setup/District/DistrictIndex.cshtml");
        }
    }
}