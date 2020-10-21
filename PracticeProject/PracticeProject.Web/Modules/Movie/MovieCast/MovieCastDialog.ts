
namespace PracticeProject.Movie {

    @Serenity.Decorators.registerClass()
    export class MovieCastDialog extends Common.GridEditorDialog<MovieCastRow> {
        protected getFormKey() { return MovieCastForm.formKey; }
        protected getIdProperty() { return MovieCastRow.idProperty; }
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }
        protected getNameProperty() { return MovieCastRow.nameProperty; }

        protected form = new MovieCastForm(this.idPrefix);

    }
}