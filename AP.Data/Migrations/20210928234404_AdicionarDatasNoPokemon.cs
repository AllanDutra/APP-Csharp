using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AP.Data.Migrations
{
    public partial class AdicionarDatasNoPokemon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Pokemons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "Pokemons",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "Pokemons");
        }
    }
}
