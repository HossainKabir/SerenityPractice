using _Ext;
using PracticeProject.Movie.Entities;
using Serenity.Data;
using Serenity.Reporting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeProject.Web.Modules.Reports.MovieDetails
{
    [Report("Practice.MovieDetails")]
    [ReportDesign(MVC.Views.Reports.MovieDetails.MovieDetailsReport)]
    public class MovieDetailsReport : ListReportBase, IReport
    {
        public new MovieDetailsRequest Request { get; set; }
        public object GetData()
        {
            using (var connection = SqlConnections.NewFor<MovieRow>())
            {
                return new MovieDetailsModel(connection, Request);
            }
        }
    }

    public class MovieDetailsModel
    {
        public List<MovieDetailsItem> ItemList { get; set; } = new List<MovieDetailsItem>();
        public new MovieDetailsRequest Request { get; set; }

        public MovieDetailsModel(IDbConnection connection, MovieDetailsRequest request)
        {
            Request = request;

            var mId = MovieRow.Fields.As("m");
            var mgId = MovieGenresRow.Fields.As("mg");
            var pId = PersonRow.Fields.As("p");

            var mcId = MovieCastRow.Fields.As("mc");
            var query= new SqlQuery();
            if (request.MovieId!=null)
            {
                query = new SqlQuery().From(mId)
                    .Select(mId.Title)
                    .Select(mId.Runtime)
                    .Select(mId.ReleaseDate)
                    .Select(mId.Description)
                    .Where(mId.MovieId == (Int16)request.MovieId);
            }
            else
            {
                query = new SqlQuery().From(mId)
                    .Select(mId.Title)
                    .Select(mId.Runtime)
                    .Select(mId.ReleaseDate)
                    .Select(mId.Description);
            }

            ItemList = connection.Query<MovieDetailsItem>(query).ToList();
        }
    }

    public class MovieDetailsItem
    {
        public String Title { get; set; }
        public String Runtime { get; set; }
        public String Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
