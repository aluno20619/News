using Microsoft.EntityFrameworkCore.Migrations;

namespace News.Migrations
{
    public partial class NewDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NT_Noticias_NoticiasFK",
                table: "NT");

            migrationBuilder.DropForeignKey(
                name: "FK_NT_Topicos_TopicosFK",
                table: "NT");

            migrationBuilder.DropIndex(
                name: "IX_NT_NoticiasFK",
                table: "NT");

            migrationBuilder.DropIndex(
                name: "IX_NT_TopicosFK",
                table: "NT");

            migrationBuilder.DropColumn(
                name: "NoticiasFK",
                table: "NT");

            migrationBuilder.DropColumn(
                name: "TopicosFK",
                table: "NT");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Imagens",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NT_Noticiasid",
                table: "NT",
                column: "Noticiasid");

            migrationBuilder.AddForeignKey(
                name: "FK_NT_Noticias_Noticiasid",
                table: "NT",
                column: "Noticiasid",
                principalTable: "Noticias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NT_Topicos_Topicosid",
                table: "NT",
                column: "Topicosid",
                principalTable: "Topicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NT_Noticias_Noticiasid",
                table: "NT");

            migrationBuilder.DropForeignKey(
                name: "FK_NT_Topicos_Topicosid",
                table: "NT");

            migrationBuilder.DropIndex(
                name: "IX_NT_Noticiasid",
                table: "NT");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Imagens");

            migrationBuilder.AddColumn<int>(
                name: "NoticiasFK",
                table: "NT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TopicosFK",
                table: "NT",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NT_NoticiasFK",
                table: "NT",
                column: "NoticiasFK");

            migrationBuilder.CreateIndex(
                name: "IX_NT_TopicosFK",
                table: "NT",
                column: "TopicosFK");

            migrationBuilder.AddForeignKey(
                name: "FK_NT_Noticias_NoticiasFK",
                table: "NT",
                column: "NoticiasFK",
                principalTable: "Noticias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NT_Topicos_TopicosFK",
                table: "NT",
                column: "TopicosFK",
                principalTable: "Topicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
