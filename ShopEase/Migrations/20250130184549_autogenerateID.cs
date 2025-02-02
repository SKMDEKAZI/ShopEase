using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopEase.Migrations
{
    /// <inheritdoc />
    public partial class autogenerateID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRequest_Staff_StaffID",
                table: "CustomerRequest");

            migrationBuilder.AlterColumn<int>(
                name: "StaffID",
                table: "CustomerRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRequest_Staff_StaffID",
                table: "CustomerRequest",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "StaffID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRequest_Staff_StaffID",
                table: "CustomerRequest");

            migrationBuilder.AlterColumn<int>(
                name: "StaffID",
                table: "CustomerRequest",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRequest_Staff_StaffID",
                table: "CustomerRequest",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "StaffID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
