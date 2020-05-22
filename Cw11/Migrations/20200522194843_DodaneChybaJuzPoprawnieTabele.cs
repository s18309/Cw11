using Microsoft.EntityFrameworkCore.Migrations;

using System;


namespace Cw11.Migrations
{
    public partial class DodaneChybaJuzPoprawnieTabele : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    IdDoctor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DoctorPrimaryKey", x => x.IdDoctor);
                });

            migrationBuilder.CreateTable(
                name: "Medicament",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    Type = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MedicamentPrimaryKey", x => x.IdMedicament);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    IdPatient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PatientPrimaryKey", x => x.IdPatient);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    IdPrescription = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    IdPatient = table.Column<int>(nullable: false),
                    IdDoctor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrescriptionPrimaryKey", x => x.IdPrescription);
                    table.ForeignKey(
                        name: "DoctorPrescription",
                        column: x => x.IdDoctor,
                        principalTable: "Doctor",
                        principalColumn: "IdDoctor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PatientPrescription",
                        column: x => x.IdPatient,
                        principalTable: "Patient",
                        principalColumn: "IdPatient",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prescription_Medicament",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(nullable: false),
                    IdPrescription = table.Column<int>(nullable: false),
                    Dose = table.Column<int>(nullable: false),
                    Details = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription_Medicament", x => new { x.IdMedicament, x.IdPrescription });
                    table.ForeignKey(
                        name: "MedicamentWithPrescriptionMedicament",
                        column: x => x.IdMedicament,
                        principalTable: "Medicament",
                        principalColumn: "IdMedicament",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PrescriptionWithPrescriptionMedicament",
                        column: x => x.IdPrescription,
                        principalTable: "Prescription",
                        principalColumn: "IdPrescription",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "1@as.d", "Mateusz", "Rudy" },
                    { 2, "2@as.d", "Adam", "Blady" },
                    { 3, "3@as.d", "Slawek", "Niebieski" },
                    { 4, "4@as.d", "Krzys", "Pomaranczowy" },
                    { 5, "5@as.d", "Wojtek", "Rozowy" }
                });

            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "qqqqqqqqqqq", "jeden", "a" },
                    { 2, "wwwwwwwwwwww", "dwa", "b" },
                    { 3, "eeeeeeeeeee", "trzy", "a" },
                    { 4, "rrrrrrrrr", "cztery", "b" },
                    { 5, "tttttttttt", "piec", "a" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 22, 21, 48, 43, 481, DateTimeKind.Local).AddTicks(6303), "Anna", "Kowalska" },
                    { 2, new DateTime(2020, 5, 22, 21, 48, 43, 483, DateTimeKind.Local).AddTicks(7136), "Angelika", "Red" },
                    { 3, new DateTime(2020, 5, 22, 21, 48, 43, 483, DateTimeKind.Local).AddTicks(7171), "Sylwia", "Amasde" },
                    { 4, new DateTime(2020, 5, 22, 21, 48, 43, 483, DateTimeKind.Local).AddTicks(7177), "Sasha", "Jakubiak" },
                    { 5, new DateTime(2020, 5, 22, 21, 48, 43, 483, DateTimeKind.Local).AddTicks(7180), "Renata", "Smark" }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 22, 21, 48, 43, 485, DateTimeKind.Local).AddTicks(3417), new DateTime(2020, 5, 22, 22, 48, 43, 485, DateTimeKind.Local).AddTicks(3839), 1, 1 },
                    { 2, new DateTime(2020, 5, 22, 21, 48, 43, 485, DateTimeKind.Local).AddTicks(4963), new DateTime(2020, 5, 22, 22, 48, 43, 485, DateTimeKind.Local).AddTicks(4987), 2, 2 },
                    { 3, new DateTime(2020, 5, 22, 21, 48, 43, 485, DateTimeKind.Local).AddTicks(5007), new DateTime(2020, 5, 22, 22, 48, 43, 485, DateTimeKind.Local).AddTicks(5010), 3, 3 },
                    { 4, new DateTime(2020, 5, 22, 21, 48, 43, 485, DateTimeKind.Local).AddTicks(5013), new DateTime(2020, 5, 22, 22, 48, 43, 485, DateTimeKind.Local).AddTicks(5016), 4, 4 },
                    { 5, new DateTime(2020, 5, 22, 21, 48, 43, 485, DateTimeKind.Local).AddTicks(5019), new DateTime(2020, 5, 22, 22, 48, 43, 485, DateTimeKind.Local).AddTicks(5022), 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "aaaaaa", 0 },
                    { 2, 2, "sssssssssss", 0 },
                    { 3, 3, "dddddddd", 0 },
                    { 4, 4, "ffffffffffffff", 1 },
                    { 5, 5, "ggggggggggggggggggg", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_IdDoctor",
                table: "Prescription",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_IdPatient",
                table: "Prescription",
                column: "IdPatient");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_Medicament_IdPrescription",
                table: "Prescription_Medicament",
                column: "IdPrescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prescription_Medicament");

            migrationBuilder.DropTable(
                name: "Medicament");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
