using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectraASP.Migrations
{
    /// <inheritdoc />
    public partial class NextNextMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_CPU_Table_ProcessorID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Cases_CaseID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Coolers_CoolerID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Motherboards_MotherboardID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Powers_PowerSupplyID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_RAM_Table_MemoryID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_SSD_Table_StorageID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_VideoCards_GraphicsCardID",
                table: "ShoppingCart");

            migrationBuilder.AlterColumn<int>(
                name: "StorageID",
                table: "ShoppingCart",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProcessorID",
                table: "ShoppingCart",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PowerSupplyID",
                table: "ShoppingCart",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MotherboardID",
                table: "ShoppingCart",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MemoryID",
                table: "ShoppingCart",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GraphicsCardID",
                table: "ShoppingCart",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CoolerID",
                table: "ShoppingCart",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CaseID",
                table: "ShoppingCart",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_CPU_Table_ProcessorID",
                table: "ShoppingCart",
                column: "ProcessorID",
                principalTable: "CPU_Table",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Cases_CaseID",
                table: "ShoppingCart",
                column: "CaseID",
                principalTable: "Cases",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Coolers_CoolerID",
                table: "ShoppingCart",
                column: "CoolerID",
                principalTable: "Coolers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Motherboards_MotherboardID",
                table: "ShoppingCart",
                column: "MotherboardID",
                principalTable: "Motherboards",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Powers_PowerSupplyID",
                table: "ShoppingCart",
                column: "PowerSupplyID",
                principalTable: "Powers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_RAM_Table_MemoryID",
                table: "ShoppingCart",
                column: "MemoryID",
                principalTable: "RAM_Table",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_SSD_Table_StorageID",
                table: "ShoppingCart",
                column: "StorageID",
                principalTable: "SSD_Table",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_VideoCards_GraphicsCardID",
                table: "ShoppingCart",
                column: "GraphicsCardID",
                principalTable: "VideoCards",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_CPU_Table_ProcessorID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Cases_CaseID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Coolers_CoolerID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Motherboards_MotherboardID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Powers_PowerSupplyID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_RAM_Table_MemoryID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_SSD_Table_StorageID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_VideoCards_GraphicsCardID",
                table: "ShoppingCart");

            migrationBuilder.AlterColumn<int>(
                name: "StorageID",
                table: "ShoppingCart",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProcessorID",
                table: "ShoppingCart",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PowerSupplyID",
                table: "ShoppingCart",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MotherboardID",
                table: "ShoppingCart",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MemoryID",
                table: "ShoppingCart",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GraphicsCardID",
                table: "ShoppingCart",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CoolerID",
                table: "ShoppingCart",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CaseID",
                table: "ShoppingCart",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_CPU_Table_ProcessorID",
                table: "ShoppingCart",
                column: "ProcessorID",
                principalTable: "CPU_Table",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Cases_CaseID",
                table: "ShoppingCart",
                column: "CaseID",
                principalTable: "Cases",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Coolers_CoolerID",
                table: "ShoppingCart",
                column: "CoolerID",
                principalTable: "Coolers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Motherboards_MotherboardID",
                table: "ShoppingCart",
                column: "MotherboardID",
                principalTable: "Motherboards",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Powers_PowerSupplyID",
                table: "ShoppingCart",
                column: "PowerSupplyID",
                principalTable: "Powers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_RAM_Table_MemoryID",
                table: "ShoppingCart",
                column: "MemoryID",
                principalTable: "RAM_Table",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_SSD_Table_StorageID",
                table: "ShoppingCart",
                column: "StorageID",
                principalTable: "SSD_Table",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_VideoCards_GraphicsCardID",
                table: "ShoppingCart",
                column: "GraphicsCardID",
                principalTable: "VideoCards",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
