/// <reference path='/Kabir/Others/Serenity Practice/PracticeProject/PracticeProject/PracticeProject.Web/Modules/_Ext/Bases/ReportPanelBase.ts' />
namespace PracticeProject.Web.Modules.Reports.MovieDetails
{
    @Serenity.Decorators.registerClass()
    export class MovieDetailsPanel extends _Ext.ReportPanelBase<MovieDetailsRequest>// ReportPanelBase<MovieDetailsRequest>
    {
        protected getReportKey() { return 'Practice.MovieDetails'; }
        protected getReportTitle() { return Q.text('Movie Details'); }

        protected getFormKey() { return MovieDetailsRequestForm.formKey; }

        private form: MovieDetailsRequestForm = new MovieDetailsRequestForm(this.idPrefix);

        constructor(container: JQuery) {
            super(container);
            //let user = Authorization.userDefinition;

        }

        protected getReportRequest() {
            var request = this.getSaveEntity();
            request.MovieName = this.form.MovieId.text;
            return request;
        }
    }
}