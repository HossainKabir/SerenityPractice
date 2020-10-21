namespace PracticeProject.Web.Modules.Reports.MovieDetails {
    export interface MovieDetailsRequestForm {
        MovieId: Serenity.LookupEditor;
    }

    export class MovieDetailsRequestForm extends Serenity.PrefixedContext {
        static formKey = 'Practice.MovieDetailsForm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MovieDetailsRequestForm.init)  {
                MovieDetailsRequestForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;

                Q.initFormType(MovieDetailsRequestForm, [
                    'MovieId', w0
                ]);
            }
        }
    }
}
