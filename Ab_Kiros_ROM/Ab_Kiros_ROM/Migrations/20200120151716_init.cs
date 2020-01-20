using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ab_Kiros_ROM.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "illenses",
                columns: table => new
                {
                    illness_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    illness_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_illenses", x => x.illness_ID);
                });

            migrationBuilder.CreateTable(
                name: "persons",
                columns: table => new
                {
                    person_ID = table.Column<Guid>(nullable: false),
                    first_name = table.Column<string>(nullable: true),
                    surname = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    Id_Number = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    contact_No = table.Column<string>(nullable: true),
                    active = table.Column<string>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    client_ID = table.Column<int>(nullable: true),
                    illness_ID = table.Column<int>(nullable: true),
                    doctor_ID = table.Column<int>(nullable: true),
                    country_Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persons", x => x.person_ID);
                });

            migrationBuilder.CreateTable(
                name: "visits",
                columns: table => new
                {
                    visits_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doctor_ID = table.Column<int>(nullable: false),
                    client_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visits", x => x.visits_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "illenses");

            migrationBuilder.DropTable(
                name: "persons");

            migrationBuilder.DropTable(
                name: "visits");
        }
    }
}
