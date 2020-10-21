
namespace PracticeProject.Movie {

    @Serenity.Decorators.registerClass()
    export class MovieGrid extends Serenity.EntityGrid<MovieRow, any> {
        protected getColumnsKey() { return 'Movie.Movie'; }
        protected getDialogType() { return MovieDialog; }
        protected getIdProperty() { return MovieRow.idProperty; }
        protected getInsertPermission() { return MovieRow.insertPermission; }
        protected getLocalTextPrefix() { return MovieRow.localTextPrefix; }
        protected getService() { return MovieService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            return [{ name: "", title: "all" },
            { name: "Description", title: "description" },
            { name: "Storyline", title: "storyline" },
            { name: "Year", title: "year" }]
        }

        //protected getQuickFilters() {
        //    let items = super.getQuickFilters();

        //    var generateListFilter = Q.first(items, x => x.field == MovieRow.Fields.GenreList);

        //    generateListFilter.handler = h => {
        //        var request = (h.request as MovieListRequest);

        //        var values = (h.widget as Serenity.LookupEditor).values;
        //        request.Genre = values.map(x => parseInt(x, 10));
        //        h.handled = true;
        //    };

        //    return items;
        //}
    }

    @Serenity.Decorators.registerFormatter()
    export class GenereListFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext): string {
            let idList = ctx.value as number[];
            if (!idList || !idList.length)
                return "";

            let byId = GenreRow.getLookup().itemById;

            return idList.map(x => {
                let g = byId[x];
                if (!g)
                    return x.toString();

                return Q.htmlEncode(g.Name);
            }).join(", ");
        }

    }
}