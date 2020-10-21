﻿namespace PracticeProject.Movie {
    export interface MovieForm {
        Title: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        CastList: MovieCastEditor;
        StoryLine: Serenity.TextAreaEditor;
        Year: Serenity.IntegerEditor;
        ReleaseDate: Serenity.DateEditor;
        GenreList: Serenity.LookupEditor;
        Runtime: Serenity.IntegerEditor;
        Kind: Serenity.EnumEditor;
    }

    export class MovieForm extends Serenity.PrefixedContext {
        static formKey = 'Movie.Movie';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MovieForm.init)  {
                MovieForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = MovieCastEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.DateEditor;
                var w5 = s.LookupEditor;
                var w6 = s.EnumEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'Description', w1,
                    'CastList', w2,
                    'StoryLine', w1,
                    'Year', w3,
                    'ReleaseDate', w4,
                    'GenreList', w5,
                    'Runtime', w3,
                    'Kind', w6
                ]);
            }
        }
    }
}
