using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeProject.Migrations.DefaultDB
{
    [Migration(20201018150500)]
    public class DefaultDB_20201018_150500_CityTable : Migration
    {
        public override void Down()
        {
        }

        public override void Up()
        {
            Create.Table("City").InSchema("setup")
                .WithColumn("CityId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("CityName").AsString(100).NotNullable()
                .WithColumn("CountryId").AsInt32()
                .ForeignKey("FK_City_CountryId", "setup", "Country", "CountryId")
                .NotNullable();
        }
    }
}
