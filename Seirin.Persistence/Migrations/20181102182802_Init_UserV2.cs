using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Seirin.Persistence.Migrations
{
    public partial class Init_UserV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "admin_create",
                table: "Mst_Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "admin_modify",
                table: "Mst_Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "cnt_login_error",
                table: "Mst_Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "code_cst",
                table: "Mst_Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "create_by",
                table: "Mst_Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "create_date",
                table: "Mst_Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "dest_flag",
                table: "Mst_Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "display_order",
                table: "Mst_Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "login_id",
                table: "Mst_Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "login_pass",
                table: "Mst_Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "loginkey",
                table: "Mst_Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mail",
                table: "Mst_Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "modify_by",
                table: "Mst_Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "modify_date",
                table: "Mst_Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Mst_Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "use_flg",
                table: "Mst_Users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "admin_create",
                table: "Mst_Users");

            migrationBuilder.DropColumn(
                name: "admin_modify",
                table: "Mst_Users");

            migrationBuilder.DropColumn(
                name: "cnt_login_error",
                table: "Mst_Users");

            migrationBuilder.DropColumn(
                name: "code_cst",
                table: "Mst_Users");

            migrationBuilder.DropColumn(
                name: "create_by",
                table: "Mst_Users");

            migrationBuilder.DropColumn(
                name: "create_date",
                table: "Mst_Users");

            migrationBuilder.DropColumn(
                name: "dest_flag",
                table: "Mst_Users");

            migrationBuilder.DropColumn(
                name: "display_order",
                table: "Mst_Users");

            migrationBuilder.DropColumn(
                name: "login_id",
                table: "Mst_Users");

            migrationBuilder.DropColumn(
                name: "login_pass",
                table: "Mst_Users");

            migrationBuilder.DropColumn(
                name: "loginkey",
                table: "Mst_Users");

            migrationBuilder.DropColumn(
                name: "mail",
                table: "Mst_Users");

            migrationBuilder.DropColumn(
                name: "modify_by",
                table: "Mst_Users");

            migrationBuilder.DropColumn(
                name: "modify_date",
                table: "Mst_Users");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Mst_Users");

            migrationBuilder.DropColumn(
                name: "use_flg",
                table: "Mst_Users");
        }
    }
}
