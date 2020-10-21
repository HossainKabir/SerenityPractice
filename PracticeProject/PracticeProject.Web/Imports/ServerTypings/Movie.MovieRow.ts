namespace PracticeProject.Movie {
    export interface MovieRow {
        MovieId?: number;
        Title?: string;
        Description?: string;
        StoryLine?: string;
        Year?: number;
        ReleaseDate?: string;
        Runtime?: number;
        Kind?: Web.Modules.Movie.Movie.MovieKind;
        GenreList?: number[];
        CastList?: MovieCastRow[];
    }

    export namespace MovieRow {
        export const idProperty = 'MovieId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'Movie.Movie';
        export const lookupKey = 'Movie.Movie';

        export function getLookup(): Q.Lookup<MovieRow> {
            return Q.getLookup<MovieRow>('Movie.Movie');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            MovieId = "MovieId",
            Title = "Title",
            Description = "Description",
            StoryLine = "StoryLine",
            Year = "Year",
            ReleaseDate = "ReleaseDate",
            Runtime = "Runtime",
            Kind = "Kind",
            GenreList = "GenreList",
            CastList = "CastList"
        }
    }
}
