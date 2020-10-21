namespace PracticeProject.Movie {
    export interface PersonRow {
        PersonId?: number;
        FirstName?: string;
        LastName?: string;
        FullName?: string;
        BirthDate?: string;
        BirthPlace?: string;
        Gender?: Gender;
        Height?: number;
    }

    export namespace PersonRow {
        export const idProperty = 'PersonId';
        export const nameProperty = 'FullName';
        export const localTextPrefix = 'Movie.Person';
        export const lookupKey = 'Movie.Person';

        export function getLookup(): Q.Lookup<PersonRow> {
            return Q.getLookup<PersonRow>('Movie.Person');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            PersonId = "PersonId",
            FirstName = "FirstName",
            LastName = "LastName",
            FullName = "FullName",
            BirthDate = "BirthDate",
            BirthPlace = "BirthPlace",
            Gender = "Gender",
            Height = "Height"
        }
    }
}
