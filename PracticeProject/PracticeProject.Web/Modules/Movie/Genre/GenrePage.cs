
namespace PracticeProject.Movie.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.GenreRow))]
    public class GenreController : Controller
    {
        [Route("Movie/Genre")]
        public ActionResult Index()
        {
            return View("~/Modules/Movie/Genre/GenreIndex.cshtml");
        }
    }
}