namespace PracticeProject.Movie {
    export interface MovieCastRow {
        MovieCastId?: number;
        MovieId?: number;
        PersonId?: number;
        Character?: string;
        MovieTitle?: string;
        MovieDescription?: string;
        MovieStoryLine?: string;
        MovieYear?: number;
        MovieReleaseDate?: string;
        MovieRuntime?: number;
        MovieKind?: number;
        PersonFirstName?: string;
        PersonLastName?: string;
        PersonFullName?: string;
        PersonBirthDate?: string;
        PersonBirthPlace?: string;
        PersonGender?: number;
        PersonHeight?: number;
    }

    export namespace MovieCastRow {
        export const idProperty = 'MovieCastId';
        export const nameProperty = 'Character';
        export const localTextPrefix = 'Movie.MovieCast';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            MovieCastId = "MovieCastId",
            MovieId = "MovieId",
            PersonId = "PersonId",
            Character = "Character",
            MovieTitle = "MovieTitle",
            MovieDescription = "MovieDescription",
            MovieStoryLine = "MovieStoryLine",
            MovieYear = "MovieYear",
            MovieReleaseDate = "MovieReleaseDate",
            MovieRuntime = "MovieRuntime",
            MovieKind = "MovieKind",
            PersonFirstName = "PersonFirstName",
            PersonLastName = "PersonLastName",
            PersonFullName = "PersonFullName",
            PersonBirthDate = "PersonBirthDate",
            PersonBirthPlace = "PersonBirthPlace",
            PersonGender = "PersonGender",
            PersonHeight = "PersonHeight"
        }
    }
}
