
namespace PracticeProject.Test {

    @Serenity.Decorators.registerClass()
    export class TestDialog extends Serenity.EntityDialog<TestRow, any> {
        protected getFormKey() { return TestForm.formKey; }
        protected getIdProperty() { return TestRow.idProperty; }
        protected getLocalTextPrefix() { return TestRow.localTextPrefix; }
        protected getNameProperty() { return TestRow.nameProperty; }
        protected getService() { return TestService.baseUrl; }
        protected getDeletePermission() { return TestRow.deletePermission; }
        protected getInsertPermission() { return TestRow.insertPermission; }
        protected getUpdatePermission() { return TestRow.updatePermission; }

        protected form = new TestForm(this.idPrefix);

    }
}