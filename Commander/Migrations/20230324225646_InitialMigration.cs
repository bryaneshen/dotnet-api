using Microsoft.EntityFrameworkCore.Migrations;

namespace Commander.Migrations
{
    // This class provides the steps that are going to be performed on our DB to create a table on the DB
    public partial class InitialMigration : Migration
    {
        // This method creates stuff
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // creates a table called Commands
            migrationBuilder.CreateTable(
                name: "Commands",
                columns: table => new
                { 
                    // Adding columns to the table here.
                    // the ID will be incremented by 1 automatically 
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HowTo = table.Column<string>(nullable: true),
                    Line = table.Column<string>(nullable: true),
                    Platform = table.Column<string>(nullable: true)
                },
                // adding constraint to table, setting the id as the primary key
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commands", x => x.Id);
                });
        }

        // This method deletes things
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commands");
        }
    }
}
