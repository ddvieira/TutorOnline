using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
  public partial class InitialCreate : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.RenameTable(name: "User", newName: "Users");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.RenameTable(name: "User", schema: "dbo", newName: "Users", newSchema: "dbo");
    }
  }
}
