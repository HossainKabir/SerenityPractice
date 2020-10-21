namespace PracticeProject.Setup {
    export interface CityRow {
        CityId?: number;
        CityName?: string;
        CountryId?: number;
        CountryName?: string;
    }

    export namespace CityRow {
        export const idProperty = 'CityId';
        export const nameProperty = 'CityName';
        export const localTextPrefix = 'Setup.City';
        export const lookupKey = 'Setup.City';

        export function getLookup(): Q.Lookup<CityRow> {
            return Q.getLookup<CityRow>('Setup.City');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            CityId = "CityId",
            CityName = "CityName",
            CountryId = "CountryId",
            CountryName = "CountryName"
        }
    }
}
