using Microsoft.EntityFrameworkCore.Migrations;

namespace Eleva_WebAPI.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Escolas",
                columns: new[] { "id", "cidade", "endereco", "estado", "nome", "telefone" },
                values: new object[] { 1, "Belo Horizonte", "R. dos Agrônomos, 185", "MG", "Coleguium - Alípio de Melo", "(31) 3024-9540" });

            migrationBuilder.InsertData(
                table: "Escolas",
                columns: new[] { "id", "cidade", "endereco", "estado", "nome", "telefone" },
                values: new object[] { 2, "Belo Horizonte", "Av. Celso Porfírio Machado, 1650", "MG", "Coleguium - Belvedere Internacional", "(31) 3568-3807" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Escolas",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Escolas",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
