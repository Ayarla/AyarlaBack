using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ayarla.Migrations
{
    public partial class AyarlaDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Appoinments");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Appoinments");

            migrationBuilder.AddColumn<DateTime>(
                name: "DayTime",
                table: "Appoinments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayTime",
                table: "Appoinments");

            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "Appoinments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Appoinments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
