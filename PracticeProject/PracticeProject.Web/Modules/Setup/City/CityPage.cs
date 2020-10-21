
namespace PracticeProject.Setup.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.CityRow))]
    public class CityController : Controller
    {
        [Route("Setup/City")]
        public ActionResult Index()
        {
            return View("~/Modules/Setup/City/CityIndex.cshtml");
        }
    }
}