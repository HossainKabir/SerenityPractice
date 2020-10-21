namespace PracticeProject.Test {
    export interface TestForm {
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Class: Serenity.IntegerEditor;
    }

    export class TestForm extends Serenity.PrefixedContext {
        static formKey = 'Test.Test';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TestForm.init)  {
                TestForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(TestForm, [
                    'Name', w0,
                    'Description', w0,
                    'Class', w1
                ]);
            }
        }
    }
}
