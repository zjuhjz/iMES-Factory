using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iMES.Core.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Base_DefectItem",
                columns: table => new
                {
                    DefectItemId = table.Column<int>(name: "DefectItem_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DefectItemCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DefectItemName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Attachment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base_DefectItem", x => x.DefectItemId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Base_DesktopMenu",
                columns: table => new
                {
                    DesktopMenuId = table.Column<int>(name: "DesktopMenu_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MenuUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Enable = table.Column<sbyte>(type: "tinyint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base_DesktopMenu", x => x.DesktopMenuId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Base_MaterialDetail",
                columns: table => new
                {
                    MaterialDetailId = table.Column<int>(name: "MaterialDetail_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentProductId = table.Column<int>(name: "ParentProduct_Id", type: "int", nullable: false),
                    ChildProductId = table.Column<int>(name: "ChildProduct_Id", type: "int", nullable: false),
                    QuantityPer = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base_MaterialDetail", x => x.MaterialDetailId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Base_MeritPay",
                columns: table => new
                {
                    MeritPayId = table.Column<int>(name: "MeritPay_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProcessId = table.Column<int>(name: "Process_Id", type: "int", nullable: true),
                    UnitId = table.Column<int>(name: "Unit_Id", type: "int", nullable: true),
                    ProductId = table.Column<int>(name: "Product_Id", type: "int", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    StandardNumber = table.Column<int>(type: "int", nullable: true),
                    StandardHour = table.Column<int>(type: "int", nullable: true),
                    StandardMin = table.Column<int>(type: "int", nullable: true),
                    StandardSec = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base_MeritPay", x => x.MeritPayId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Base_Notice",
                columns: table => new
                {
                    NoticeId = table.Column<int>(name: "Notice_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NoticeType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NoticeTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NoticeContent = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base_Notice", x => x.NoticeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Base_NumberRule",
                columns: table => new
                {
                    NumberRuleId = table.Column<int>(name: "NumberRule_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FormCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Prefix = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SubmitTime = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SerialNumber = table.Column<int>(type: "int", nullable: false),
                    GenerativeRule = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base_NumberRule", x => x.NumberRuleId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Base_Process",
                columns: table => new
                {
                    ProcessId = table.Column<int>(name: "Process_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProcessCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProcessName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubmitWorkLimit = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SubmitWorkMatch = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DefectItem = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base_Process", x => x.ProcessId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Base_ProcessLine",
                columns: table => new
                {
                    ProcessLineId = table.Column<int>(name: "ProcessLine_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProcessLineCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProcessLineName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base_ProcessLine", x => x.ProcessLineId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Base_Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(name: "Product_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnitId = table.Column<int>(name: "Unit_Id", type: "int", nullable: false),
                    ProductStandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductAttribute = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProcessId = table.Column<int>(name: "Process_Id", type: "int", nullable: true),
                    MaxInventory = table.Column<int>(type: "int", nullable: true),
                    MinInventory = table.Column<int>(type: "int", nullable: true),
                    SafeInventory = table.Column<int>(type: "int", nullable: true),
                    InventoryQty = table.Column<int>(type: "int", nullable: true),
                    FinishedProduct = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base_Product", x => x.ProductId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Base_WorkShop",
                columns: table => new
                {
                    WorkShopId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkShopName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WorkShopCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MainPerson = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Area = table.Column<int>(type: "int", nullable: true),
                    Enable = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base_WorkShop", x => x.WorkShopId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cal_Holiday",
                columns: table => new
                {
                    HolidayId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TheDay = table.Column<DateTime>(type: "date", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HolidayType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cal_Holiday", x => x.HolidayId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cal_Plan",
                columns: table => new
                {
                    PlanId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PlanName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PlanCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TeamType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true),
                    ShiftType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ChangeShiftType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cal_Plan", x => x.PlanId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cal_PlanShift",
                columns: table => new
                {
                    PlanShiftId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PlanId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    PlanShiftName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartTime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EndTime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cal_PlanShift", x => x.PlanShiftId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cal_PlanTeam",
                columns: table => new
                {
                    PlanTeamId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PlanId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TeamId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TeamCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cal_PlanTeam", x => x.PlanTeamId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cal_Team",
                columns: table => new
                {
                    TeamId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TeamName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TeamCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TeamType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cal_Team", x => x.TeamId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cal_TeamShift",
                columns: table => new
                {
                    TeamShiftId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TheDate = table.Column<DateTime>(type: "date", nullable: false),
                    TeamId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TeamName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShiftId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShiftName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    PlanId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChangeShiftType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cal_TeamShift", x => x.TeamShiftId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Equip_DevCatalog",
                columns: table => new
                {
                    DevCatalogId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DevCatalogName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DevCatalogCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Enable = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<string>(type: "varchar(36)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equip_DevCatalog", x => x.DevCatalogId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Equip_Device",
                columns: table => new
                {
                    DeviceId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeviceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DeviceCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeviceBrand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModelType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WorkShopId = table.Column<string>(type: "varchar(36)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ParentId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equip_Device", x => x.DeviceId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Equip_MaintainPaper",
                columns: table => new
                {
                    MaintainPaperId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MaintainPaperName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaintainPaperCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeviceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DeviceCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeviceBrand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReportDate = table.Column<DateTime>(type: "date", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equip_MaintainPaper", x => x.MaintainPaperId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Equip_SpotMaintenance",
                columns: table => new
                {
                    SpotMaintenanceId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SpotMaintenanceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SpotMaintenanceCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Enable = table.Column<int>(type: "int", nullable: true),
                    ItemContent = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ItemStandard = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equip_SpotMaintenance", x => x.SpotMaintenanceId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Equip_SpotMaintPlan",
                columns: table => new
                {
                    SpotMaintPlanId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SpotMaintPlanName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SpotMaintPlanCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PlanItemType = table.Column<int>(type: "int", nullable: false),
                    GhzQty = table.Column<int>(type: "int", nullable: false),
                    GhzQtyLat = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NextCheckDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equip_SpotMaintPlan", x => x.SpotMaintPlanId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Equip_SpotMaintPlanDevice",
                columns: table => new
                {
                    SpotMaintPlanDeviceId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SpotMaintPlanId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeviceId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeviceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DeviceCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeviceBrand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModelType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equip_SpotMaintPlanDevice", x => x.SpotMaintPlanDeviceId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Equip_SpotMaintPlanProject",
                columns: table => new
                {
                    SpotMaintPlanProjectId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SpotMaintPlanId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SpotMaintenanceId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SpotMaintenanceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SpotMaintenanceCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    ItemContent = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ItemStandard = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equip_SpotMaintPlanProject", x => x.SpotMaintPlanProjectId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Equip_SpotMaintWorkOrder",
                columns: table => new
                {
                    SpotMaintWorkOrderId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SpotMaintWorkOrderCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SpotMaintPlanId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SpotMaintPlanName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SpotMaintPlanCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PlanItemType = table.Column<int>(type: "int", nullable: false),
                    PlanStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    PlanEndDate = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equip_SpotMaintWorkOrder", x => x.SpotMaintWorkOrderId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FormCollectionObject",
                columns: table => new
                {
                    FormCollectionId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FormId = table.Column<string>(type: "varchar(36)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormCollectionObject", x => x.FormCollectionId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FormDesignOptions",
                columns: table => new
                {
                    FormId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DaraggeOptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormOptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormConfig = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormFields = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableConfig = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormDesignOptions", x => x.FormId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quality_Defect",
                columns: table => new
                {
                    DefectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DefectName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DefectType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DefectLevel = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality_Defect", x => x.DefectId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quality_InComingCheck",
                columns: table => new
                {
                    InComingCheckId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InComingCheckName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InComingCheckCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<int>(name: "Product_Id", type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductStandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ReciveNumber = table.Column<int>(type: "int", nullable: false),
                    CheckNumber = table.Column<int>(type: "int", nullable: false),
                    DisStandNumber = table.Column<int>(type: "int", nullable: true),
                    InComingDate = table.Column<DateTime>(type: "date", nullable: false),
                    CheckDate = table.Column<DateTime>(type: "date", nullable: false),
                    Result = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality_InComingCheck", x => x.InComingCheckId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quality_OutCheck",
                columns: table => new
                {
                    OutCheckId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OutCheckName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OutCheckCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<int>(name: "Product_Id", type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductStandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OutNumber = table.Column<int>(type: "int", nullable: false),
                    CheckNumber = table.Column<int>(type: "int", nullable: false),
                    DisStandNumber = table.Column<int>(type: "int", nullable: true),
                    OutDate = table.Column<DateTime>(type: "date", nullable: false),
                    CheckDate = table.Column<DateTime>(type: "date", nullable: false),
                    Result = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality_OutCheck", x => x.OutCheckId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quality_ProcessCheck",
                columns: table => new
                {
                    ProcessCheckId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProcessCheckName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProcessCheckCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CheckType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WorkOrderId = table.Column<int>(name: "WorkOrder_Id", type: "int", nullable: false),
                    WorkOrderCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<int>(name: "Product_Id", type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductStandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProcessId = table.Column<int>(name: "Process_Id", type: "int", nullable: true),
                    ProcessCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProcessName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StandNumber = table.Column<int>(type: "int", nullable: true),
                    DisStandNumber = table.Column<int>(type: "int", nullable: true),
                    CrQuantity = table.Column<int>(type: "int", nullable: true),
                    MajQuantity = table.Column<int>(type: "int", nullable: true),
                    MinQuantity = table.Column<int>(type: "int", nullable: true),
                    CheckDate = table.Column<DateTime>(type: "date", nullable: false),
                    Result = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality_ProcessCheck", x => x.ProcessCheckId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quality_Template",
                columns: table => new
                {
                    TemplateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TemplateName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TemplateCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QcType = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Enable = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NextCheckDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality_Template", x => x.TemplateId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quality_TemplateProduct",
                columns: table => new
                {
                    TemplateProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductStandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CheckMin = table.Column<int>(type: "int", nullable: true),
                    DisQualityMax = table.Column<int>(type: "int", nullable: true),
                    CrRate = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    MajRate = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    MinRate = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality_TemplateProduct", x => x.TemplateProductId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quality_TemplateTestItem",
                columns: table => new
                {
                    TemplateTestItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    TestItemId = table.Column<int>(type: "int", nullable: false),
                    TestItemType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    QCTool = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TestItemCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TestItemName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CheckMethod = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StanderValue = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    ThresholdMax = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    ThresholdMin = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality_TemplateTestItem", x => x.TemplateTestItemId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quality_TestItem",
                columns: table => new
                {
                    TestItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TestItemCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TestItemName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TestItemType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    QCTool = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality_TestItem", x => x.TestItemId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_Dept",
                columns: table => new
                {
                    DeptId = table.Column<int>(name: "Dept_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeptName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeptCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Dept", x => x.DeptId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_Dictionary",
                columns: table => new
                {
                    DicID = table.Column<int>(name: "Dic_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DicNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DicName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Config = table.Column<string>(type: "nvarchar(10000)", maxLength: 10000, nullable: true),
                    DbSql = table.Column<string>(type: "nvarchar(10000)", maxLength: 10000, nullable: true),
                    DBServer = table.Column<string>(type: "nvarchar(10000)", maxLength: 10000, nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Enable = table.Column<sbyte>(type: "tinyint", nullable: false),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Dictionary", x => x.DicID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_Log",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BeginDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Url = table.Column<string>(type: "varchar(30000)", maxLength: 30000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LogType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Success = table.Column<int>(type: "int", nullable: true),
                    ElapsedTime = table.Column<int>(type: "int", nullable: true),
                    RequestParameter = table.Column<string>(type: "nvarchar(10000)", maxLength: 10000, nullable: true),
                    ResponseParameter = table.Column<string>(type: "nvarchar(10000)", maxLength: 10000, nullable: true),
                    ExceptionInfo = table.Column<string>(type: "nvarchar(10000)", maxLength: 10000, nullable: true),
                    UserIP = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServiceIP = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BrowserType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserId = table.Column<int>(name: "User_Id", type: "int", nullable: true),
                    UserName = table.Column<string>(type: "varchar(30000)", maxLength: 30000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<int>(name: "Role_Id", type: "int", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Log", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_Menu",
                columns: table => new
                {
                    MenuId = table.Column<int>(name: "Menu_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(10000)", maxLength: 10000, nullable: true),
                    Auth = table.Column<string>(type: "nvarchar(10000)", maxLength: 10000, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Enable = table.Column<sbyte>(type: "tinyint", nullable: true),
                    MenuType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Menu", x => x.MenuId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_QuartzLog",
                columns: table => new
                {
                    LogId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id = table.Column<string>(type: "varchar(36)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TaskName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ElapsedTime = table.Column<int>(type: "int", nullable: true),
                    StratDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Result = table.Column<int>(type: "int", nullable: true),
                    ResponseContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorMsg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_QuartzLog", x => x.LogId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_QuartzOptions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TaskName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CronExpression = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Method = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApiUrl = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    AuthKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AuthValue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Describe = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    LastRunTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    PostData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeOut = table.Column<int>(type: "int", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_QuartzOptions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(name: "Role_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeptId = table.Column<int>(name: "Dept_Id", type: "int", nullable: true),
                    DeptName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Enable = table.Column<sbyte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Role", x => x.RoleId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_TableInfo",
                columns: table => new
                {
                    TableId = table.Column<int>(name: "Table_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    TableName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TableTrueName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColumnCNName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Namespace = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FolderName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataTableType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EditorType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    UploadField = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UploadMaxCount = table.Column<int>(type: "int", nullable: true),
                    RichText = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExpressField = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DBServer = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SortName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DetailCnName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DetailName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Enable = table.Column<int>(type: "int", nullable: true),
                    CnName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_TableInfo", x => x.TableId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_Unit",
                columns: table => new
                {
                    UnitId = table.Column<int>(name: "Unit_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UnitName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Unit", x => x.UnitId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_User",
                columns: table => new
                {
                    UserId = table.Column<int>(name: "User_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    HeadImageUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    DeptId = table.Column<int>(name: "Dept_Id", type: "int", nullable: true),
                    DeptName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    RoleId = table.Column<int>(name: "Role_Id", type: "int", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Token = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AppType = table.Column<int>(type: "int", nullable: true),
                    UserTrueName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    UserPwd = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsRegregisterPhone = table.Column<int>(type: "int", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(22)", maxLength: 22, nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Enable = table.Column<sbyte>(type: "tinyint", nullable: false),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AuditStatus = table.Column<int>(type: "int", nullable: true),
                    Auditor = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    AuditDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastModifyPwdDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_User", x => x.UserId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_VersionInfo",
                columns: table => new
                {
                    VersionInfoId = table.Column<int>(name: "VersionInfo_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_VersionInfo", x => x.VersionInfoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_WorkFlow",
                columns: table => new
                {
                    WorkFlowId = table.Column<string>(name: "WorkFlow_Id", type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    WorkTable = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    WorkTableName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Enable = table.Column<sbyte>(type: "tinyint", nullable: true),
                    NodeConfig = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LineConfig = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_WorkFlow", x => x.WorkFlowId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_WorkFlowTable",
                columns: table => new
                {
                    WorkFlowTableId = table.Column<string>(name: "WorkFlowTable_Id", type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    WorkFlowId = table.Column<string>(name: "WorkFlow_Id", type: "varchar(36)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WorkTableKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WorkTable = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WorkTableName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CurrentOrderId = table.Column<int>(type: "int", nullable: true),
                    AuditStatus = table.Column<int>(type: "int", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Enable = table.Column<sbyte>(type: "tinyint", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_WorkFlowTable", x => x.WorkFlowTableId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tools_Tool",
                columns: table => new
                {
                    ToolId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ToolName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ToolCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Spec = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ToolTypeId = table.Column<string>(type: "varchar(36)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    QuantityAvail = table.Column<int>(type: "int", nullable: true),
                    MaintenType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NextMaintenDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools_Tool", x => x.ToolId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tools_ToolsReceive",
                columns: table => new
                {
                    ToolsReceiveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ToolsReceiveCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ReceiveDate = table.Column<DateTime>(type: "date", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools_ToolsReceive", x => x.ToolsReceiveId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tools_ToolsReturn",
                columns: table => new
                {
                    ToolsReturnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ToolsReturnCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ToolsReturnDate = table.Column<DateTime>(type: "date", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools_ToolsReturn", x => x.ToolsReturnId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tools_ToolType",
                columns: table => new
                {
                    ToolTypeId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ToolTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ToolTypeCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MaintenType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MaintenPeriod = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools_ToolType", x => x.ToolTypeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "View_Base_MaterialDetail",
                columns: table => new
                {
                    MaterialDetailId = table.Column<int>(name: "MaterialDetail_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentProductId = table.Column<int>(name: "ParentProduct_Id", type: "int", nullable: false),
                    PProductCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PProductStandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PUnitId = table.Column<int>(name: "PUnit_Id", type: "int", nullable: true),
                    ChildProductId = table.Column<int>(name: "ChildProduct_Id", type: "int", nullable: false),
                    CProductCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CProductStandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CUnitId = table.Column<int>(name: "CUnit_Id", type: "int", nullable: true),
                    QuantityPer = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_View_Base_MaterialDetail", x => x.MaterialDetailId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "View_DefectItemDistribute",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateDate = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefectItemCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DefectItemName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    AllQty = table.Column<int>(type: "int", nullable: true),
                    PassPercent = table.Column<string>(type: "varchar(101)", maxLength: 101, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_View_DefectItemDistribute", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "View_DefectItemSummary",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkOrderCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductStandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProcessCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProcessName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserTrueName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DefectItem = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DefectItemName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PlanQty = table.Column<int>(type: "int", nullable: true),
                    ReportQty = table.Column<int>(type: "int", nullable: true),
                    GoodQty = table.Column<int>(type: "int", nullable: true),
                    NoGoodQty = table.Column<int>(type: "int", nullable: false),
                    NoPassPercent = table.Column<string>(type: "varchar(101)", maxLength: 101, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_View_DefectItemSummary", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "View_EmployeePerformance",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductUser = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserTrueName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ProcessCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProcessName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProductStandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UnitId = table.Column<int>(name: "Unit_Id", type: "int", nullable: true),
                    UnitName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    GoodQty = table.Column<int>(type: "int", nullable: true),
                    NoGoodQty = table.Column<int>(type: "int", nullable: false),
                    PassPercent = table.Column<string>(type: "varchar(101)", maxLength: 101, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AllQty = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_View_EmployeePerformance", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "View_OutputStatistics",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateDate = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PlanQty = table.Column<int>(type: "int", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProductStandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UnitId = table.Column<int>(name: "Unit_Id", type: "int", nullable: true),
                    GoodQty = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_View_OutputStatistics", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "View_ProductionReport",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductStandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UnitId = table.Column<int>(name: "Unit_Id", type: "int", nullable: true),
                    UnitName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WorkOrderCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PlanQty = table.Column<int>(type: "int", nullable: true),
                    RealQty = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PlanStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlanEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ActualStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ActualEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ProcessCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProcessName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubmitWorkMatch = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TaskPlanStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TaskPlanEndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TaskActualStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TaskActualEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TaskPlanQty = table.Column<int>(type: "int", nullable: false),
                    TaskRealQty = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_View_ProductionReport", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "View_SalaryReport",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReportDate = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductUser = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserTrueName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ReportAll = table.Column<int>(type: "int", nullable: true),
                    NoAlreadyAppNumber = table.Column<int>(type: "int", nullable: true),
                    NoAlreadyAppTime = table.Column<int>(type: "int", nullable: true),
                    AlreadyAppNumber = table.Column<int>(type: "int", nullable: true),
                    AlreadyAppTime = table.Column<int>(type: "int", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(65,30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_View_SalaryReport", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "View_StockBalance",
                columns: table => new
                {
                    ProductId = table.Column<int>(name: "Product_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProductStandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    InventoryQty = table.Column<int>(type: "int", nullable: true),
                    UnitId = table.Column<int>(name: "Unit_Id", type: "int", nullable: false),
                    ProcessId = table.Column<int>(name: "Process_Id", type: "int", nullable: true),
                    MaxInventory = table.Column<int>(type: "int", nullable: true),
                    MinInventory = table.Column<int>(type: "int", nullable: true),
                    SafeInventory = table.Column<int>(type: "int", nullable: true),
                    ProductAttribute = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_View_StockBalance", x => x.ProductId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "View_WareInOutDetail",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductStandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UnitId = table.Column<int>(name: "Unit_Id", type: "int", nullable: true),
                    FormQty = table.Column<int>(type: "int", nullable: false),
                    ChangeQty = table.Column<int>(type: "int", nullable: true),
                    WareHouseDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FromType = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    WareHouseBillCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WareHouseBillType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MinInventory = table.Column<int>(type: "int", nullable: true),
                    MaxInventory = table.Column<int>(type: "int", nullable: true),
                    SafeInventory = table.Column<int>(type: "int", nullable: true),
                    InventoryQty = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_View_WareInOutDetail", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "vSys_Dictionary",
                columns: table => new
                {
                    DicID = table.Column<int>(name: "Dic_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DicValue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DicListID = table.Column<int>(name: "DicList_ID", type: "int", nullable: false),
                    DicName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Enable = table.Column<sbyte>(type: "tinyint", nullable: true),
                    DicNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vSys_Dictionary", x => x.DicID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ware_OutWareHouseBill",
                columns: table => new
                {
                    OutWareHouseBillId = table.Column<int>(name: "OutWareHouseBill_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OutWareHouseBillCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OutWareHouseBillType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    OutWareHouseDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AuditStatus = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Attachement = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ware_OutWareHouseBill", x => x.OutWareHouseBillId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ware_WareHouseBill",
                columns: table => new
                {
                    WareHouseBillId = table.Column<int>(name: "WareHouseBill_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WareHouseBillCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WareHouseBillType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    WareHouseDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ware_WareHouseBill", x => x.WareHouseBillId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Base_ProcessList",
                columns: table => new
                {
                    ProcessListId = table.Column<int>(name: "ProcessList_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProcessId = table.Column<int>(name: "Process_Id", type: "int", nullable: false),
                    DataPointType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataPointName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base_ProcessList", x => x.ProcessListId);
                    table.ForeignKey(
                        name: "FK_Base_ProcessList_Base_Process_Process_Id",
                        column: x => x.ProcessId,
                        principalTable: "Base_Process",
                        principalColumn: "Process_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Base_ProcessLineList",
                columns: table => new
                {
                    ProcessLineListId = table.Column<int>(name: "ProcessLineList_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProcessLineId = table.Column<int>(name: "ProcessLine_Id", type: "int", nullable: false),
                    ProcessLineType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProcessId = table.Column<int>(name: "Process_Id", type: "int", nullable: true),
                    ProcessLineDownId = table.Column<int>(name: "ProcessLineDown_Id", type: "int", nullable: true),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    SubmitWorkMatch = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base_ProcessLineList", x => x.ProcessLineListId);
                    table.ForeignKey(
                        name: "FK_Base_ProcessLineList_Base_ProcessLine_ProcessLine_Id",
                        column: x => x.ProcessLineId,
                        principalTable: "Base_ProcessLine",
                        principalColumn: "ProcessLine_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cal_TeamMember",
                columns: table => new
                {
                    TeamMemberId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TeamId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<int>(name: "User_Id", type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserTrueName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cal_TeamMember", x => x.TeamMemberId);
                    table.ForeignKey(
                        name: "FK_Cal_TeamMember_Cal_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Cal_Team",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quality_InComingCheckTestItem",
                columns: table => new
                {
                    InComingCheckTestItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InComingCheckId = table.Column<int>(type: "int", nullable: false),
                    TemplateTestItemId = table.Column<int>(type: "int", nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    TestItemId = table.Column<int>(type: "int", nullable: false),
                    TestItemName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TestItemCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TestItemType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    QCTool = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CheckMethod = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StanderValue = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    ThresholdMax = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    ThresholdMin = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    CrQuantity = table.Column<int>(type: "int", nullable: true),
                    MajQuantity = table.Column<int>(type: "int", nullable: true),
                    MinQuantity = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality_InComingCheckTestItem", x => x.InComingCheckTestItemId);
                    table.ForeignKey(
                        name: "FK_Quality_InComingCheckTestItem_Quality_InComingCheck_InComing~",
                        column: x => x.InComingCheckId,
                        principalTable: "Quality_InComingCheck",
                        principalColumn: "InComingCheckId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quality_OutCheckTestItem",
                columns: table => new
                {
                    OutCheckTestItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OutCheckId = table.Column<int>(type: "int", nullable: false),
                    TemplateTestItemId = table.Column<int>(type: "int", nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    TestItemId = table.Column<int>(type: "int", nullable: false),
                    TestItemName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TestItemCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TestItemType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    QCTool = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CheckMethod = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StanderValue = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    ThresholdMax = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    ThresholdMin = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    CrQuantity = table.Column<int>(type: "int", nullable: true),
                    MajQuantity = table.Column<int>(type: "int", nullable: true),
                    MinQuantity = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality_OutCheckTestItem", x => x.OutCheckTestItemId);
                    table.ForeignKey(
                        name: "FK_Quality_OutCheckTestItem_Quality_OutCheck_OutCheckId",
                        column: x => x.OutCheckId,
                        principalTable: "Quality_OutCheck",
                        principalColumn: "OutCheckId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quality_ProcessCheckTestItem",
                columns: table => new
                {
                    ProcessCheckTestItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProcessCheckId = table.Column<int>(type: "int", nullable: false),
                    TemplateTestItemId = table.Column<int>(type: "int", nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    TestItemId = table.Column<int>(type: "int", nullable: false),
                    TestItemName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TestItemCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TestItemType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    QCTool = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CheckMethod = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StanderValue = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    ThresholdMax = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    ThresholdMin = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    CrQuantity = table.Column<int>(type: "int", nullable: true),
                    MajQuantity = table.Column<int>(type: "int", nullable: true),
                    MinQuantity = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality_ProcessCheckTestItem", x => x.ProcessCheckTestItemId);
                    table.ForeignKey(
                        name: "FK_Quality_ProcessCheckTestItem_Quality_ProcessCheck_ProcessChe~",
                        column: x => x.ProcessCheckId,
                        principalTable: "Quality_ProcessCheck",
                        principalColumn: "ProcessCheckId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_DictionaryList",
                columns: table => new
                {
                    DicListID = table.Column<int>(name: "DicList_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DicID = table.Column<int>(name: "Dic_ID", type: "int", nullable: true),
                    DicValue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DicName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Enable = table.Column<sbyte>(type: "tinyint", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_DictionaryList", x => x.DicListID);
                    table.ForeignKey(
                        name: "FK_Sys_DictionaryList_Sys_Dictionary_Dic_ID",
                        column: x => x.DicID,
                        principalTable: "Sys_Dictionary",
                        principalColumn: "Dic_ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_Actions",
                columns: table => new
                {
                    ActionId = table.Column<int>(name: "Action_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MenuId = table.Column<int>(name: "Menu_Id", type: "int", nullable: false),
                    Text = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SysMenuMenuId = table.Column<int>(name: "Sys_MenuMenu_Id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Actions", x => x.ActionId);
                    table.ForeignKey(
                        name: "FK_Sys_Actions_Sys_Menu_Sys_MenuMenu_Id",
                        column: x => x.SysMenuMenuId,
                        principalTable: "Sys_Menu",
                        principalColumn: "Menu_Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_RoleAuth",
                columns: table => new
                {
                    AuthId = table.Column<int>(name: "Auth_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(name: "Role_Id", type: "int", nullable: true),
                    UserId = table.Column<int>(name: "User_Id", type: "int", nullable: true),
                    MenuId = table.Column<int>(name: "Menu_Id", type: "int", nullable: false),
                    AuthValue = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Creator = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_RoleAuth", x => x.AuthId);
                    table.ForeignKey(
                        name: "FK_Sys_RoleAuth_Sys_Role_Role_Id",
                        column: x => x.RoleId,
                        principalTable: "Sys_Role",
                        principalColumn: "Role_Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_TableColumn",
                columns: table => new
                {
                    ColumnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TableId = table.Column<int>(name: "Table_Id", type: "int", nullable: false),
                    ColumnName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColumnCnName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColumnType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TableName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Maxlength = table.Column<int>(type: "int", nullable: true),
                    IsNull = table.Column<int>(type: "int", nullable: true),
                    IsDisplay = table.Column<int>(type: "int", nullable: true),
                    IsKey = table.Column<int>(type: "int", nullable: true),
                    Columnformat = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Script = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DropNo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsImage = table.Column<int>(type: "int", nullable: true),
                    Sortable = table.Column<int>(type: "int", nullable: true),
                    ColumnWidth = table.Column<int>(type: "int", nullable: true),
                    SearchRowNo = table.Column<int>(type: "int", nullable: true),
                    SearchColNo = table.Column<int>(type: "int", nullable: true),
                    SearchType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EditRowNo = table.Column<int>(type: "int", nullable: true),
                    EditColNo = table.Column<int>(type: "int", nullable: true),
                    EditType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColSize = table.Column<int>(type: "int", nullable: true),
                    IsReadDataset = table.Column<int>(type: "int", nullable: true),
                    Enable = table.Column<int>(type: "int", nullable: true),
                    ApiInPut = table.Column<int>(type: "int", nullable: true),
                    ApiIsNull = table.Column<int>(type: "int", nullable: true),
                    ApiOutPut = table.Column<int>(type: "int", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsColumnData = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_TableColumn", x => x.ColumnId);
                    table.ForeignKey(
                        name: "FK_Sys_TableColumn_Sys_TableInfo_Table_Id",
                        column: x => x.TableId,
                        principalTable: "Sys_TableInfo",
                        principalColumn: "Table_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_WorkFlowStep",
                columns: table => new
                {
                    WorkStepFlowId = table.Column<string>(name: "WorkStepFlow_Id", type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    WorkFlowId = table.Column<string>(name: "WorkFlow_Id", type: "varchar(36)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StepId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StepName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StepType = table.Column<int>(type: "int", nullable: true),
                    StepValue = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Enable = table.Column<sbyte>(type: "tinyint", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_WorkFlowStep", x => x.WorkStepFlowId);
                    table.ForeignKey(
                        name: "FK_Sys_WorkFlowStep_Sys_WorkFlow_WorkFlow_Id",
                        column: x => x.WorkFlowId,
                        principalTable: "Sys_WorkFlow",
                        principalColumn: "WorkFlow_Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sys_WorkFlowTableStep",
                columns: table => new
                {
                    SysWorkFlowTableStepId = table.Column<string>(name: "Sys_WorkFlowTableStep_Id", type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkFlowTableId = table.Column<string>(name: "WorkFlowTable_Id", type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    WorkFlowId = table.Column<string>(name: "WorkFlow_Id", type: "varchar(36)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StepId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StepName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StepType = table.Column<int>(type: "int", nullable: true),
                    StepValue = table.Column<int>(type: "int", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Enable = table.Column<sbyte>(type: "tinyint", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    AuditId = table.Column<int>(type: "int", nullable: true),
                    Auditor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AuditStatus = table.Column<int>(type: "int", nullable: true),
                    AuditDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_WorkFlowTableStep", x => x.SysWorkFlowTableStepId);
                    table.ForeignKey(
                        name: "FK_Sys_WorkFlowTableStep_Sys_WorkFlowTable_WorkFlowTable_Id",
                        column: x => x.WorkFlowTableId,
                        principalTable: "Sys_WorkFlowTable",
                        principalColumn: "WorkFlowTable_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tools_ToolsReceiveList",
                columns: table => new
                {
                    ToolsReceiveListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ToolsReceiveId = table.Column<int>(type: "int", nullable: false),
                    ToolId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ToolName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ToolCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Spec = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools_ToolsReceiveList", x => x.ToolsReceiveListId);
                    table.ForeignKey(
                        name: "FK_Tools_ToolsReceiveList_Tools_ToolsReceive_ToolsReceiveId",
                        column: x => x.ToolsReceiveId,
                        principalTable: "Tools_ToolsReceive",
                        principalColumn: "ToolsReceiveId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tools_ToolsReturnList",
                columns: table => new
                {
                    ToolsReturnListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ToolsReturnId = table.Column<int>(type: "int", nullable: false),
                    ToolId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ToolName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ToolCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Spec = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools_ToolsReturnList", x => x.ToolsReturnListId);
                    table.ForeignKey(
                        name: "FK_Tools_ToolsReturnList_Tools_ToolsReturn_ToolsReturnId",
                        column: x => x.ToolsReturnId,
                        principalTable: "Tools_ToolsReturn",
                        principalColumn: "ToolsReturnId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ware_OutWareHouseBillList",
                columns: table => new
                {
                    OutWareHouseBillListId = table.Column<int>(name: "OutWareHouseBillList_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OutWareHouseBillId = table.Column<int>(name: "OutWareHouseBill_Id", type: "int", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnitId = table.Column<int>(name: "Unit_Id", type: "int", nullable: false),
                    ProductStandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MaxInventory = table.Column<int>(type: "int", nullable: true),
                    MinInventory = table.Column<int>(type: "int", nullable: true),
                    SafeInventory = table.Column<int>(type: "int", nullable: true),
                    InventoryQty = table.Column<int>(type: "int", nullable: true),
                    OutStoreQty = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(name: "Product_Id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ware_OutWareHouseBillList", x => x.OutWareHouseBillListId);
                    table.ForeignKey(
                        name: "FK_Ware_OutWareHouseBillList_Ware_OutWareHouseBill_OutWareHouse~",
                        column: x => x.OutWareHouseBillId,
                        principalTable: "Ware_OutWareHouseBill",
                        principalColumn: "OutWareHouseBill_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ware_WareHouseBillList",
                columns: table => new
                {
                    WareHouseBillListId = table.Column<int>(name: "WareHouseBillList_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WareHouseBillId = table.Column<int>(name: "WareHouseBill_Id", type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnitId = table.Column<int>(name: "Unit_Id", type: "int", nullable: false),
                    ProductStandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MaxInventory = table.Column<int>(type: "int", nullable: true),
                    MinInventory = table.Column<int>(type: "int", nullable: true),
                    SafeInventory = table.Column<int>(type: "int", nullable: true),
                    InStoreQty = table.Column<int>(type: "int", nullable: false),
                    InventoryQty = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifyID = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProductId = table.Column<int>(name: "Product_Id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ware_WareHouseBillList", x => x.WareHouseBillListId);
                    table.ForeignKey(
                        name: "FK_Ware_WareHouseBillList_Ware_WareHouseBill_WareHouseBill_Id",
                        column: x => x.WareHouseBillId,
                        principalTable: "Ware_WareHouseBill",
                        principalColumn: "WareHouseBill_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Base_ProcessLineList_ProcessLine_Id",
                table: "Base_ProcessLineList",
                column: "ProcessLine_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Base_ProcessList_Process_Id",
                table: "Base_ProcessList",
                column: "Process_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cal_TeamMember_TeamId",
                table: "Cal_TeamMember",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Quality_InComingCheckTestItem_InComingCheckId",
                table: "Quality_InComingCheckTestItem",
                column: "InComingCheckId");

            migrationBuilder.CreateIndex(
                name: "IX_Quality_OutCheckTestItem_OutCheckId",
                table: "Quality_OutCheckTestItem",
                column: "OutCheckId");

            migrationBuilder.CreateIndex(
                name: "IX_Quality_ProcessCheckTestItem_ProcessCheckId",
                table: "Quality_ProcessCheckTestItem",
                column: "ProcessCheckId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Actions_Sys_MenuMenu_Id",
                table: "Sys_Actions",
                column: "Sys_MenuMenu_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_DictionaryList_Dic_ID",
                table: "Sys_DictionaryList",
                column: "Dic_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_RoleAuth_Role_Id",
                table: "Sys_RoleAuth",
                column: "Role_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_TableColumn_Table_Id",
                table: "Sys_TableColumn",
                column: "Table_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_WorkFlowStep_WorkFlow_Id",
                table: "Sys_WorkFlowStep",
                column: "WorkFlow_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_WorkFlowTableStep_WorkFlowTable_Id",
                table: "Sys_WorkFlowTableStep",
                column: "WorkFlowTable_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tools_ToolsReceiveList_ToolsReceiveId",
                table: "Tools_ToolsReceiveList",
                column: "ToolsReceiveId");

            migrationBuilder.CreateIndex(
                name: "IX_Tools_ToolsReturnList_ToolsReturnId",
                table: "Tools_ToolsReturnList",
                column: "ToolsReturnId");

            migrationBuilder.CreateIndex(
                name: "IX_Ware_OutWareHouseBillList_OutWareHouseBill_Id",
                table: "Ware_OutWareHouseBillList",
                column: "OutWareHouseBill_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ware_WareHouseBillList_WareHouseBill_Id",
                table: "Ware_WareHouseBillList",
                column: "WareHouseBill_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Base_DefectItem");

            migrationBuilder.DropTable(
                name: "Base_DesktopMenu");

            migrationBuilder.DropTable(
                name: "Base_MaterialDetail");

            migrationBuilder.DropTable(
                name: "Base_MeritPay");

            migrationBuilder.DropTable(
                name: "Base_Notice");

            migrationBuilder.DropTable(
                name: "Base_NumberRule");

            migrationBuilder.DropTable(
                name: "Base_ProcessLineList");

            migrationBuilder.DropTable(
                name: "Base_ProcessList");

            migrationBuilder.DropTable(
                name: "Base_Product");

            migrationBuilder.DropTable(
                name: "Base_WorkShop");

            migrationBuilder.DropTable(
                name: "Cal_Holiday");

            migrationBuilder.DropTable(
                name: "Cal_Plan");

            migrationBuilder.DropTable(
                name: "Cal_PlanShift");

            migrationBuilder.DropTable(
                name: "Cal_PlanTeam");

            migrationBuilder.DropTable(
                name: "Cal_TeamMember");

            migrationBuilder.DropTable(
                name: "Cal_TeamShift");

            migrationBuilder.DropTable(
                name: "Equip_DevCatalog");

            migrationBuilder.DropTable(
                name: "Equip_Device");

            migrationBuilder.DropTable(
                name: "Equip_MaintainPaper");

            migrationBuilder.DropTable(
                name: "Equip_SpotMaintenance");

            migrationBuilder.DropTable(
                name: "Equip_SpotMaintPlan");

            migrationBuilder.DropTable(
                name: "Equip_SpotMaintPlanDevice");

            migrationBuilder.DropTable(
                name: "Equip_SpotMaintPlanProject");

            migrationBuilder.DropTable(
                name: "Equip_SpotMaintWorkOrder");

            migrationBuilder.DropTable(
                name: "FormCollectionObject");

            migrationBuilder.DropTable(
                name: "FormDesignOptions");

            migrationBuilder.DropTable(
                name: "Quality_Defect");

            migrationBuilder.DropTable(
                name: "Quality_InComingCheckTestItem");

            migrationBuilder.DropTable(
                name: "Quality_OutCheckTestItem");

            migrationBuilder.DropTable(
                name: "Quality_ProcessCheckTestItem");

            migrationBuilder.DropTable(
                name: "Quality_Template");

            migrationBuilder.DropTable(
                name: "Quality_TemplateProduct");

            migrationBuilder.DropTable(
                name: "Quality_TemplateTestItem");

            migrationBuilder.DropTable(
                name: "Quality_TestItem");

            migrationBuilder.DropTable(
                name: "Sys_Actions");

            migrationBuilder.DropTable(
                name: "Sys_Dept");

            migrationBuilder.DropTable(
                name: "Sys_DictionaryList");

            migrationBuilder.DropTable(
                name: "Sys_Log");

            migrationBuilder.DropTable(
                name: "Sys_QuartzLog");

            migrationBuilder.DropTable(
                name: "Sys_QuartzOptions");

            migrationBuilder.DropTable(
                name: "Sys_RoleAuth");

            migrationBuilder.DropTable(
                name: "Sys_TableColumn");

            migrationBuilder.DropTable(
                name: "Sys_Unit");

            migrationBuilder.DropTable(
                name: "Sys_User");

            migrationBuilder.DropTable(
                name: "Sys_VersionInfo");

            migrationBuilder.DropTable(
                name: "Sys_WorkFlowStep");

            migrationBuilder.DropTable(
                name: "Sys_WorkFlowTableStep");

            migrationBuilder.DropTable(
                name: "Tools_Tool");

            migrationBuilder.DropTable(
                name: "Tools_ToolsReceiveList");

            migrationBuilder.DropTable(
                name: "Tools_ToolsReturnList");

            migrationBuilder.DropTable(
                name: "Tools_ToolType");

            migrationBuilder.DropTable(
                name: "View_Base_MaterialDetail");

            migrationBuilder.DropTable(
                name: "View_DefectItemDistribute");

            migrationBuilder.DropTable(
                name: "View_DefectItemSummary");

            migrationBuilder.DropTable(
                name: "View_EmployeePerformance");

            migrationBuilder.DropTable(
                name: "View_OutputStatistics");

            migrationBuilder.DropTable(
                name: "View_ProductionReport");

            migrationBuilder.DropTable(
                name: "View_SalaryReport");

            migrationBuilder.DropTable(
                name: "View_StockBalance");

            migrationBuilder.DropTable(
                name: "View_WareInOutDetail");

            migrationBuilder.DropTable(
                name: "vSys_Dictionary");

            migrationBuilder.DropTable(
                name: "Ware_OutWareHouseBillList");

            migrationBuilder.DropTable(
                name: "Ware_WareHouseBillList");

            migrationBuilder.DropTable(
                name: "Base_ProcessLine");

            migrationBuilder.DropTable(
                name: "Base_Process");

            migrationBuilder.DropTable(
                name: "Cal_Team");

            migrationBuilder.DropTable(
                name: "Quality_InComingCheck");

            migrationBuilder.DropTable(
                name: "Quality_OutCheck");

            migrationBuilder.DropTable(
                name: "Quality_ProcessCheck");

            migrationBuilder.DropTable(
                name: "Sys_Menu");

            migrationBuilder.DropTable(
                name: "Sys_Dictionary");

            migrationBuilder.DropTable(
                name: "Sys_Role");

            migrationBuilder.DropTable(
                name: "Sys_TableInfo");

            migrationBuilder.DropTable(
                name: "Sys_WorkFlow");

            migrationBuilder.DropTable(
                name: "Sys_WorkFlowTable");

            migrationBuilder.DropTable(
                name: "Tools_ToolsReceive");

            migrationBuilder.DropTable(
                name: "Tools_ToolsReturn");

            migrationBuilder.DropTable(
                name: "Ware_OutWareHouseBill");

            migrationBuilder.DropTable(
                name: "Ware_WareHouseBill");
        }
    }
}
