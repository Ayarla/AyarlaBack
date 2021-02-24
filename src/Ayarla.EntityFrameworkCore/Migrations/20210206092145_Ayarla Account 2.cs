using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ayarla.Migrations
{
    public partial class AyarlaAccount2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OpenCloseTime",
                table: "Accounts",
                newName: "OpenCloseTimeId");

            migrationBuilder.RenameColumn(
                name: "OpenAddress",
                table: "Accounts",
                newName: "AddressDetail");

            migrationBuilder.RenameColumn(
                name: "BusinessTypeId",
                table: "Accounts",
                newName: "AccountTypeId");

            migrationBuilder.RenameColumn(
                name: "BusinessName",
                table: "Accounts",
                newName: "AccountName");

            migrationBuilder.RenameColumn(
                name: "BusinessImage",
                table: "Accounts",
                newName: "AccountImage");

            migrationBuilder.CreateTable(
                name: "OpenCloseTimes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    DayOfTheWeek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkStartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    WorkEndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenCloseTimes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OpenCloseTimes");

            migrationBuilder.RenameColumn(
                name: "OpenCloseTimeId",
                table: "Accounts",
                newName: "OpenCloseTime");

            migrationBuilder.RenameColumn(
                name: "AddressDetail",
                table: "Accounts",
                newName: "OpenAddress");

            migrationBuilder.RenameColumn(
                name: "AccountTypeId",
                table: "Accounts",
                newName: "BusinessTypeId");

            migrationBuilder.RenameColumn(
                name: "AccountName",
                table: "Accounts",
                newName: "BusinessName");

            migrationBuilder.RenameColumn(
                name: "AccountImage",
                table: "Accounts",
                newName: "BusinessImage");
        }
    }
}
