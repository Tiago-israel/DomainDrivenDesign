using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infra.Migrations
{
    public partial class criacaobanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pessoa",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    DATA_NASCIMENTO = table.Column<DateTime>(nullable: true),
                    EMAIL = table.Column<string>(maxLength: 255, nullable: true),
                    NOME = table.Column<string>(maxLength: 255, nullable: false),
                    SENHA = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pessoa", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pessoa");
        }
    }
}
