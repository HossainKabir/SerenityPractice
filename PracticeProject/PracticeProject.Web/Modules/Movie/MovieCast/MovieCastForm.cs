
namespace PracticeProject.Movie.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Movie.MovieCast")]
    [BasedOnRow(typeof(Entities.MovieCastRow), CheckNames = true)]
    public class MovieCastForm
    {
        //public Int32 MovieId { get; set; }
        public Int32 PersonId { get; set; }
        //public String PersonFullName { get; set; }
        public String Character { get; set; }
    }
}