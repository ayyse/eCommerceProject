﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceProject.Migrations
{
    public partial class Updated_Product_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrandName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TypeName",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BrandName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
