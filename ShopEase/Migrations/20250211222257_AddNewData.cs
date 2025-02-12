using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopEase.Migrations
{
    /// <inheritdoc />
    public partial class AddNewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRequest_AspNetUsers_StaffID",
                table: "CustomerRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "StaffTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "Staff");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "StaffRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "StaffLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "StaffClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "RoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "StaffRoles",
                newName: "IX_StaffRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "StaffLogins",
                newName: "IX_StaffLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "StaffClaims",
                newName: "IX_StaffClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffTokens",
                table: "StaffTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staff",
                table: "Staff",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffRoles",
                table: "StaffRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffLogins",
                table: "StaffLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffClaims",
                table: "StaffClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "9C7D1A2B-1234-5678-90AB-CDEF12345678", "john.doe@example.com", true, "JOHN.DOE", "SECSTAMP-0001" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "9C7D1A2B-1234-5678-90AB-CDEF12345678", "sikholwe.mdekazi@example.com", true, "SIKHOLE.MDEKAZI", "SECSTAMP-0002" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "9C7D1A2B-1234-5678-90AB-CDEF12345678", "michael.brown@example.com", true, "MICHAEL.BROWN", "SECSTAMP-0003" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "9C7D1A2B-1234-5678-90AB-CDEF12345678", "emily.davis@example.com", true, "EMILY.DAVIS", "SECSTAMP-0004" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "9C7D1A2B-1234-5678-90AB-CDEF12345678", "david.wilson@example.com", true, "DAVID.WILSON", "SECSTAMP-0005" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "9C7D1A2B-1234-5678-90AB-CDEF12345678", "sophia.martinez@example.com", true, "SOPHIA.MARTINEZ", "SECSTAMP-0006" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "9C7D1A2B-1234-5678-90AB-CDEF12345678", "james.anderson@example.com", true, "JAMES.ANDERSON", "SECSTAMP-0007" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "9C7D1A2B-1234-5678-90AB-CDEF12345678", "olivia.taylor@example.com", true, "OLIVIA.TAYLOR", "SECSTAMP-0008" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "9C7D1A2B-1234-5678-90AB-CDEF12345678", "robert.thomas@example.com", true, "ROBERT.THOMAS", "SECSTAMP-0009" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "9C7D1A2B-1234-5678-90AB-CDEF12345678", "emma.harris@example.com", true, "EMMA.HARRIS", "SECSTAMP-0010" });

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRequest_Staff_StaffID",
                table: "CustomerRequest",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffClaims_Staff_UserId",
                table: "StaffClaims",
                column: "UserId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffLogins_Staff_UserId",
                table: "StaffLogins",
                column: "UserId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffRoles_Roles_RoleId",
                table: "StaffRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffRoles_Staff_UserId",
                table: "StaffRoles",
                column: "UserId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffTokens_Staff_UserId",
                table: "StaffTokens",
                column: "UserId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRequest_Staff_StaffID",
                table: "CustomerRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffClaims_Staff_UserId",
                table: "StaffClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffLogins_Staff_UserId",
                table: "StaffLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffRoles_Roles_RoleId",
                table: "StaffRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffRoles_Staff_UserId",
                table: "StaffRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffTokens_Staff_UserId",
                table: "StaffTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffTokens",
                table: "StaffTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffRoles",
                table: "StaffRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffLogins",
                table: "StaffLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffClaims",
                table: "StaffClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staff",
                table: "Staff");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims");

            migrationBuilder.RenameTable(
                name: "StaffTokens",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "StaffRoles",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "StaffLogins",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "StaffClaims",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "Staff",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_StaffRoles_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_StaffLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_StaffClaims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "0a7cbf8d-fe7e-44d2-b692-1ef3790eb117", null, false, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "67f1383a-ef63-4e6d-9429-f6da8582e5b3", null, false, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "cdc2b542-0081-4945-a307-7d6b312fa36f", null, false, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "244a5166-1ec8-4609-8353-9f7239f01e1a", null, false, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "6dae4b32-ee04-4ff6-8dcb-27e72842eecd", null, false, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "127c63e7-ef33-496d-adef-8cf25e092520", null, false, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "524200bc-dbef-4e52-b563-0c010024219e", null, false, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "886daeed-3d50-4227-b1f7-1da89f278b2d", null, false, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "be433660-e2c4-4939-879c-473bc2c3f10e", null, false, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "3254871f-52a7-4c4e-9e09-8b441538e5ee", null, false, null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRequest_AspNetUsers_StaffID",
                table: "CustomerRequest",
                column: "StaffID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
