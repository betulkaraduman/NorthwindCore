using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NorthwindCore.Migrations
{
    public partial class createDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Custumers",
                columns: table => new
                {
                    CostumerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(maxLength: 100, nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    ContactTitle = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Custumers", x => x.CostumerID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(nullable: true),
                    LName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    BDay = table.Column<DateTime>(nullable: false),
                    HireDay = table.Column<DateTime>(nullable: false),
                    Adress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "Shippers",
                columns: table => new
                {
                    ShipperID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(maxLength: 40, nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.ShipperID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(maxLength: 40, nullable: false),
                    ContactName = table.Column<string>(maxLength: 30, nullable: true),
                    ContactTitle = table.Column<string>(maxLength: 30, nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "Territories",
                columns: table => new
                {
                    TerritoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Territories", x => x.TerritoryId);
                    table.ForeignKey(
                        name: "FK_Territories_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrdersId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    RequiredDate = table.Column<DateTime>(nullable: false),
                    ShipperDate = table.Column<DateTime>(nullable: false),
                    ShipVia = table.Column<int>(nullable: false),
                    Freight = table.Column<decimal>(nullable: false),
                    ShipName = table.Column<string>(nullable: true),
                    ShippAdress = table.Column<string>(nullable: true),
                    ShipCountry = table.Column<string>(nullable: true),
                    ShipCity = table.Column<string>(nullable: true),
                    ShipRegion = table.Column<string>(nullable: true),
                    ShipPostalCode = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    RowGuid = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    CustumerCostumerID = table.Column<int>(nullable: true),
                    ShipperID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrdersId);
                    table.ForeignKey(
                        name: "FK_Orders_Custumers_CustumerCostumerID",
                        column: x => x.CustumerCostumerID,
                        principalTable: "Custumers",
                        principalColumn: "CostumerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Shippers_ShipperID",
                        column: x => x.ShipperID,
                        principalTable: "Shippers",
                        principalColumn: "ShipperID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GetProducts",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ShipperId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    QuantityPerUnit = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    UnitInStcok = table.Column<int>(nullable: false),
                    UnitOnOrder = table.Column<int>(nullable: false),
                    DisContinued = table.Column<bool>(nullable: false),
                    ReorderLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetProducts", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_GetProducts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GetProducts_Suppliers_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTerritories",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    TerritoriesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTerritories", x => new { x.EmployeeId, x.TerritoriesId });
                    table.ForeignKey(
                        name: "FK_EmployeeTerritories_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTerritories_Territories_TerritoriesId",
                        column: x => x.TerritoriesId,
                        principalTable: "Territories",
                        principalColumn: "TerritoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrdersDetails_Orders_OrderDetailId",
                        column: x => x.OrderDetailId,
                        principalTable: "Orders",
                        principalColumn: "OrdersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersDetails_GetProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "GetProducts",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTerritories_TerritoriesId",
                table: "EmployeeTerritories",
                column: "TerritoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_GetProducts_CategoryId",
                table: "GetProducts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GetProducts_ShipperId",
                table: "GetProducts",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustumerCostumerID",
                table: "Orders",
                column: "CustumerCostumerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EmployeeId",
                table: "Orders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShipperID",
                table: "Orders",
                column: "ShipperID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetails_ProductId",
                table: "OrdersDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Territories_RegionId",
                table: "Territories",
                column: "RegionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTerritories");

            migrationBuilder.DropTable(
                name: "OrdersDetails");

            migrationBuilder.DropTable(
                name: "Territories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "GetProducts");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Custumers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Shippers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
