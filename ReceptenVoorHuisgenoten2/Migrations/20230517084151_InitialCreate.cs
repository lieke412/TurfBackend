using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceptenVoorHuisgenoten2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IngredientRecept",
                columns: table => new
                {
                    IngredientenID = table.Column<int>(type: "int", nullable: false),
                    receptenID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecept", x => new { x.IngredientenID, x.receptenID });
                    table.ForeignKey(
                        name: "FK_IngredientRecept_Ingredienten_IngredientenID",
                        column: x => x.IngredientenID,
                        principalTable: "Ingredienten",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecept_Recepten_receptenID",
                        column: x => x.receptenID,
                        principalTable: "Recepten",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecept_receptenID",
                table: "IngredientRecept",
                column: "receptenID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientRecept");
        }
    }
}
