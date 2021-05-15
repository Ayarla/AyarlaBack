using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ayarla.Migrations
{
    public partial class AyarlaBack18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkingDays");

            migrationBuilder.DropColumn(
                name: "WorkTimeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "WorkingDays",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Days",
                table: "WorkTimes",
                newName: "WorkingDays");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTimes_EmployeeId",
                table: "WorkTimes",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkTimes_Employees_EmployeeId",
                table: "WorkTimes",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkTimes_Employees_EmployeeId",
                table: "WorkTimes");

            migrationBuilder.DropIndex(
                name: "IX_WorkTimes_EmployeeId",
                table: "WorkTimes");

            migrationBuilder.RenameColumn(
                name: "WorkingDays",
                table: "WorkTimes",
                newName: "Days");

            migrationBuilder.AddColumn<Guid>(
                name: "WorkTimeId",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "WorkingDays",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WorkingDays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    Days = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingDays", x => x.Id);
                });
        }
    }
}
