using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using PracticeProject.Movie.Entities;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeProject.Web.Modules.Common
{
    public class ReportParameterRow : Serenity.Data.Row
    {
        [DisplayName("Movie")]
        [LookupEditor(typeof(MovieRow))]
        public Int32? MovieId { get; set; }

        public partial class RowFields { public Int32Field MovieId; }

        public static readonly RowFields fields = new RowFields().Init();
        public ReportParameterRow() : base(fields){}

        public partial class RowFields : RowFieldsBase { }
    }
}
