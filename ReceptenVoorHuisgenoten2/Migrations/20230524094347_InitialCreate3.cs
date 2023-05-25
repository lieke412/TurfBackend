using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceptenVoorHuisgenoten2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredienten_Recepten_ReceptID",
                table: "Ingredienten");

            migrationBuilder.DropIndex(
                name: "IX_Ingredienten_ReceptID",
                table: "Ingredienten");

            migrationBuilder.DropColumn(
                name: "ReceptID",
                table: "Ingredienten");

            migrationBuilder.CreateTable(
                name: "IngredientRecept",
                columns: table => new
                {
                    IngredientenID = table.Column<int>(type: "int", nullable: false),
                    ReceptenID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecept", x => new { x.IngredientenID, x.ReceptenID });
                    table.ForeignKey(
                        name: "FK_IngredientRecept_Ingredienten_IngredientenID",
                        column: x => x.IngredientenID,
                        principalTable: "Ingredienten",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecept_Recepten_ReceptenID",
                        column: x => x.ReceptenID,
                        principalTable: "Recepten",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecept_ReceptenID",
                table: "IngredientRecept",
                column: "ReceptenID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientRecept");

            migrationBuilder.AddColumn<int>(
                name: "ReceptID",
                table: "Ingredienten",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredienten_ReceptID",
                table: "Ingredienten",
                column: "ReceptID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredienten_Recepten_ReceptID",
                table: "Ingredienten",
                column: "ReceptID",
                principalTable: "Recepten",
                principalColumn: "ID");
        }
    }
}
