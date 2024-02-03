using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "PasswordManager_DB");

            migrationBuilder.CreateTable(
                name: "User_Mst",
                schema: "PasswordManager_DB",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserLoginPassword = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Master = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IsEmailVerified = table.Column<bool>(type: "bit", nullable: false),
                    IsMobileNumberVerified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Mst", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Password_Mst",
                schema: "PasswordManager_DB",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Password_Mst", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Password_Mst_User_Mst_UserId",
                        column: x => x.UserId,
                        principalSchema: "PasswordManager_DB",
                        principalTable: "User_Mst",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Settings_Mst",
                schema: "PasswordManager_DB",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    DateTimeFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShowEmailColumn = table.Column<bool>(type: "bit", nullable: false),
                    ShowUsernameColumn = table.Column<bool>(type: "bit", nullable: false),
                    ShowPasswordColumn = table.Column<bool>(type: "bit", nullable: false),
                    CopyPasswordColumn = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings_Mst", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Settings_Mst_User_Mst_UserId",
                        column: x => x.UserId,
                        principalSchema: "PasswordManager_DB",
                        principalTable: "User_Mst",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PasswordOptions_Dtl",
                schema: "PasswordManager_DB",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettingsId = table.Column<long>(type: "bigint", nullable: false),
                    AllowLowercaseCharacters = table.Column<bool>(type: "bit", nullable: false),
                    AllowSpecialCharacters = table.Column<bool>(type: "bit", nullable: false),
                    AllowUnderscoreCharacters = table.Column<bool>(type: "bit", nullable: false),
                    AllowSpaceCharacters = table.Column<bool>(type: "bit", nullable: false),
                    AllowOtherCharacters = table.Column<bool>(type: "bit", nullable: false),
                    RequireLowercaseCharacters = table.Column<bool>(type: "bit", nullable: false),
                    RequireUppercaseCharacters = table.Column<bool>(type: "bit", nullable: false),
                    RequireNumberCharacters = table.Column<bool>(type: "bit", nullable: false),
                    RequireSpecialCharacters = table.Column<bool>(type: "bit", nullable: false),
                    RequireUnderscoreCharacters = table.Column<bool>(type: "bit", nullable: false),
                    RequireSpaceCharacters = table.Column<bool>(type: "bit", nullable: false),
                    RequireOtherCharacters = table.Column<bool>(type: "bit", nullable: false),
                    MinimumCharacters = table.Column<int>(type: "int", nullable: false),
                    MaximumCharacters = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordOptions_Dtl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PasswordOptions_Dtl_Settings_Mst_SettingsId",
                        column: x => x.SettingsId,
                        principalSchema: "PasswordManager_DB",
                        principalTable: "Settings_Mst",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Password_Mst_UserId",
                schema: "PasswordManager_DB",
                table: "Password_Mst",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PasswordOptions_Dtl_SettingsId",
                schema: "PasswordManager_DB",
                table: "PasswordOptions_Dtl",
                column: "SettingsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Settings_Mst_UserId",
                schema: "PasswordManager_DB",
                table: "Settings_Mst",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Password_Mst",
                schema: "PasswordManager_DB");

            migrationBuilder.DropTable(
                name: "PasswordOptions_Dtl",
                schema: "PasswordManager_DB");

            migrationBuilder.DropTable(
                name: "Settings_Mst",
                schema: "PasswordManager_DB");

            migrationBuilder.DropTable(
                name: "User_Mst",
                schema: "PasswordManager_DB");
        }
    }
}
