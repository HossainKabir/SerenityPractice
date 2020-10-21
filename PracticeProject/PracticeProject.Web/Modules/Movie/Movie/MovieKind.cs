using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeProject.Web.Modules.Movie.Movie
{
    [EnumKey("Movie.MovieKind")]
    public enum MovieKind
    {
        [Description("Film")]
        Film=1,
        [Description("TV Series")]
        TvSeries=2,
        [Description("Mini Series")]
        MiniSeries=3
    }
}
