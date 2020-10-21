using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PracticeProject.Movie
{
    public partial class GenereListFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "PracticeProject.Movie.GenereListFormatter";

        public GenereListFormatterAttribute()
            : base(Key)
        {
        }
    }
}
