using Microsoft.EntityFrameworkCore.Migrations;

namespace Eleva_WebAPI.Migrations
{
    public partial class new2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    codigo = table.Column<string>(type: "TEXT", nullable: true),
                    idEscola = table.Column<int>(type: "INTEGER", nullable: false),
                    Escolaid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Turmas_Escolas_Escolaid",
                        column: x => x.Escolaid,
                        principalTable: "Escolas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "id", "Escolaid", "codigo", "idEscola" },
                values: new object[] { 1, null, "1A-1", 1 });

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "id", "Escolaid", "codigo", "idEscola" },
                values: new object[] { 2, null, "1A-2", 1 });

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "id", "Escolaid", "codigo", "idEscola" },
                values: new object[] { 3, null, "1A-3", 1 });

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "id", "Escolaid", "codigo", "idEscola" },
                values: new object[] { 4, null, "1B-1", 1 });

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "id", "Escolaid", "codigo", "idEscola" },
                values: new object[] { 5, null, "1B-2", 1 });

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "id", "Escolaid", "codigo", "idEscola" },
                values: new object[] { 6, null, "1A-1", 2 });

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "id", "Escolaid", "codigo", "idEscola" },
                values: new object[] { 7, null, "1A-2", 2 });

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "id", "Escolaid", "codigo", "idEscola" },
                values: new object[] { 8, null, "1A-3", 2 });

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "id", "Escolaid", "codigo", "idEscola" },
                values: new object[] { 9, null, "1B-1", 2 });

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "id", "Escolaid", "codigo", "idEscola" },
                values: new object[] { 10, null, "1B-2", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Turmas_Escolaid",
                table: "Turmas",
                column: "Escolaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turmas");
        }
    }
}
