using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeProject.Migrations.DefaultDB
{
    [Migration(20201014124500)]
    public class DefaultDB_20201014_124500_MovieKind : Migration
    {
        public override void Down()
        {
        }

        public override void Up()
        {
            Alter.Table("Movie").InSchema("mov")
                .AddColumn("Kind").AsInt32().NotNullable()
                .WithDefaultValue(1);
        }
    }
}
