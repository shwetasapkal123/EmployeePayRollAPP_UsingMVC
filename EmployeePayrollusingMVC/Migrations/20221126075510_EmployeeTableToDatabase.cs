using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeePayrollusingMVC.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeTableToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ModelsEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicPay = table.Column<double>(type: "float", nullable: false),
                    StartDate = table.Column<DateTime>(name: "Start_Date", type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Phone = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deductions = table.Column<double>(type: "float", nullable: false),
                    Taxable = table.Column<double>(type: "float", nullable: false),
                    IncomeTax = table.Column<double>(type: "float", nullable: false),
                    NetPay = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelsEmployee", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelsEmployee");
        }
    }
}
