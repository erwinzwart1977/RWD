using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Team",
                table: "Users",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Diets",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Users",
                type: "TEXT",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Challenges",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_EventId",
                table: "Challenges",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Challenges_Events_EventId",
                table: "Challenges",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Challenges_Events_EventId",
                table: "Challenges");

            migrationBuilder.DropIndex(
                name: "IX_Challenges_EventId",
                table: "Challenges");

            migrationBuilder.DropColumn(
                name: "Diets",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Challenges");

            migrationBuilder.AlterColumn<string>(
                name: "Team",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50);
        }
    }
}
