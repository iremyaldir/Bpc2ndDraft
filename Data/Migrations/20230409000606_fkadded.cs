using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BPC.Data.Migrations
{
    /// <inheritdoc />
    public partial class fkadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Books",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "BuyId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Buys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buys", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BuyId",
                table: "Books",
                column: "BuyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Buys_BuyId",
                table: "Books",
                column: "BuyId",
                principalTable: "Buys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Buys_BuyId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Buys");

            migrationBuilder.DropIndex(
                name: "IX_Books_BuyId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BuyId",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);
        }
    }
}
