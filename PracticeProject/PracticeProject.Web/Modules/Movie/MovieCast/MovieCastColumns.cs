
namespace PracticeProject.Movie.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Movie.MovieCast")]
    [BasedOnRow(typeof(Entities.MovieCastRow), CheckNames = true)]
    public class MovieCastColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Int32 MovieCastId { get; set; }
        //public String MovieTitle { get; set; }
        //public String PersonFirstName { get; set; }
        [EditLink,Width(220)]
        public String PersonFullName { get; set; }
        [EditLink, Width(150)]
        public String Character { get; set; }
    }
}