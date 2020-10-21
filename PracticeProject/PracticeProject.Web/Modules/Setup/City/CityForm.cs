
namespace PracticeProject.Setup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Setup.City")]
    [BasedOnRow(typeof(Entities.CityRow), CheckNames = true)]
    public class CityForm
    {
       

        //[LookupEditor(typeof(Entities.CountryRow), CascadeFrom ="CountryId",CascadeField ="CountryId")]
        [LookupEditor(typeof(Entities.CountryRow))]
        public Int32 CountryId { get; set; }
        public String CityName { get; set; }
    }
}