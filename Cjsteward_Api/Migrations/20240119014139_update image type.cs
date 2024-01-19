using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cjsteward_Api.Migrations
{
    /// <inheritdoc />
    public partial class updateimagetype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyPicture",
                table: "AboutMe",
                newName: "MyPictureStored");

            migrationBuilder.AddColumn<string>(
                name: "MyPictureWeb",
                table: "AboutMe",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyPictureWeb",
                table: "AboutMe");

            migrationBuilder.RenameColumn(
                name: "MyPictureStored",
                table: "AboutMe",
                newName: "MyPicture");
        }
    }
}
