using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeProject.Migrations.DefaultDB
{
    [Migration(20201018153000)]
    public class DefaultDB_20201018_153000_DistrictTable : Migration
    {
        public override void Down()
        {

        }

        public override void Up()
        {
            Create.Table("District").InSchema("setup")
                .WithColumn("DistrictId").AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn("DistrictName").AsString(100).NotNullable()
                .WithColumn("CityId").AsInt32().NotNullable()
                .ForeignKey("FK_District_CityId", "setup", "City", "CityId");
        }
    }
}
