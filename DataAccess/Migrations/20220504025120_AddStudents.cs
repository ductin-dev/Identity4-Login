using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO Students (Name,Gender,Description) VALUES (N'Đoàn Đức Tín 0','Nam','Tôi là code')");
            migrationBuilder.Sql($"INSERT INTO Students (Name,Gender,Description) VALUES (N'Đoàn Đức Tín 1','Nam','Tôi là code 1')");
            migrationBuilder.Sql($"INSERT INTO Students (Name,Gender,Description) VALUES (N'Đoàn Đức Tín 2 ','Nam','Tôi là code 2')");
            migrationBuilder.Sql($"INSERT INTO Students (Name,Gender,Description) VALUES (N'Đoàn Đức Tín 3','Nam','Tôi là code 3')");
            migrationBuilder.Sql($"INSERT INTO Students (Name,Gender,Description) VALUES (N'Đoàn Đức Tín 4','Nam','Tôi là code 4')");
            migrationBuilder.Sql($"INSERT INTO Students (Name,Gender,Description) VALUES (N'Đoàn Đức Tín 5','Nam','Tôi là code 5')");
            migrationBuilder.Sql($"INSERT INTO Students (Name,Gender,Description) VALUES (N'Đoàn Đức Tín 6','Nam','Tôi là code 6')");
            migrationBuilder.Sql($"INSERT INTO Students (Name,Gender,Description) VALUES (N'Đoàn Đức Tín 7','Nam','Tôi là code 7')");
            migrationBuilder.Sql($"INSERT INTO Students (Name,Gender,Description) VALUES (N'Đoàn Đức Tín 8','Nam','Tôi là code 8')");
            migrationBuilder.Sql($"INSERT INTO Students (Name,Gender,Description) VALUES (N'Đoàn Đức Tín 9','Nam','Tôi là code 9')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
