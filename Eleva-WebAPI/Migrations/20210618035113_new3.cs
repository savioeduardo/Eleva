using Microsoft.EntityFrameworkCore.Migrations;

namespace Eleva_WebAPI.Migrations
{
    public partial class new3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turmas_Escolas_Escolaid",
                table: "Turmas");

            migrationBuilder.DropColumn(
                name: "idEscola",
                table: "Turmas");

            migrationBuilder.RenameColumn(
                name: "Escolaid",
                table: "Turmas",
                newName: "EscolaId");

            migrationBuilder.RenameIndex(
                name: "IX_Turmas_Escolaid",
                table: "Turmas",
                newName: "IX_Turmas_EscolaId");

            migrationBuilder.AlterColumn<int>(
                name: "EscolaId",
                table: "Turmas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 1,
                column: "EscolaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 2,
                column: "EscolaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 3,
                column: "EscolaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 4,
                column: "EscolaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 5,
                column: "EscolaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 6,
                column: "EscolaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 7,
                column: "EscolaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 8,
                column: "EscolaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 9,
                column: "EscolaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 10,
                column: "EscolaId",
                value: 2);

            migrationBuilder.AddForeignKey(
                name: "FK_Turmas_Escolas_EscolaId",
                table: "Turmas",
                column: "EscolaId",
                principalTable: "Escolas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turmas_Escolas_EscolaId",
                table: "Turmas");

            migrationBuilder.RenameColumn(
                name: "EscolaId",
                table: "Turmas",
                newName: "Escolaid");

            migrationBuilder.RenameIndex(
                name: "IX_Turmas_EscolaId",
                table: "Turmas",
                newName: "IX_Turmas_Escolaid");

            migrationBuilder.AlterColumn<int>(
                name: "Escolaid",
                table: "Turmas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "idEscola",
                table: "Turmas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Escolaid", "idEscola" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Escolaid", "idEscola" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Escolaid", "idEscola" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "Escolaid", "idEscola" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "Escolaid", "idEscola" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "Escolaid", "idEscola" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "Escolaid", "idEscola" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "Escolaid", "idEscola" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "Escolaid", "idEscola" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Turmas",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "Escolaid", "idEscola" },
                values: new object[] { null, 2 });

            migrationBuilder.AddForeignKey(
                name: "FK_Turmas_Escolas_Escolaid",
                table: "Turmas",
                column: "Escolaid",
                principalTable: "Escolas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
