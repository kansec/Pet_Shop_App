using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet_Shop_App.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    PetCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pets_PetCategories_PetCategoryId",
                        column: x => x.PetCategoryId,
                        principalTable: "PetCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    TreatmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operations_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Operations_Treatments_TreatmentId",
                        column: x => x.TreatmentId,
                        principalTable: "Treatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationsVets",
                columns: table => new
                {
                    OperationId = table.Column<int>(type: "int", nullable: false),
                    VetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationsVets", x => new { x.OperationId, x.VetId });
                    table.ForeignKey(
                        name: "FK_OperationsVets_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationsVets_Vets_VetId",
                        column: x => x.VetId,
                        principalTable: "Vets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Operations_PetId",
                table: "Operations",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_TreatmentId",
                table: "Operations",
                column: "TreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationsVets_VetId",
                table: "OperationsVets",
                column: "VetId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_OwnerId",
                table: "Pets",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_PetCategoryId",
                table: "Pets",
                column: "PetCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationsVets");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropTable(
                name: "Vets");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "PetCategories");
        }
    }
}
