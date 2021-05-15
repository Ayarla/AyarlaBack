using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ayarla.Migrations
{
    public partial class AyarlaBack16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeServices_EmployeeId",
                table: "EmployeeServices",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeServices_Employees_EmployeeId",
                table: "EmployeeServices",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeServices_Employees_EmployeeId",
                table: "EmployeeServices");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeServices_EmployeeId",
                table: "EmployeeServices");

            migrationBuilder.AddColumn<Guid>(
                name: "AccountId",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
