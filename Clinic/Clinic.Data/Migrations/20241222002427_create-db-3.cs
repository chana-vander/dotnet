using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class createdb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctors_patients_patientid",
                table: "doctors");

            migrationBuilder.RenameColumn(
                name: "patientid",
                table: "doctors",
                newName: "Patientid");

            migrationBuilder.RenameIndex(
                name: "IX_doctors_patientid",
                table: "doctors",
                newName: "IX_doctors_Patientid");

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_patients_Patientid",
                table: "doctors",
                column: "Patientid",
                principalTable: "patients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctors_patients_Patientid",
                table: "doctors");

            migrationBuilder.RenameColumn(
                name: "Patientid",
                table: "doctors",
                newName: "patientid");

            migrationBuilder.RenameIndex(
                name: "IX_doctors_Patientid",
                table: "doctors",
                newName: "IX_doctors_patientid");

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_patients_patientid",
                table: "doctors",
                column: "patientid",
                principalTable: "patients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
