using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptTarget.Migrations
{
    /// <inheritdoc />
    public partial class DeleteLastUpdateCrypt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "Crypts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "Crypts",
                type: "datetime2",
                nullable: true);
        }
    }
}
