
namespace PracticeProject.Movie.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using PracticeProject.Web.Modules.Movie.Movie;

    [FormScript("Movie.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow), CheckNames = false)]
    public class MovieForm
    {
        public String Title { get; set; }

        [TextAreaEditor(Rows = 3)]
        public String Description { get; set; }

        [MovieCastEditor]
        public List<Entities.MovieCastRow> CastList { get; set; }

        [TextAreaEditor(Rows = 8)]
        public String StoryLine { get; set; }
        public Int32 Year { get; set; }
        public DateTime ReleaseDate { get; set; }

        public List<Int32> GenreList { get; set; }
        public Int32 Runtime { get; set; }
        //public Int32 GenreId { get; set; }
        public MovieKind Kind { get; set; }

        //[LookupEditor(typeof(Setup.Entities.CountryRow))]
        //[DisplayName("Country")]
        //public Int32 CountryId { set; get; }

        //[LookupEditor(typeof(Setup.Entities.CityRow),CascadeFrom ="CountryId",CascadeField = "CountryId")]
        //[DisplayName("City")]
        //public Int32 CityId { get; set; }

        //[LookupEditor(typeof(Setup.Entities.DistrictRow),CascadeFrom ="CityId",CascadeField ="CityId")]
        //[DisplayName("District")]
        //public Int32 DistrictId { get; set; }
    }
}