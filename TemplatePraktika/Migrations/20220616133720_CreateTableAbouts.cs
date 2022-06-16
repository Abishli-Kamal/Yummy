using Microsoft.EntityFrameworkCore.Migrations;

namespace TemplatePraktika.Migrations
{
    public partial class CreateTableAbouts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoLink",
                table: "Abouts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoLink",
                table: "Abouts");
        }
    }
}
