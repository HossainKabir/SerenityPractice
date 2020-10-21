using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeProject.Migrations.DefaultDB
{
    [Migration(20201018140000)]
    public class DefaultDB_20201018_140000_CountryTable : Migration
    {
        public override void Down()
        {
        }

        public override void Up()
        {
            Create.Schema("setup");
            Create.Table("Country").InSchema("setup")
                .WithColumn("CountryId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("CountryName").AsString(100).NotNullable();
        }
    }
}
