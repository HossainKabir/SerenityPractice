namespace PracticeProject.Setup {
    export interface CountryRow {
        CountryId?: number;
        CountryName?: string;
    }

    export namespace CountryRow {
        export const idProperty = 'CountryId';
        export const nameProperty = 'CountryName';
        export const localTextPrefix = 'Setup.Country';
        export const lookupKey = 'Setup.Country';

        export function getLookup(): Q.Lookup<CountryRow> {
            return Q.getLookup<CountryRow>('Setup.Country');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            CountryId = "CountryId",
            CountryName = "CountryName"
        }
    }
}
