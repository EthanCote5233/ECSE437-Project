using Microsoft.EntityFrameworkCore.Migrations;

namespace KannotEven.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ingredient",
                column: "Name",
                values: new object[]
                {
                    "I0",
                    "I32",
                    "I33",
                    "I34",
                    "I35",
                    "I36",
                    "I37",
                    "I38",
                    "I40",
                    "I41",
                    "I42",
                    "I43",
                    "I44",
                    "I45",
                    "I46",
                    "I47",
                    "I48",
                    "I49",
                    "I50",
                    "I51",
                    "I52",
                    "I53",
                    "I54",
                    "I55",
                    "I56",
                    "I57",
                    "I58",
                    "I59",
                    "I31",
                    "I30",
                    "I39",
                    "I28",
                    "I1",
                    "I2",
                    "I3",
                    "I4",
                    "I29",
                    "I6",
                    "I7",
                    "I8",
                    "I9",
                    "I10",
                    "I11",
                    "I12",
                    "I13",
                    "I14",
                    "I5",
                    "I16",
                    "I15",
                    "I27",
                    "I26",
                    "I24",
                    "I23",
                    "I22",
                    "I25",
                    "I20",
                    "I19",
                    "I18",
                    "I17",
                    "I21"
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Name", "URL" },
                values: new object[,]
                {
                    { "R17", "www.test17.com" },
                    { "R10", "www.test10.com" },
                    { "R16", "www.test16.com" },
                    { "R15", "www.test15.com" },
                    { "R14", "www.test14.com" },
                    { "R13", "www.test13.com" },
                    { "R12", "www.test12.com" },
                    { "R11", "www.test11.com" },
                    { "R9", "www.test9.com" },
                    { "R3", "www.test3.com" },
                    { "R7", "www.test7.com" },
                    { "R6", "www.test6.com" },
                    { "R5", "www.test5.com" },
                    { "R4", "www.test4.com" },
                    { "R2", "www.test2.com" },
                    { "R1", "www.test1.com" },
                    { "R0", "www.test0.com" },
                    { "R18", "www.test18.com" },
                    { "R8", "www.test8.com" },
                    { "R19", "www.test19.com" }
                });

            migrationBuilder.InsertData(
                table: "Recipes_Ingredient",
                columns: new[] { "Id", "IngredientName", "RecipeName" },
                values: new object[,]
                {
                    { 59, "I58", "R20" },
                    { 31, "I30", "R10" },
                    { 32, "I31", "R11" },
                    { 33, "I32", "R11" },
                    { 34, "I33", "R11" },
                    { 35, "I34", "R12" },
                    { 36, "I35", "R12" },
                    { 37, "I36", "R12" },
                    { 38, "I37", "R13" },
                    { 39, "I38", "R13" },
                    { 40, "I39", "R13" },
                    { 41, "I40", "R14" },
                    { 42, "I41", "R14" },
                    { 30, "I29", "R10" },
                    { 43, "I42", "R14" },
                    { 45, "I44", "R15" },
                    { 46, "I45", "R15" },
                    { 47, "I46", "R16" },
                    { 48, "I47", "R16" },
                    { 49, "I48", "R16" },
                    { 50, "I49", "R17" },
                    { 51, "I50", "R17" },
                    { 52, "I51", "R17" },
                    { 53, "I52", "R18" },
                    { 54, "I53", "R18" },
                    { 55, "I54", "R18" },
                    { 56, "I55", "R19" },
                    { 44, "I43", "R15" },
                    { 29, "I28", "R10" },
                    { 28, "I27", "R9" },
                    { 27, "I26", "R9" },
                    { 60, "I59", "R20" },
                    { 1, "I0", "R0" },
                    { 2, "I1", "R1" },
                    { 3, "I2", "R1" },
                    { 4, "I3", "R1" },
                    { 5, "I4", "R2" },
                    { 6, "I5", "R2" },
                    { 7, "I6", "R2" },
                    { 8, "I7", "R3" },
                    { 9, "I8", "R3" },
                    { 10, "I9", "R3" },
                    { 11, "I10", "R4" },
                    { 12, "I11", "R4" },
                    { 13, "I12", "R4" },
                    { 14, "I13", "R5" },
                    { 15, "I14", "R5" },
                    { 16, "I15", "R5" },
                    { 17, "I16", "R6" },
                    { 18, "I17", "R6" },
                    { 19, "I18", "R6" },
                    { 20, "I19", "R7" },
                    { 21, "I20", "R7" },
                    { 22, "I21", "R7" },
                    { 23, "I22", "R8" },
                    { 24, "I23", "R8" },
                    { 25, "I24", "R8" },
                    { 26, "I25", "R9" },
                    { 57, "I56", "R19" },
                    { 58, "I57", "R19" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Recipes_Ingredient",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I0");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I1");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I10");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I11");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I12");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I13");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I14");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I15");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I16");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I17");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I18");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I19");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I2");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I20");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I21");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I22");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I23");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I24");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I25");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I26");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I27");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I28");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I29");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I3");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I30");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I31");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I32");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I33");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I34");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I35");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I36");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I37");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I38");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I39");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I4");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I40");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I41");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I42");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I43");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I44");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I45");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I46");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I47");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I48");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I49");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I5");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I50");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I51");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I52");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I53");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I54");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I55");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I56");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I57");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I58");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I59");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I6");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I7");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I8");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Name",
                keyValue: "I9");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R0");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R1");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R10");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R11");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R12");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R13");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R14");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R15");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R16");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R17");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R18");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R19");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R2");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R3");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R4");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R5");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R6");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R7");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R8");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Name",
                keyValue: "R9");
        }
    }
}
