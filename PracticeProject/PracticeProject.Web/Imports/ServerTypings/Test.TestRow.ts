namespace PracticeProject.Test {
    export interface TestRow {
        TestId?: number;
        Name?: string;
        Class?: number;
        Description?: string;
    }

    export namespace TestRow {
        export const idProperty = 'TestId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Test.Test';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            TestId = "TestId",
            Name = "Name",
            Class = "Class",
            Description = "Description"
        }
    }
}
