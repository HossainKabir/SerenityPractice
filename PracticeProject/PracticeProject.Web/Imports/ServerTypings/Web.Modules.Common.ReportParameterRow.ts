namespace PracticeProject.Web.Modules.Common {
    export interface ReportParameterRow {
        MovieId?: number;
    }

    export namespace ReportParameterRow {
        export const localTextPrefix = 'Web.Modules.Common.ReportParameter';
        export const deletePermission = null;
        export const insertPermission = null;
        export const readPermission = '';
        export const updatePermission = null;

        export declare const enum Fields {
            MovieId = "MovieId"
        }
    }
}
