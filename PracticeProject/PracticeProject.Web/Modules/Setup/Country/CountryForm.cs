
namespace PracticeProject.Setup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Setup.Country")]
    [BasedOnRow(typeof(Entities.CountryRow), CheckNames = true)]
    public class CountryForm
    {
        public String CountryName { get; set; }
    }
}