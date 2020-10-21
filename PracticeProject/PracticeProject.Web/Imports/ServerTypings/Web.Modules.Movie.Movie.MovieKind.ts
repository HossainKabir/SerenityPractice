namespace PracticeProject.Web.Modules.Movie.Movie {
    export enum MovieKind {
        Film = 1,
        TvSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnumType(MovieKind, 'PracticeProject.Web.Modules.Movie.Movie.MovieKind', 'Movie.MovieKind');
}
