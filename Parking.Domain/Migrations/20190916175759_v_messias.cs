using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parking.Domain.Migrations
{
    public partial class v_messias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DailyRate",
                table: "Rate");

            migrationBuilder.DropColumn(
                name: "NightRate",
                table: "Rate");

            migrationBuilder.DropColumn(
                name: "PeriodRate",
                table: "Rate");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Parking");

            migrationBuilder.DropColumn(
                name: "DiscountPercentual",
                table: "Agreement");

            migrationBuilder.AddColumn<decimal>(
                name: "DailyAmount",
                table: "Rate",
                type: "money",
                maxLength: 50,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OverNightAmount",
                table: "Rate",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PeriodAmount",
                table: "Rate",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "Car",
                type: "varchar(04)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPercentage",
                table: "Agreement",
                type: "money",
                maxLength: 250,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Document = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    LegalEntity = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropColumn(
                name: "DailyAmount",
                table: "Rate");

            migrationBuilder.DropColumn(
                name: "OverNightAmount",
                table: "Rate");

            migrationBuilder.DropColumn(
                name: "PeriodAmount",
                table: "Rate");

            migrationBuilder.DropColumn(
                name: "DiscountPercentage",
                table: "Agreement");

            migrationBuilder.AddColumn<decimal>(
                name: "DailyRate",
                table: "Rate",
                type: "money",
                maxLength: 50,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NightRate",
                table: "Rate",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PeriodRate",
                table: "Rate",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Parking",
                type: "varchar(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Year",
                table: "Car",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(04)",
                oldMaxLength: 4);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPercentual",
                table: "Agreement",
                type: "money",
                maxLength: 250,
                nullable: false,
                defaultValue: 0m);
        }
    }
}
