using Microsoft.EntityFrameworkCore.Migrations;

namespace task_manager_data.Migrations
{
    public partial class fixmisprint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripion",
                table: "Projects",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Projects",
                newName: "Descripion");
        }
    }
}
