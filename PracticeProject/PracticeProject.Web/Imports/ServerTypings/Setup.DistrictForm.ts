namespace PracticeProject.Setup {
    export interface DistrictForm {
        CityId: Serenity.LookupEditor;
        DistrictName: Serenity.StringEditor;
    }

    export class DistrictForm extends Serenity.PrefixedContext {
        static formKey = 'Setup.District';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DistrictForm.init)  {
                DistrictForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;

                Q.initFormType(DistrictForm, [
                    'CityId', w0,
                    'DistrictName', w1
                ]);
            }
        }
    }
}
