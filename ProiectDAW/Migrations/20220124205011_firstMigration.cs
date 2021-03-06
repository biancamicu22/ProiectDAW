using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectDAW.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atractii",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Denumire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OraDeschidere = table.Column<TimeSpan>(type: "time", nullable: false),
                    OraInchidere = table.Column<TimeSpan>(type: "time", nullable: false),
                    Pret = table.Column<float>(type: "real", nullable: false),
                    Oras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atractii", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cazari",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipCazare = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Pret = table.Column<float>(type: "real", nullable: false),
                    Oras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cazari", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Facilitati",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Denumire = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilitati", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Utilizatori",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Parola = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNasterii = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizatori", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vacante",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Denumire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataInceput = table.Column<DateTime>(type: "Date", nullable: false),
                    DataSfarsit = table.Column<DateTime>(type: "Date", nullable: false),
                    Oras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tara = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacante", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pachete",
                columns: table => new
                {
                    CazareID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacilitateID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pachete", x => new { x.CazareID, x.FacilitateID });
                    table.ForeignKey(
                        name: "FK_Pachete_Cazari_CazareID",
                        column: x => x.CazareID,
                        principalTable: "Cazari",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pachete_Facilitati_FacilitateID",
                        column: x => x.FacilitateID,
                        principalTable: "Facilitati",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fotografii",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titlu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilizatorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotografii", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Fotografii_Utilizatori_UtilizatorID",
                        column: x => x.UtilizatorID,
                        principalTable: "Utilizatori",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Portofel",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Suma = table.Column<float>(type: "real", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UtilizatorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portofel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Portofel_Utilizatori_UtilizatorID",
                        column: x => x.UtilizatorID,
                        principalTable: "Utilizatori",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bilete",
                columns: table => new
                {
                    VacantaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AtractieID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodBilet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataVizita = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilete", x => new { x.VacantaID, x.AtractieID });
                    table.ForeignKey(
                        name: "FK_Bilete_Atractii_AtractieID",
                        column: x => x.AtractieID,
                        principalTable: "Atractii",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bilete_Vacante_VacantaID",
                        column: x => x.VacantaID,
                        principalTable: "Vacante",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezervari",
                columns: table => new
                {
                    UtilizatorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VacantaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataRezervare = table.Column<DateTime>(type: "Date", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervari", x => new { x.VacantaID, x.UtilizatorID });
                    table.ForeignKey(
                        name: "FK_Rezervari_Utilizatori_UtilizatorID",
                        column: x => x.UtilizatorID,
                        principalTable: "Utilizatori",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervari_Vacante_VacantaID",
                        column: x => x.VacantaID,
                        principalTable: "Vacante",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RezervariCazari",
                columns: table => new
                {
                    VacantaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CazareID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataSosire = table.Column<DateTime>(type: "Date", nullable: false),
                    DataPlecare = table.Column<DateTime>(type: "Date", nullable: false),
                    CodRezervare = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezervariCazari", x => new { x.VacantaID, x.CazareID });
                    table.ForeignKey(
                        name: "FK_RezervariCazari_Cazari_CazareID",
                        column: x => x.CazareID,
                        principalTable: "Cazari",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RezervariCazari_Vacante_VacantaID",
                        column: x => x.VacantaID,
                        principalTable: "Vacante",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilete_AtractieID",
                table: "Bilete",
                column: "AtractieID");

            migrationBuilder.CreateIndex(
                name: "IX_Fotografii_UtilizatorID",
                table: "Fotografii",
                column: "UtilizatorID");

            migrationBuilder.CreateIndex(
                name: "IX_Pachete_FacilitateID",
                table: "Pachete",
                column: "FacilitateID");

            migrationBuilder.CreateIndex(
                name: "IX_Portofel_UtilizatorID",
                table: "Portofel",
                column: "UtilizatorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rezervari_UtilizatorID",
                table: "Rezervari",
                column: "UtilizatorID");

            migrationBuilder.CreateIndex(
                name: "IX_RezervariCazari_CazareID",
                table: "RezervariCazari",
                column: "CazareID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bilete");

            migrationBuilder.DropTable(
                name: "Fotografii");

            migrationBuilder.DropTable(
                name: "Pachete");

            migrationBuilder.DropTable(
                name: "Portofel");

            migrationBuilder.DropTable(
                name: "Rezervari");

            migrationBuilder.DropTable(
                name: "RezervariCazari");

            migrationBuilder.DropTable(
                name: "Atractii");

            migrationBuilder.DropTable(
                name: "Facilitati");

            migrationBuilder.DropTable(
                name: "Utilizatori");

            migrationBuilder.DropTable(
                name: "Cazari");

            migrationBuilder.DropTable(
                name: "Vacante");
        }
    }
}
