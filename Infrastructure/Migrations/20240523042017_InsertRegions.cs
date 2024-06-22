using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InsertRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Ddd", "RegionName" },
                values: new object[,]
                {
                    { 11, "São Paulo – SP" },
                    { 12, "São José dos Campos – SP" },
                    { 13, "Santos – SP" },
                    { 14, "Bauru – SP" },
                    { 15, "Sorocaba – SP" },
                    { 16, "Ribeirão Preto – SP" },
                    { 17, "São José do Rio Preto – SP" },
                    { 18, "Presidente Prudente – SP" },
                    { 19, "Campinas – SP" },
                    { 21, "Rio de Janeiro – RJ" },
                    { 22, "Campos dos Goytacazes – RJ" },
                    { 24, "Volta Redonda – RJ" },
                    { 27, "Vitória / Vila Velha – ES" },
                    { 28, "Cachoeiro de Itapemirim – ES" },
                    { 31, "Belo Horizonte – MG" },
                    { 32, "Juiz de Fora – MG" },
                    { 33, "Governador Valadares – MG" },
                    { 34, "Uberlândia – MG" },
                    { 35, "Poços de Caldas – MG" },
                    { 37, "Divinópolis – MG" },
                    { 38, "Montes Claros – MG" },
                    { 41, "Curitiba – PR" },
                    { 42, "Ponta Grossa – PR" },
                    { 43, "Londrina – PR" },
                    { 44, "Maringá – PR" },
                    { 45, "Foz do Iguaçú – PR" },
                    { 46, "Pato Branco / Francisco Beltrão – PR" },
                    { 47, "Joinville – SC" },
                    { 48, "Florianópolis – SC" },
                    { 49, "Chapecó – SC" },
                    { 51, "Porto Alegre – RS" },
                    { 53, "Pelotas – RS" },
                    { 54, "Caxias do Sul – RS" },
                    { 55, "Santa Maria – RS" },
                    { 61, "Brasília – DF" },
                    { 62, "Goiânia – GO" },
                    { 63, "Palmas – TO" },
                    { 64, "Rio Verde – GO" },
                    { 65, "Cuiabá – MT" },
                    { 66, "Rondonópolis – MT" },
                    { 67, "Campo Grande – MS" },
                    { 68, "Rio Branco – AC" },
                    { 69, "Porto Velho – RO" },
                    { 71, "Salvador – BA" },
                    { 73, "Ilhéus – BA" },
                    { 74, "Juazeiro – BA" },
                    { 75, "Feira de Santana – BA" },
                    { 77, "Barreiras – BA" },
                    { 79, "Aracaju – SE" },
                    { 81, "Recife – PE" },
                    { 82, "Maceió – AL" },
                    { 83, "João Pessoa – PB" },
                    { 84, "Natal – RN" },
                    { 85, "Fortaleza – CE" },
                    { 86, "Teresina – PI" },
                    { 87, "Petrolina – PE" },
                    { 88, "Juazeiro do Norte – CE" },
                    { 89, "Picos – PI" },
                    { 91, "Belém – PA" },
                    { 92, "Manaus – AM" },
                    { 93, "Santarém – PA" },
                    { 94, "Marabá – PA" },
                    { 95, "Boa Vista – RR" },
                    { 96, "Macapá – AP" },
                    { 97, "Coari – AM" },
                    { 98, "São Luís – MA" },
                    { 99, "Imperatriz – MA" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Ddd",
                keyValue: 99);
        }
    }
}
