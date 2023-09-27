using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace etickets1.Migrations
{
    public partial class FixMovieCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictureUrl",
                table: "Producers",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Movies",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "Move_Category",
                table: "Movies",
                newName: "MovieCategory");

            migrationBuilder.RenameColumn(
                name: "logo",
                table: "Cinemas",
                newName: "Logo");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureUrl",
                table: "Actors",
                newName: "ProfilePictureURL");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Producers",
                newName: "ProfilePictureUrl");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Movies",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "MovieCategory",
                table: "Movies",
                newName: "Move_Category");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Cinemas",
                newName: "logo");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Actors",
                newName: "ProfilePictureUrl");
        }
    }
}
