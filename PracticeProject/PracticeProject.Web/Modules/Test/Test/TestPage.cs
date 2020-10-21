
namespace PracticeProject.Test.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.TestRow))]
    public class TestController : Controller
    {
        [Route("Test/Test")]
        public ActionResult Index()
        {
            return View("~/Modules/Test/Test/TestIndex.cshtml");
        }
    }
}