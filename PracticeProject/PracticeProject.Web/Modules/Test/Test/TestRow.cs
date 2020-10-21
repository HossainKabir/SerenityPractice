
namespace PracticeProject.Test.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Test"), TableName("[dbo].[Test]")]
    [DisplayName("Test"), InstanceName("Test")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class TestRow : Row, IIdRow, INameRow
    {
        [DisplayName("Test Id"), Identity]
        public Int32? TestId
        {
            get { return Fields.TestId[this]; }
            set { Fields.TestId[this] = value; }
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Class"), NotNull]
        public Int32? Class
        {
            get { return Fields.Class[this]; }
            set { Fields.Class[this] = value; }
        }

        [DisplayName("Description"), Size(500), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.TestId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TestRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field TestId;
            public StringField Name;
            public Int32Field Class;
            public StringField Description;
        }
    }
}
