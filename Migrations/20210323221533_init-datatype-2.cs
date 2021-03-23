using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rzr_pages_mariadb.Migrations
{
    public partial class initdatatype2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Products",
                type: "varchar(24) CHARACTER SET utf8mb4",
                maxLength: 24,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(24) CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<uint>(
                name: "ProductID",
                table: "Products",
                type: "int unsigned",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<uint>(
                name: "Stock",
                table: "Products",
                type: "int unsigned",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    RatingID = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductID = table.Column<uint>(type: "int unsigned", nullable: false),
                    Score = table.Column<uint>(type: "int unsigned", nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.RatingID);
                    table.ForeignKey(
                        name: "FK_Rating_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rating_ProductID",
                table: "Rating",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Products",
                type: "VARCHAR(24) CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(24) CHARACTER SET utf8mb4",
                oldMaxLength: 24);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
