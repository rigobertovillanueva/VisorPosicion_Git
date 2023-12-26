using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisorPosicion5.Migrations
{
    public partial class UpdateLinkIdToIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // If you need to modify the LinkID column to be an identity column
            migrationBuilder.AlterColumn<int>(
                name: "LinkID",
                table: "VentaCompraLink",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Reverse the changes made in the Up method
            migrationBuilder.AlterColumn<int>(
                name: "LinkID",
                table: "VentaCompraLink",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}

