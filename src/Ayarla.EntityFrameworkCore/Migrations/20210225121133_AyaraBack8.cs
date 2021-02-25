using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ayarla.Migrations
{
    public partial class AyaraBack8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkEndTime",
                table: "WorkTimes");

            migrationBuilder.DropColumn(
                name: "WorkStartTime",
                table: "WorkTimes");

            migrationBuilder.RenameColumn(
                name: "WorkStartTime",
                table: "OpenCloseTimes",
                newName: "AccountWorkStartTime");

            migrationBuilder.RenameColumn(
                name: "WorkEndTime",
                table: "OpenCloseTimes",
                newName: "AccountWorkEndTime");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EmployeeWorkEndTime",
                table: "WorkTimes",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EmployeeWorkStartTime",
                table: "WorkTimes",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeWorkEndTime",
                table: "WorkTimes");

            migrationBuilder.DropColumn(
                name: "EmployeeWorkStartTime",
                table: "WorkTimes");

            migrationBuilder.RenameColumn(
                name: "AccountWorkStartTime",
                table: "OpenCloseTimes",
                newName: "WorkStartTime");

            migrationBuilder.RenameColumn(
                name: "AccountWorkEndTime",
                table: "OpenCloseTimes",
                newName: "WorkEndTime");

            migrationBuilder.AddColumn<string>(
                name: "WorkEndTime",
                table: "WorkTimes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkStartTime",
                table: "WorkTimes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
