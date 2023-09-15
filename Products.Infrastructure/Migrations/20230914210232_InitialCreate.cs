//using System;
//using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.EntityFrameworkCore.Migrations;

//namespace Scheduling.Infra.Data.Migrations
//{
//    public partial class InitialCreate : Migration
//    {
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.CreateTable(
//                name: "Users",
//                columns: table => new
//                {
//                    Id = table.Column<int>(nullable: false)
//                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
//                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
//                    Email = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
//                    UserName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
//                    Password = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
//                    HashPassword = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
//                    Role = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Users", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "Schedules",
//                columns: table => new
//                {
//                    Id = table.Column<int>(nullable: false)
//                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
//                    UserId = table.Column<int>(type: "int", nullable: false),
//                    Cep = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
//                    UF = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
//                    Cidade = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
//                    Bairro = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
//                    Logradouro = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
//                    Numero = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
//                    DataHoraInicio = table.Column<DateTime>(type: "DateTime", nullable: false),
//                    DataHoraFim = table.Column<DateTime>(type: "DateTime", nullable: false),
//                    Obs = table.Column<string>(type: "Text", nullable: true),
//                    DataHoraRegistro = table.Column<DateTime>(type: "DateTime", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Schedules", x => x.Id);
//                    table.ForeignKey(
//                        name: "FK_Schedules_Users_UserId",
//                        column: x => x.UserId,
//                        principalTable: "Users",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                });

//            migrationBuilder.InsertData(
//                table: "Users",
//                columns: new[] { "Id", "Email", "HashPassword", "Name", "Password", "Role", "UserName" },
//                values: new object[] { 1, "admin@admin.com", "ANKiHtbOQ0DHPNRTFJZVOOxmRS5Nid/Bx3qyaTjzXIsHN0wra+I5cV1scNiDdfokkw==", "Adminstrador", "", "manager", "Admin" });

//            migrationBuilder.InsertData(
//                table: "Users",
//                columns: new[] { "Id", "Email", "HashPassword", "Name", "Password", "Role", "UserName" },
//                values: new object[] { 2, "user@admin.com", "AC1l+ueW/JpRBi5cXjfd2JmjrXx7/wp9Tgap5MdW2APtEtAiQqDhfRLFh/iGieQqWA==", "Usuario Padrao", "", "employee", "User" });

//            migrationBuilder.CreateIndex(
//                name: "IX_Schedules_UserId",
//                table: "Schedules",
//                column: "UserId");

//            migrationBuilder.CreateIndex(
//                name: "IX_Users_UserName",
//                table: "Users",
//                column: "UserName",
//                unique: true);
//        }

//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropTable(
//                name: "Schedules");

//            migrationBuilder.DropTable(
//                name: "Users");
//        }
//    }
//}
