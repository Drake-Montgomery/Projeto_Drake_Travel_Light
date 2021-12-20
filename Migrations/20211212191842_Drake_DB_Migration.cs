using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drake_Travel_Light.Migrations
{
    public partial class Drake_DB_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Voo",
                columns: table => new
                {
                    Id_Voo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data_ida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_volta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voo", x => x.Id_Voo);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero_voo = table.Column<int>(type: "int", nullable: false),
                    VooId_Voo = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<int>(type: "int", nullable: false),
                    Cartão_De_Credito = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Voo_VooId_Voo",
                        column: x => x.VooId_Voo,
                        principalTable: "Voo",
                        principalColumn: "Id_Voo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_VooId_Voo",
                table: "Cliente",
                column: "VooId_Voo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Voo");
        }
    }
}
