namespace PracticeProject.Movie.Repositories {
    export interface MovieListRequest extends Serenity.ListRequest {
        Genres?: number[];
    }
}
