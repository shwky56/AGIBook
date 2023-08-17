using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace book_stor.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE BookUser ADD Status VARCHAR(20) NOT NULL DEFAULT 'pending' CONSTRAINT CK_BookUser_Status CHECK (Status IN ('pending', 'accept', 'not-accept'));");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
