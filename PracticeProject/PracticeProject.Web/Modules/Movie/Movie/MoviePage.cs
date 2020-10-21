
namespace PracticeProject.Movie.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.MovieRow))]
    public class MovieController : Controller
    {
        [Route("Movie/Movie")]
        public ActionResult Index()
        {
            return View("~/Modules/Movie/Movie/MovieIndex.cshtml");
        }
    }
}