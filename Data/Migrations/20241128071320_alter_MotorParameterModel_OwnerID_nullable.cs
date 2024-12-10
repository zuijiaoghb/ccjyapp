using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ccjyapp.Migrations
{
    /// <inheritdoc />
    public partial class alter_MotorParameterModel_OwnerID_nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OwnerID",
                table: "MotorParameters",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MotorParameters",
                keyColumn: "OwnerID",
                keyValue: null,
                column: "OwnerID",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerID",
                table: "MotorParameters",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
