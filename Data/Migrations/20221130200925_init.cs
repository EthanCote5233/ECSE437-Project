using Microsoft.EntityFrameworkCore.Migrations;

namespace KannotEven.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    RecipeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Ingredient_Recipe_RecipeName",
                        column: x => x.RecipeName,
                        principalTable: "Recipe",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_RecipeName",
                table: "Ingredient",
                column: "RecipeName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Recipe");
        }
    }
}
