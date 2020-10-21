
namespace PracticeProject.Test.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Test.Test")]
    [BasedOnRow(typeof(Entities.TestRow), CheckNames = true)]
    public class TestForm
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public Int32 Class { get; set; }
    }
}