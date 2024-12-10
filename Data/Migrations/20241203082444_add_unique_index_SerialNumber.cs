using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ccjyapp.Migrations
{
    /// <inheritdoc />
    public partial class add_unique_index_SerialNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MotorParameters_SerialNumber",
                table: "MotorParameters",
                column: "SerialNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MotorParameters_SerialNumber",
                table: "MotorParameters");
        }
    }
}
