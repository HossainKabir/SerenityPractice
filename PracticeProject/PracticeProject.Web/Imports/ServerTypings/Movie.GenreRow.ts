namespace PracticeProject.Movie {
    export interface GenreRow {
        GenreId?: number;
        Name?: string;
    }

    export namespace GenreRow {
        export const idProperty = 'GenreId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Movie.Genre';
        export const lookupKey = 'Movie.Genre';

        export function getLookup(): Q.Lookup<GenreRow> {
            return Q.getLookup<GenreRow>('Movie.Genre');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            GenreId = "GenreId",
            Name = "Name"
        }
    }
}
