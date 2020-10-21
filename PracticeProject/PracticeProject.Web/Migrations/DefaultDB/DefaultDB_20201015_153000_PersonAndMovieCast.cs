using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeProject.Migrations.DefaultDB
{
    [Migration(20201015153000)]
    public class DefaultDB_20201015_153000_PersonAndMovieCast : Migration
    {
        public override void Down()
        {
        }

        public override void Up()
        {
            Create.Table("Person").InSchema("mov")
                .WithColumn("PersonId").AsInt32().Identity()
                .PrimaryKey().NotNullable()
                .WithColumn("FirstName").AsString(50).NotNullable()
                .WithColumn("LastName").AsString(50).NotNullable()
                .WithColumn("BirthDate").AsDateTime().Nullable()
                .WithColumn("BirthPlace").AsString(100).Nullable()
                .WithColumn("Gender").AsInt32().Nullable()
                .WithColumn("Height").AsInt32().Nullable();

            Create.Table("MovieCast").InSchema("mov")
                .WithColumn("MovieCastId").AsInt32().Identity()
                .PrimaryKey().NotNullable()
                .WithColumn("MovieId").AsInt32().NotNullable()
                .ForeignKey("FK_MovieCast_MovieId","mov","Movie","MovieId")
                .WithColumn("PersonId").AsInt32().NotNullable()
                .ForeignKey("FK_MovieCast_PersonId", "mov", "Person", "PersonId")
                .WithColumn("Character").AsString(50).Nullable();
        }
    }
}
