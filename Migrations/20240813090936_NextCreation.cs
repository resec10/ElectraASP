using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectraASP.Migrations
{
    /// <inheritdoc />
    public partial class NextCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseID = table.Column<int>(type: "int", nullable: false),
                    CoolerID = table.Column<int>(type: "int", nullable: false),
                    ProcessorID = table.Column<int>(type: "int", nullable: false),
                    MotherboardID = table.Column<int>(type: "int", nullable: false),
                    PowerSupplyID = table.Column<int>(type: "int", nullable: false),
                    MemoryID = table.Column<int>(type: "int", nullable: false),
                    StorageID = table.Column<int>(type: "int", nullable: false),
                    GraphicsCardID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_CPU_Table_ProcessorID",
                        column: x => x.ProcessorID,
                        principalTable: "CPU_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_Cases_CaseID",
                        column: x => x.CaseID,
                        principalTable: "Cases",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_Coolers_CoolerID",
                        column: x => x.CoolerID,
                        principalTable: "Coolers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_Motherboards_MotherboardID",
                        column: x => x.MotherboardID,
                        principalTable: "Motherboards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_Powers_PowerSupplyID",
                        column: x => x.PowerSupplyID,
                        principalTable: "Powers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_RAM_Table_MemoryID",
                        column: x => x.MemoryID,
                        principalTable: "RAM_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_SSD_Table_StorageID",
                        column: x => x.StorageID,
                        principalTable: "SSD_Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_VideoCards_GraphicsCardID",
                        column: x => x.GraphicsCardID,
                        principalTable: "VideoCards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToBeBought",
                columns: table => new
                {
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageWidth = table.Column<int>(type: "int", nullable: false),
                    ImageHeight = table.Column<int>(type: "int", nullable: false),
                    ComputerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ToBeBought_Computers_ComputerID",
                        column: x => x.ComputerID,
                        principalTable: "Computers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_CaseID",
                table: "ShoppingCart",
                column: "CaseID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_CoolerID",
                table: "ShoppingCart",
                column: "CoolerID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_GraphicsCardID",
                table: "ShoppingCart",
                column: "GraphicsCardID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_MemoryID",
                table: "ShoppingCart",
                column: "MemoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_MotherboardID",
                table: "ShoppingCart",
                column: "MotherboardID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_PowerSupplyID",
                table: "ShoppingCart",
                column: "PowerSupplyID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_ProcessorID",
                table: "ShoppingCart",
                column: "ProcessorID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_StorageID",
                table: "ShoppingCart",
                column: "StorageID");

            migrationBuilder.CreateIndex(
                name: "IX_ToBeBought_ComputerID",
                table: "ToBeBought",
                column: "ComputerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DropTable(
                name: "ToBeBought");
        }
    }
}
