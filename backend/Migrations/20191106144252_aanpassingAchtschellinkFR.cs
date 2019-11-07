using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class aanpassingAchtschellinkFR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Description",
                value: "Lucas Achtschellinck est un peintre brabançon baroque spécialisé dans la peinture de paysages. Il est né à Bruxelles en 1626, fut baptisé le 16 janvier de la même année. Il entre dans la guilde des peintres le 29 octobre 1639 comme élève de Pieter van der Borcht. En 1655, à la mort de Lodewijk de Vadder, il pose sa candidature pour devenir cartonnier privilégié de la ville de Bruxelles. Un voyage à l'étranger peut être envisagé, puisqu'il n'est admis maître qu'en 1657. En 1659, il reçoit 120 florins pour un tableau exécuté à Sainte Gudule. En 1660 Corneille de Bie publie le Gulden Cabinet6 dans lequel il décrit le style de Lucas Achtschellinck. En 1662, il reçoit 120 florins pour un tableau exécuté à Sainte Gudule. En 1671, il collabore avec le peintre malinois Lucas Franchois et est payé pour cela en 1673. Le 13 mai 1674, il épouse Anna Parys à l'église du Finistère à Bruxelles. En 1687, il est doyen représentant les peintres à la corporation et ce jusqu'en 1689. En 1689, il est exonéré en tant que cartonnier En 1681, il est « reconnu » c'est-à-dire : exempté de certaines charges du métier à la condition qu'il ne se livre qu'à des travaux artistiques. Achtschellick est influencé par le style de Rubens dans la façon de peindre les paysages. Il est également fortement influencé par Jacques d'Arthois. Il peint des paysages forestiers, des églises et des cloîtres, ainsi que des scènes avec des personnages inspirées de la Bible. Achtschellinck est connu pour avoir peint les paysages des œuvres majeures du peintre flamand Gaspard de Crayer (1582-1669). Lucas Achtschellinck est souvent associé à son professeur de peinture Lodewijk de Vadder (1605-1655), ainsi qu'à Jacques d'Arthois (1603-1686). En effet, on les appelle les peintres de la Forêt de Soignes.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Description",
                value: "Lucas Achtschellinck est un peintre brabançon baroque spécialisé dans la peinture de paysages.Il est né à Bruxelles en 1626, fut baptisé le 16 janvier de la même année1 . Il entre dans la guilde des peintres le 29 octobre 1639 comme élève de Pieter van der Borcht2.En 1655, à la mort de Lodewijk de Vadder, il pose sa candidature pour devenir cartonnier privilégié de la ville de Bruxelles3. Un voyage à l'étranger peut être envisagé, puisqu'il n'est admis maître qu'en 16574. En 1659, il reçoit 120 florins pour un tableau exécuté à Sainte Gudule5. En 1660 Corneille de Bie publie le Gulden Cabinet6 dans lequel il décrit le style de Lucas Achtschellinck. En 1662, il reçoit 120 florins pour un tableau exécuté à Sainte Gudule7. En 1671, il collabore avec le peintre malinois Lucas Franchois et est payé pour cela en 16738. Le 13 mai 1674, il épouse Anna Parys à l'église du Finistère à Bruxelles9. En 1687, il est doyen représentant les peintres à la corporation et ce jusqu'en 168910. En 1689, il est exonéré en tant que cartonnier11 En 1681, il est « reconnu » c'est-à-dire : exempté de certaines charges du métier à la condition qu'il ne se livre qu'à des travaux artistiques12. Achtschellick est influencé par le style de Rubens dans la façon de peindre les paysages. Il est également fortement influencé par Jacques d'Arthois. Il peint des paysages forestiers, des églises et des cloîtres, ainsi que des scènes avec des personnages inspirées de la Bible. Achtschellinck est connu pour avoir peint les paysages des œuvres majeures du peintre flamand Gaspard de Crayer (1582-1669).Lucas Achtschellinck est souvent associé à son professeur de peinture Lodewijk de Vadder (1605-1655)13, ainsi qu'à Jacques d'Arthois (1603-1686). En effet, on les appelle les peintres de la Forêt de Soignes.");
        }
    }
}
