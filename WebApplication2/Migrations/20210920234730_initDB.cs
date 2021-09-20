using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToyProject1.Migrations
{
    public partial class initDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDo",
                columns: table => new
                {
                    ToDoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToDoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDoStatus = table.Column<bool>(type: "bit", nullable: false),
                    ToDoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDoCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDoDueDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDo", x => x.ToDoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDo");
        }
    }
}
