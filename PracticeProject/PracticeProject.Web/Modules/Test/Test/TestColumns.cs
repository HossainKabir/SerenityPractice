
namespace PracticeProject.Test.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Test.Test")]
    [BasedOnRow(typeof(Entities.TestRow), CheckNames = true)]
    public class TestColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Hidden]
        public Int32 TestId { get; set; }
        [EditLink]
        public String Name { get; set; }
        public Int32 Class { get; set; }
        public String Description { get; set; }
    }
}