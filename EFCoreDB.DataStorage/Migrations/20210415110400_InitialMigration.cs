using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDB.DataStorage.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FDMProcessCC",
                columns: table => new
                {
                    FDMProcessCCPrimaryKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDMProcessCC", x => x.FDMProcessCCPrimaryKey);
                });

            migrationBuilder.CreateTable(
                name: "FDMTagCC",
                columns: table => new
                {
                    FDMTagCCPrimaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDMTagCC", x => x.FDMTagCCPrimaryId);
                });

            migrationBuilder.CreateTable(
                name: "FDMBlogCC",
                columns: table => new
                {
                    FDMBlogCCPrimaryKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FDMProcessCCForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDMBlogCC", x => x.FDMBlogCCPrimaryKey);
                    table.ForeignKey(
                        name: "FK_FDMBlogCC_FDMProcessCC_FDMProcessCCForeignKey",
                        column: x => x.FDMProcessCCForeignKey,
                        principalTable: "FDMProcessCC",
                        principalColumn: "FDMProcessCCPrimaryKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FDMGroupCC",
                columns: table => new
                {
                    FDMGroupCCPrimaryKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FDMProcessCCForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDMGroupCC", x => x.FDMGroupCCPrimaryKey);
                    table.ForeignKey(
                        name: "FK_FDMGroupCC_FDMProcessCC_FDMProcessCCForeignKey",
                        column: x => x.FDMProcessCCForeignKey,
                        principalTable: "FDMProcessCC",
                        principalColumn: "FDMProcessCCPrimaryKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FDMBloggerCC",
                columns: table => new
                {
                    FDMBloggerCCPrimaryKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FDMBlogCCForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDMBloggerCC", x => x.FDMBloggerCCPrimaryKey);
                    table.ForeignKey(
                        name: "FK_FDMBloggerCC_FDMBlogCC_FDMBlogCCForeignKey",
                        column: x => x.FDMBlogCCForeignKey,
                        principalTable: "FDMBlogCC",
                        principalColumn: "FDMBlogCCPrimaryKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FDMPostCC",
                columns: table => new
                {
                    FDMPostCCPrimaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FDMBlogCCForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDMPostCC", x => x.FDMPostCCPrimaryId);
                    table.ForeignKey(
                        name: "FK_FDMPostCC_FDMBlogCC_FDMBlogCCForeignKey",
                        column: x => x.FDMBlogCCForeignKey,
                        principalTable: "FDMBlogCC",
                        principalColumn: "FDMBlogCCPrimaryKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FDMPointCC",
                columns: table => new
                {
                    FDMPointCCPrimaryKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FDMGroupCCForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDMPointCC", x => x.FDMPointCCPrimaryKey);
                    table.ForeignKey(
                        name: "FK_FDMPointCC_FDMGroupCC_FDMGroupCCForeignKey",
                        column: x => x.FDMGroupCCForeignKey,
                        principalTable: "FDMGroupCC",
                        principalColumn: "FDMGroupCCPrimaryKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FDMAddressCC",
                columns: table => new
                {
                    FDMAddressCCPrimaryKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FDMBloggerCCForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDMAddressCC", x => x.FDMAddressCCPrimaryKey);
                    table.ForeignKey(
                        name: "FK_FDMAddressCC_FDMBloggerCC_FDMBloggerCCForeignKey",
                        column: x => x.FDMBloggerCCForeignKey,
                        principalTable: "FDMBloggerCC",
                        principalColumn: "FDMBloggerCCPrimaryKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    PostListFDMPostCCPrimaryId = table.Column<int>(type: "int", nullable: false),
                    TagListFDMTagCCPrimaryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => new { x.PostListFDMPostCCPrimaryId, x.TagListFDMTagCCPrimaryId });
                    table.ForeignKey(
                        name: "FK_PostTags_FDMPostCC_PostListFDMPostCCPrimaryId",
                        column: x => x.PostListFDMPostCCPrimaryId,
                        principalTable: "FDMPostCC",
                        principalColumn: "FDMPostCCPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_FDMTagCC_TagListFDMTagCCPrimaryId",
                        column: x => x.TagListFDMTagCCPrimaryId,
                        principalTable: "FDMTagCC",
                        principalColumn: "FDMTagCCPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FDMAddressCC_FDMBloggerCCForeignKey",
                table: "FDMAddressCC",
                column: "FDMBloggerCCForeignKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FDMBlogCC_FDMProcessCCForeignKey",
                table: "FDMBlogCC",
                column: "FDMProcessCCForeignKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FDMBloggerCC_FDMBlogCCForeignKey",
                table: "FDMBloggerCC",
                column: "FDMBlogCCForeignKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FDMGroupCC_FDMProcessCCForeignKey",
                table: "FDMGroupCC",
                column: "FDMProcessCCForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_FDMPointCC_FDMGroupCCForeignKey",
                table: "FDMPointCC",
                column: "FDMGroupCCForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_FDMPostCC_FDMBlogCCForeignKey",
                table: "FDMPostCC",
                column: "FDMBlogCCForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagListFDMTagCCPrimaryId",
                table: "PostTags",
                column: "TagListFDMTagCCPrimaryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FDMAddressCC");

            migrationBuilder.DropTable(
                name: "FDMPointCC");

            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "FDMBloggerCC");

            migrationBuilder.DropTable(
                name: "FDMGroupCC");

            migrationBuilder.DropTable(
                name: "FDMPostCC");

            migrationBuilder.DropTable(
                name: "FDMTagCC");

            migrationBuilder.DropTable(
                name: "FDMBlogCC");

            migrationBuilder.DropTable(
                name: "FDMProcessCC");
        }
    }
}
