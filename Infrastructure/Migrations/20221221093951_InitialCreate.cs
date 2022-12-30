using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "portfolioItem",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    ProjectName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_portfolioItem", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "owner",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    FullName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    Profile = table.Column<string>(nullable: true),
                    addressID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owner", x => x.ID);
                    table.ForeignKey(
                        name: "FK_owner_Address_addressID",
                        column: x => x.addressID,
                        principalTable: "Address",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "ID", "Avatar", "FullName", "Name", "Profile", "addressID" },
                values: new object[] { new Guid("cf37789d-a754-4936-a59f-e56cb82cb2de"), "Avatar.jpg", "Ahmed Elsayed Moustafa", null, "Dot Net FullStack Developer", null });

            migrationBuilder.CreateIndex(
                name: "IX_owner_addressID",
                table: "owner",
                column: "addressID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "owner");

            migrationBuilder.DropTable(
                name: "portfolioItem");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
