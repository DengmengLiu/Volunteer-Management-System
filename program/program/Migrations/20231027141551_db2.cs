﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace program.Migrations
{
    /// <inheritdoc />
    public partial class db2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserActivity_User_UserId1",
                table: "UserActivity");

            migrationBuilder.DropIndex(
                name: "IX_UserActivity_UserId1",
                table: "UserActivity");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserActivity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "UserActivity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserActivity_UserId1",
                table: "UserActivity",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivity_User_UserId1",
                table: "UserActivity",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
