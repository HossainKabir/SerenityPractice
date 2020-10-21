
namespace PracticeProject.Test {

    @Serenity.Decorators.registerClass()
    export class TestGrid extends Serenity.EntityGrid<TestRow, any> {
        protected getColumnsKey() { return 'Test.Test'; }
        protected getDialogType() { return TestDialog; }
        protected getIdProperty() { return TestRow.idProperty; }
        protected getInsertPermission() { return TestRow.insertPermission; }
        protected getLocalTextPrefix() { return TestRow.localTextPrefix; }
        protected getService() { return TestService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}