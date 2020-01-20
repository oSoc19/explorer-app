using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class fixGriffieImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 142L,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Vrouwe_Justitia-beeld_op_de_Civiele_Griffie%2C_Burg_11_2%2C_Brugge.JPG/768px-Vrouwe_Justitia-beeld_op_de_Civiele_Griffie%2C_Burg_11_2%2C_Brugge.JPG");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 143L,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Vrouwe_Justitia-beeld_op_de_Civiele_Griffie%2C_Burg_11_2%2C_Brugge.JPG/768px-Vrouwe_Justitia-beeld_op_de_Civiele_Griffie%2C_Burg_11_2%2C_Brugge.JPG");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 144L,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Vrouwe_Justitia-beeld_op_de_Civiele_Griffie%2C_Burg_11_2%2C_Brugge.JPG/768px-Vrouwe_Justitia-beeld_op_de_Civiele_Griffie%2C_Burg_11_2%2C_Brugge.JPG");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 145L,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Vrouwe_Justitia-beeld_op_de_Civiele_Griffie%2C_Burg_11_2%2C_Brugge.JPG/768px-Vrouwe_Justitia-beeld_op_de_Civiele_Griffie%2C_Burg_11_2%2C_Brugge.JPG");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 146L,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Vrouwe_Justitia-beeld_op_de_Civiele_Griffie%2C_Burg_11_2%2C_Brugge.JPG/768px-Vrouwe_Justitia-beeld_op_de_Civiele_Griffie%2C_Burg_11_2%2C_Brugge.JPG");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 142L,
                column: "ImageUrl",
                value: "https://commons.wikimedia.org/wiki/File:Vrouwe_Justitia-beeld_op_de_Civiele_Griffie,_Burg_11_2,_Brugge.JPG");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 143L,
                column: "ImageUrl",
                value: "https://commons.wikimedia.org/wiki/File:Vrouwe_Justitia-beeld_op_de_Civiele_Griffie,_Burg_11_2,_Brugge.JPG");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 144L,
                column: "ImageUrl",
                value: "https://commons.wikimedia.org/wiki/File:Vrouwe_Justitia-beeld_op_de_Civiele_Griffie,_Burg_11_2,_Brugge.JPG");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 145L,
                column: "ImageUrl",
                value: "https://commons.wikimedia.org/wiki/File:Vrouwe_Justitia-beeld_op_de_Civiele_Griffie,_Burg_11_2,_Brugge.JPG");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 146L,
                column: "ImageUrl",
                value: "https://commons.wikimedia.org/wiki/File:Vrouwe_Justitia-beeld_op_de_Civiele_Griffie,_Burg_11_2,_Brugge.JPG");
        }
    }
}
