using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bludata.Teste.CSharp.Infra.Migrations
{
    public partial class BludataTese : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Update_At = table.Column<DateTime>(nullable: false),
                    CNPJ = table.Column<string>(nullable: true),
                    Fantasy = table.Column<string>(nullable: false),
                    StateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provider",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Update_At = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Create_At = table.Column<DateTime>(nullable: false),
                    CPF = table.Column<string>(nullable: true),
                    RG = table.Column<string>(nullable: true),
                    DateBirth = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: false),
                    CNPJProvider = table.Column<string>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    PersonType = table.Column<int>(nullable: false),
                    ContactNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provider_Company_Id",
                        column: x => x.Id,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Provider");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
