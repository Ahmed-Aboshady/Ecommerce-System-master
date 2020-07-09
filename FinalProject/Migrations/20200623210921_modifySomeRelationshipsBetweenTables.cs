using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class modifySomeRelationshipsBetweenTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "orderTotalPriceAfterPromoCode",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "orederStatus",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "promoCode",
                table: "orders");

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "orders",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "orderStatus",
                table: "orders",
                maxLength: 10,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "orderStatus",
                table: "orders");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "orderTotalPriceAfterPromoCode",
                table: "orders",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "orederStatus",
                table: "orders",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "promoCode",
                table: "orders",
                type: "int",
                nullable: true);
        }
    }
}
