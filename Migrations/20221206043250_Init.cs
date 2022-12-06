using Microsoft.EntityFrameworkCore.Migrations;

namespace KannotEven.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Recipes_Ingredient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeName = table.Column<string>(nullable: true),
                    IngredientName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes_Ingredient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Ingredient_Ingredient_IngredientName",
                        column: x => x.IngredientName,
                        principalTable: "Ingredient",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipes_Ingredient_Recipe_RecipeName",
                        column: x => x.RecipeName,
                        principalTable: "Recipe",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                column: "Name",
                values: new object[]
                {
                    "I0",
                    "I1",
                    "I2",
                    "I3",
                    "I4",
                    "I5",
                    "I6",
                    "I7",
                    "I8"
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Name", "URL" },
                values: new object[,]
                {
                    { "R0", "www.test0.com" },
                    { "R1", "www.test1.com" },
                    { "R2", "www.test2.com" }
                });

            migrationBuilder.InsertData(
                table: "Recipes_Ingredient",
                columns: new[] { "Id", "IngredientName", "RecipeName" },
                values: new object[,]
                {
                    { 2, "I0", "R0" },
                    { 3, "I1", "R0" },
                    { 4, "I2", "R0" },
                    { 5, "I3", "R1" },
                    { 6, "I4", "R1" },
                    { 7, "I5", "R1" },
                    { 8, "I6", "R2" },
                    { 9, "I7", "R2" },
                    { 10, "I8", "R2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_Ingredient_IngredientName",
                table: "Recipes_Ingredient",
                column: "IngredientName");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_Ingredient_RecipeName",
                table: "Recipes_Ingredient",
                column: "RecipeName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes_Ingredient");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Recipe");
        }
    }
}
