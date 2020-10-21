
namespace PracticeProject.Setup.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.CountryRow))]
    public class CountryController : Controller
    {
        [Route("Setup/Country")]
        public ActionResult Index()
        {
            return View("~/Modules/Setup/Country/CountryIndex.cshtml");
        }
    }
}