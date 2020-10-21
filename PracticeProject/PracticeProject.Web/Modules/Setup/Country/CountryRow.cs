
namespace PracticeProject.Setup.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Setup"), TableName("[setup].[Country]")]
    [DisplayName("Country"), InstanceName("Country")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Setup.Country")]
    public sealed class CountryRow : Row, IIdRow, INameRow
    {
        [DisplayName("Country Id"), Identity]
        public Int32? CountryId
        {
            get { return Fields.CountryId[this]; }
            set { Fields.CountryId[this] = value; }
        }

        [DisplayName("Country Name"), Size(100), NotNull, QuickSearch]
        public String CountryName
        {
            get { return Fields.CountryName[this]; }
            set { Fields.CountryName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CountryId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CountryName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CountryRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CountryId;
            public StringField CountryName;
        }
    }
}
