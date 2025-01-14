using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class createdbtoday : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctors_patients_Patientid",
                table: "doctors");

            migrationBuilder.DropIndex(
                name: "IX_doctors_Patientid",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "Patientid",
                table: "doctors");

            migrationBuilder.CreateIndex(
                name: "IX_prescriptions_DoctorId",
                table: "prescriptions",
                column: "DoctorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_prescriptions_PatientId",
                table: "prescriptions",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_prescriptions_doctors_DoctorId",
                table: "prescriptions",
                column: "DoctorId",
                principalTable: "doctors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_prescriptions_patients_PatientId",
                table: "prescriptions",
                column: "PatientId",
                principalTable: "patients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prescriptions_doctors_DoctorId",
                table: "prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_prescriptions_patients_PatientId",
                table: "prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_prescriptions_DoctorId",
                table: "prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_prescriptions_PatientId",
                table: "prescriptions");

            migrationBuilder.AddColumn<int>(
                name: "Patientid",
                table: "doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_doctors_Patientid",
                table: "doctors",
                column: "Patientid");

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_patients_Patientid",
                table: "doctors",
                column: "Patientid",
                principalTable: "patients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
