using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cadastro.CommandStore.Migrations
{
    /// <inheritdoc />
    public partial class thirst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPessoa",
                table: "Alunos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPessoa",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
