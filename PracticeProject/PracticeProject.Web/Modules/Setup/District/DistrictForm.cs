
namespace PracticeProject.Setup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Setup.District")]
    [BasedOnRow(typeof(Entities.DistrictRow), CheckNames = true)]
    public class DistrictForm
    {
        [LookupEditor(typeof(Entities.CityRow))]
        public Int32 CityId { get; set; }
        public String DistrictName { get; set; }

    }
}