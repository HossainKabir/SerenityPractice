using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PracticeProject.Movie
{
    public partial class MovieCastEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "PracticeProject.Movie.MovieCastEditor";

        public MovieCastEditorAttribute()
            : base(Key)
        {
        }
    }
}
