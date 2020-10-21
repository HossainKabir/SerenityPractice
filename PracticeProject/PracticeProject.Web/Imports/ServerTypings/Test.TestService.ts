namespace PracticeProject.Test {
    export namespace TestService {
        export const baseUrl = 'Test/Test';

        export declare function Create(request: Serenity.SaveRequest<TestRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<TestRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TestRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TestRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List2(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TestRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Test/Test/Create",
            Update = "Test/Test/Update",
            Delete = "Test/Test/Delete",
            Retrieve = "Test/Test/Retrieve",
            List = "Test/Test/List",
            List2 = "Test/Test/List2"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'List2'
        ].forEach(x => {
            (<any>TestService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
