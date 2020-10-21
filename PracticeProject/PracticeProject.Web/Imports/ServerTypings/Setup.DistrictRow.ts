namespace PracticeProject.Setup {
    export interface DistrictRow {
        DistrictId?: number;
        DistrictName?: string;
        CityId?: number;
        CityName?: string;
        CityCountryId?: number;
    }

    export namespace DistrictRow {
        export const idProperty = 'DistrictId';
        export const nameProperty = 'DistrictName';
        export const localTextPrefix = 'Setup.District';
        export const lookupKey = 'Setup.District';

        export function getLookup(): Q.Lookup<DistrictRow> {
            return Q.getLookup<DistrictRow>('Setup.District');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            DistrictId = "DistrictId",
            DistrictName = "DistrictName",
            CityId = "CityId",
            CityName = "CityName",
            CityCountryId = "CityCountryId"
        }
    }
}
