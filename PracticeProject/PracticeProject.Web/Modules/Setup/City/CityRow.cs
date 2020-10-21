
namespace PracticeProject.Setup.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Setup"), TableName("[setup].[City]")]
    [DisplayName("City"), InstanceName("City")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Setup.City")]
    public sealed class CityRow : Row, IIdRow, INameRow
    {
        [DisplayName("City Id"), Identity]
        public Int32? CityId
        {
            get { return Fields.CityId[this]; }
            set { Fields.CityId[this] = value; }
        }

        [DisplayName("City Name"), Size(100), NotNull, QuickSearch]
        public String CityName
        {
            get { return Fields.CityName[this]; }
            set { Fields.CityName[this] = value; }
        }

        [DisplayName("Country"), NotNull, ForeignKey("[setup].[Country]", "CountryId"), LeftJoin("jCountry"), TextualField("CountryCountryName")]
        [LookupInclude]
        public Int32? CountryId
        {
            get { return Fields.CountryId[this]; }
            set { Fields.CountryId[this] = value; }
        }

        [DisplayName("Country Name"), Expression("jCountry.[CountryName]")]
        public String CountryName
        {
            get { return Fields.CountryName[this]; }
            set { Fields.CountryName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CityId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CityName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CityRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CityId;
            public StringField CityName;
            public Int32Field CountryId;

            public StringField CountryName;
        }
    }
}
