
namespace PracticeProject.Movie.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Movie.Genre")]
    [BasedOnRow(typeof(Entities.GenreRow), CheckNames = true)]
    public class GenreForm
    {
        public String Name { get; set; }
    }
}