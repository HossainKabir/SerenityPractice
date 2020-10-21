
namespace PracticeProject.Movie.Entities
{
    using PracticeProject.Web.Modules.Movie.Movie;
    using PracticeProject.Web;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Movie"), TableName("[mov].[Movie]")]
    [DisplayName("Movies"), InstanceName("Movie")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Movie.Movie")]
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        [DisplayName("Movie Id"), Identity]
        public Int32? MovieId
        {
            get { return Fields.MovieId[this]; }
            set { Fields.MovieId[this] = value; }
        }

        [DisplayName("Title"), Size(200), NotNull, QuickSearch]
        public String Title
        {
            get { return Fields.Title[this]; }
            set { Fields.Title[this] = value; }
        }

        [DisplayName("Description"), Size(1000)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Story Line")]
        public String StoryLine
        {
            get { return Fields.StoryLine[this]; }
            set { Fields.StoryLine[this] = value; }
        }

        [DisplayName("Year")]
        public Int32? Year
        {
            get { return Fields.Year[this]; }
            set { Fields.Year[this] = value; }
        }

        [DisplayName("Release Date")]
        public DateTime? ReleaseDate
        {
            get { return Fields.ReleaseDate[this]; }
            set { Fields.ReleaseDate[this] = value; }
        }

        [DisplayName("Runtime (mins)")]
        public Int32? Runtime
        {
            get { return Fields.Runtime[this]; }
            set { Fields.Runtime[this] = value; }
        }

        [DisplayName("Kind"),NotNull]
        public MovieKind? Kind
        { 
            get { return (MovieKind?)Fields.Kind[this]; }
            set { Fields.Kind[this] = (Int32?)value; } 
        }

        [DisplayName("Genres")]
        [LookupEditor(typeof(GenreRow),Multiple =true), NotMapped]
        [LinkingSetRelation(typeof(MovieGenresRow),"MovieId","GenreId")]
        public List<Int32> GenreList { set { Fields.GenreList[this] = value; } get { return Fields.GenreList[this]; } }

        //[LinkingSetRelation(typeof(MovieGenresRow),"MovieId","GenreId")]
        [MasterDetailRelation(foreignKey:"MovieId",IncludeColumns ="PersonFullName")]
        [DisplayName("Cast List"), NotMapped]
        public List<MovieCastRow> CastList { set { Fields.CastList[this] = value; } get { return Fields.CastList[this]; } }
        //[DisplayName("Genre"), ForeignKey("[mov].Genre","GenreId"), LeftJoin("g")]
        //[LookupEditor("Movie.Genre")]
        //[LookupEditor(typeof(GenreRow),InplaceAdd =true)]
        //public Int32? GenreId 
        //{ 
        //    get { return Fields.GenreId[this]; } 
        //    set { Fields.GenreId[this] = value; } 
        //}
        //[DisplayName("Genre"),Expression("g.Name")]
        //public String GenreName
        //{
        //    get { return Fields.GenreName[this]; }
        //    set { Fields.GenreName[this] = value; }
        //}

        [LookupEditor(typeof(Setup.Entities.CountryRow))]
        public Int32 CountryId { set; get; }

        IIdField IIdRow.IdField
        {
            get { return Fields.MovieId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Title; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MovieRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieId;
            public StringField Title;
            public StringField Description;
            public StringField StoryLine;
            public Int32Field Year;
            public DateTimeField ReleaseDate;
            public Int32Field Runtime;
            public Int32Field Kind;
            //public Int32Field GenreId;
            //public StringField GenreName;
            public ListField<Int32> GenreList;
            //public ListField<MovieCastRow> CastList;
            public readonly RowListField<MovieCastRow> CastList;
        }
    }
}
