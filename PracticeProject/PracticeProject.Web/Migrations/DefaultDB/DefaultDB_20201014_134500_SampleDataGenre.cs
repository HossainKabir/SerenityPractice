using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeProject.Migrations.DefaultDB
{
    [Migration(20201014134500)]
    public class DefaultDB_20201014_134500_SampleDataGenre : Migration
    {
        public override void Down()
        {
        }

        public override void Up()
        {
            Insert.IntoTable("Genre").InSchema("mov")
                .Row(new { Name = "Action" })
                .Row(new { Name = "Drama" })
                .Row(new { Name = "Comedy" })
                .Row(new { Name = "Sci-fi" })
                .Row(new { Name = "Fantasy" })
                .Row(new { Name = "Documentary" });
        }
    }
}
