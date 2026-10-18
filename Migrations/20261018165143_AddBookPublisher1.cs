using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Androne_Larisa_lab2.Migrations
{
    /// <inheritdoc />
    public partial class AddBookPublisher1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherID",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherID",
                table: "Books",
                column: "PublisherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publisher_PublisherID",
                table: "Books",
                column: "PublisherID",
                principalTable: "Publisher",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publisher_PublisherID",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropIndex(
                name: "IX_Books_PublisherID",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublisherID",
                table: "Books");
        }
    }
}
