using Microsoft.EntityFrameworkCore.Migrations;

namespace SisAuxSUS_AP2.Migrations
{
    public partial class correcaoSituacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SituacaoPaciente",
                table: "Pacientes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SituacaoPaciente",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
