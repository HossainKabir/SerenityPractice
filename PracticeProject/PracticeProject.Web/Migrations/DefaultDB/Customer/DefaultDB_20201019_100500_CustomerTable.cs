using FluentMigrator;
using Serenity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeProject.Migrations.DefaultDB.Customer
{
    [Migration(20201019100500)]
    public class DefaultDB_20201019_100500_CustomerTable : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Schema("customer");
            Create.Table("Customer").InSchema("customer")
                .WithColumn("CustomerId").AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn("CustomerName").AsString(100).NotNullable()
                .WithColumn("CustomerAddress").AsString(500).NotNullable()
                .WithColumn("CustomerNumber").AsString(11).NotNullable()
                .WithColumn("DateOfBirth").AsDateTime().Nullable()
                .WithColumn("Image").AsGuid().Nullable();
        }
    }
}
