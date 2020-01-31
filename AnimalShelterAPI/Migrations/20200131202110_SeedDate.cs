using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterAPI.Migrations
{
    public partial class SeedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 7, "Domestic Loghair", "Female", "Carlo", "Cat" },
                    { 2, 5, "Pitbull", "Female", "Pepper", "Dog" },
                    { 3, 2, "Domestic Shorthair", "Female", "Ivy", "Cat" },
                    { 4, 4, "Chihuahua", "Male", "Harry", "Dog" },
                    { 5, 0, "Pitbull", "Male", "Oreo", "Dog" },
                    { 6, 1, "Domestic Longhair", "Female", "Henry", "Cat" },
                    { 7, 3, "Main Coon", "Female", "Finny", "Cat" },
                    { 8, 4, "Domestic Longhair", "Female", "Salt", "Cat" },
                    { 9, 2, "German Shepherd", "Male", "Hachi", "Dog" },
                    { 10, 9, "Domestic Shorthair", "Male", "Charlie", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);
        }
    }
}
