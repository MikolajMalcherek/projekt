using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace projekt.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "miejscowosci",
                columns: table => new
                {
                    idmiejscowosci = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nazwa_miejscowosci = table.Column<string>(type: "longtext", nullable: false),
                    kraj_miejscowosci = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_miejscowosci", x => x.idmiejscowosci);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "wyniki",
                columns: table => new
                {
                    idwyniki = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    idzawodnicy = table.Column<int>(type: "int", nullable: false),
                    idmiejscowosci = table.Column<int>(type: "int", nullable: false),
                    wynik = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wyniki", x => x.idwyniki);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "zawodnicy",
                columns: table => new
                {
                    idzawodnicy = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    imie_zawodnika = table.Column<string>(type: "longtext", nullable: false),
                    nazwisko_zawodnika = table.Column<string>(type: "longtext", nullable: false),
                    kraj_pochodzenia = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zawodnicy", x => x.idzawodnicy);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "miejscowosci");

            migrationBuilder.DropTable(
                name: "wyniki");

            migrationBuilder.DropTable(
                name: "zawodnicy");
        }
    }
}
