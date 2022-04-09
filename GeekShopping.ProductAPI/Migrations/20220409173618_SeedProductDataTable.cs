using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "category_name", "created_at", "description", "image_url", "name", "price", "updated_at" },
                values: new object[] { 3L, "camisetas", new DateTime(2022, 4, 9, 14, 36, 18, 388, DateTimeKind.Local).AddTicks(6244), "Foram essas as palavras que tornaram o mago cinza imortalizado, pegando toda a experiência da vitória para si, subindo de classe e virando o poderoso mago branco. Enfrentar um chefe de alto nível sozinho pode te render um desafio mortal, mas a vitória te faz ficar alguns níveis a frente de seu grupo.", "https://cdn.nerdstore.com.br/wp-content/uploads/2021/03/camiseta-you-shall-not-pass-01.jpg", "Camiseta You Shall Not Pass", 50m, null });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "category_name", "created_at", "description", "image_url", "name", "price", "updated_at" },
                values: new object[] { 4L, "camisetas", new DateTime(2022, 4, 9, 14, 36, 18, 388, DateTimeKind.Local).AddTicks(6263), "A Árvore de Gondor representa a paz e prosperidade dos Homens, as estrelas se referem aos sete barcos dos Homens de Númenor que traziam as Palantír, cada um com o desenho de uma estrela.Sua estampa favorita,  agora na sua versão black edition, em uma super camiseta pronta para desbravar a Terra Média!", "https://cdn.nerdstore.com.br/wp-content/uploads/2022/04/vitrine-camiseta-arvore-de-gondor-black-edition-01-nerdstore.jpg", "Camiseta Árvore de Gondor – Black Edition", 79.9m, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 4L);
        }
    }
}
