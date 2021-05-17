using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ayarla.Migrations
{
    public partial class AyarlaBack13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayOfTheWeek",
                table: "WorkTimes");

            migrationBuilder.DropColumn(
                name: "DayOfTheWeek",
                table: "OpenCloseTimes");

            migrationBuilder.DropColumn(
                name: "AppoinmentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AppoinmentId",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "FavoriteId",
                table: "AbpUsers");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "WorkTimes",
                newName: "EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "Days",
                table: "WorkTimes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Days",
                table: "OpenCloseTimes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Appoinments_UserId",
                table: "Appoinments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appoinments_AbpUsers_UserId",
                table: "Appoinments",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AbpUsers_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_AbpUsers_UserId",
                table: "Favorites",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appoinments_AbpUsers_UserId",
                table: "Appoinments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AbpUsers_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_AbpUsers_UserId",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Appoinments_UserId",
                table: "Appoinments");

            migrationBuilder.DropColumn(
                name: "Days",
                table: "WorkTimes");

            migrationBuilder.DropColumn(
                name: "Days",
                table: "OpenCloseTimes");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "WorkTimes",
                newName: "AccountId");

            migrationBuilder.AddColumn<string>(
                name: "DayOfTheWeek",
                table: "WorkTimes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DayOfTheWeek",
                table: "OpenCloseTimes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AppoinmentId",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AppoinmentId",
                table: "AbpUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CommentId",
                table: "AbpUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FavoriteId",
                table: "AbpUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
