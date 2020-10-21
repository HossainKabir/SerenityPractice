
namespace PracticeProject.Movie.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.PersonRow))]
    public class PersonController : Controller
    {
        [Route("Movie/Person")]
        public ActionResult Index()
        {
            return View("~/Modules/Movie/Person/PersonIndex.cshtml");
        }
    }
}