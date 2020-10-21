
namespace PracticeProject.Movie {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PersonGrid extends Serenity.EntityGrid<PersonRow, any> {
        protected getColumnsKey() { return 'Movie.Person'; }
        protected getDialogType() { return PersonDialog; }
        protected getIdProperty() { return PersonRow.idProperty; }
        protected getInsertPermission() { return PersonRow.insertPermission; }
        protected getLocalTextPrefix() { return PersonRow.localTextPrefix; }
        protected getService() { return PersonService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}