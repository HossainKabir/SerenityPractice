using PracticeProject.Movie.Entities;
using PracticeProject.Web.Modules.Common;
using Serenity.ComponentModel;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeProject.Web.Modules.Reports.MovieDetails
{
    [BasedOnRow(typeof(ReportParameterRow), CheckNames = true)]
    [FormScript("Practice.MovieDetailsForm")]
    public class MovieDetailsRequestForm
    {
        [HalfWidth(UntilNext = true)]
        public Int32? MovieId { get; set; }
    }
    public class MovieDetailsRequest : ServiceRequest
    {
        public Int32? MovieId { get; set; }

        public String MovieName { get; set; } = Texts.Controls.All;
    }
}
