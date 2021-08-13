using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ayarla.Migrations
{
    public partial class AyarlaBack3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Service",
                table: "EmployeeServices",
                newName: "ServiceName");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "Appoinments",
                newName: "AccountId");

            migrationBuilder.AddColumn<Guid>(
                name: "AppoinmentId",
                table: "EmployeeServices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Dislike",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Like",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Appoinments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "CommentNumber",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeServices_AppoinmentId",
                table: "EmployeeServices",
                column: "AppoinmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeServices_Appoinments_AppoinmentId",
                table: "EmployeeServices",
                column: "AppoinmentId",
                principalTable: "Appoinments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeServices_Appoinments_AppoinmentId",
                table: "EmployeeServices");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeServices_AppoinmentId",
                table: "EmployeeServices");

            migrationBuilder.DropColumn(
                name: "AppoinmentId",
                table: "EmployeeServices");

            migrationBuilder.DropColumn(
                name: "Dislike",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Like",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Appoinments");

            migrationBuilder.DropColumn(
                name: "CommentNumber",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "ServiceName",
                table: "EmployeeServices",
                newName: "Service");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Appoinments",
                newName: "ServiceId");
        }
    }
}
