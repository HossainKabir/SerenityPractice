using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace PracticeProject.Web.Modules.Reports.MovieDetails
{
    [/*RoutePrefix("Reports/MovieDetails"),*/ Route("Reports/MovieDetails"), PageAuthorize("Movie/Reports:MovieDetails:Navigation")]
    public class MovieDetailsController : Microsoft.AspNetCore.Mvc.Controller
    {
        public Microsoft.AspNetCore.Mvc.ActionResult Index()
        {
            return View(MVC.Views.Reports.MovieDetails.MovieDetailsIndex);
        }
    }
}
