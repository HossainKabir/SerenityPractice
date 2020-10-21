
namespace PracticeProject.Setup.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Setup"), TableName("[setup].[District]")]
    [DisplayName("District"), InstanceName("District")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Setup.District")]
    public sealed class DistrictRow : Row, IIdRow, INameRow
    {
        [DisplayName("District Id"), Identity]
        public Int32? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }

        [DisplayName("District Name"), Size(100), NotNull, QuickSearch]
        public String DistrictName
        {
            get { return Fields.DistrictName[this]; }
            set { Fields.DistrictName[this] = value; }
        }

        [DisplayName("City"), NotNull, ForeignKey("[setup].[City]", "CityId"), LeftJoin("jCity"), TextualField("CityCityName")]
        [LookupInclude]
        public Int32? CityId
        {
            get { return Fields.CityId[this]; }
            set { Fields.CityId[this] = value; }
        }

        [DisplayName("City Name"), Expression("jCity.[CityName]")]
        public String CityName
        {
            get { return Fields.CityName[this]; }
            set { Fields.CityName[this] = value; }
        }

        [DisplayName("City Country Id"), Expression("jCity.[CountryId]")]
        public Int32? CityCountryId
        {
            get { return Fields.CityCountryId[this]; }
            set { Fields.CityCountryId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.DistrictId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.DistrictName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DistrictRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field DistrictId;
            public StringField DistrictName;
            public Int32Field CityId;

            public StringField CityName;
            public Int32Field CityCountryId;
        }
    }
}
