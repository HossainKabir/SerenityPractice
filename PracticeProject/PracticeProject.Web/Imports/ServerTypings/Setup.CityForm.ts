namespace PracticeProject.Setup {
    export interface CityForm {
        CountryId: Serenity.LookupEditor;
        CityName: Serenity.StringEditor;
    }

    export class CityForm extends Serenity.PrefixedContext {
        static formKey = 'Setup.City';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CityForm.init)  {
                CityForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;

                Q.initFormType(CityForm, [
                    'CountryId', w0,
                    'CityName', w1
                ]);
            }
        }
    }
}
