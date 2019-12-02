using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class spaansWordWrapTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Description",
                value: "El Barroco fue un período de la historia en la cultura occidental originado por una nueva forma de concebir el arte (el «estilo barroco») y que, partiendo desde diferentes contextos histórico-culturales, produjo obras en numerosos campos artísticos: literatura, arquitectura, escultura, pintura, música, ópera, danza, teatro, etc. Se manifestó principalmente en la Europa occidental, aunque debido al colonialismo también se dio en numerosas colonias de las potencias europeas, principalmente en Latinoamérica. Cronológicamente, abarcó todo el siglo XVII y principios del XVIII, con mayor o menor prolongación en el tiempo dependiendo de cada país. Se suele situar entre el Manierismo y el Rococó, en una época caracterizada por fuertes disputas religiosas entre países católicos y protestantes, así como marcadas diferencias políticas entre los Estados absolutistas y los parlamentarios, donde una incipiente burguesía empezaba a poner los cimientos del capitalismo. ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Description",
                value: "El Barroco fue un período de la historia en la cultura occidental originado por una nueva forma de concebir el arte (el «estilo barroco») y que, partiendo desde diferentes contextos histórico-culturales, produjo obras en numerosos campos artísticos: literatura, arquitectura, escultura, pintura, música, ópera, danza, teatro, etc. Se manifestó principalmente en la Europa occidental, aunque debido al colonialismo también se dio en numerosas colonias de las potencias europeas, principalmente en Latinoamérica. Cronológicamente, abarcó todo el siglo XVII y principios del XVIII, con mayor o menor prolongación en el tiempo dependiendo de cada país. Se suele situar entre el Manierismo y el Rococó, en una época caracterizada por fuertes disputas religiosas entre países católicos y protestantes, así como marcadas diferencias políticas entre los Estados absolutistas y los parlamentarios, donde una incipiente burguesía empezaba a poner los cimientos del capitalismo. ");
        }
    }
}
