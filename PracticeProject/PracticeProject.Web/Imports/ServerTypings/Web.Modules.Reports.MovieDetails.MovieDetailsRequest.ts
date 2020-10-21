namespace PracticeProject.Web.Modules.Reports.MovieDetails {
    export interface MovieDetailsRequest extends Serenity.ServiceRequest {
        MovieId?: number;
        MovieName?: string;
    }
}
