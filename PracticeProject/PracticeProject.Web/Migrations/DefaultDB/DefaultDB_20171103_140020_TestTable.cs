using FluentMigrator;
using System;

namespace PracticeProject.Migrations.DefaultDB
{

    [Migration(20171103140020)]
    public class DefaultDB_20171103_140020_TestTable : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Test", "TestId", s => s
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Class").AsInt32().NotNullable()
                .WithColumn("Description").AsString(500).NotNullable());

        }
    }
}