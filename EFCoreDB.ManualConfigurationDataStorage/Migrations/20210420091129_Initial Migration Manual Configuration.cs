using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDB.ManualConfigurationDataStorage.Migrations
{
    public partial class InitialMigrationManualConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProcessFA",
                columns: table => new
                {
                    ProcessFAPrimaryKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessFA", x => x.ProcessFAPrimaryKey);
                });

            migrationBuilder.CreateTable(
                name: "TagFA",
                columns: table => new
                {
                    TagFAPrimaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagFA", x => x.TagFAPrimaryId);
                });

            migrationBuilder.CreateTable(
                name: "BlogFA",
                columns: table => new
                {
                    BlogFAPrimaryKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessFAForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogFA", x => x.BlogFAPrimaryKey);
                    table.ForeignKey(
                        name: "ForeignKey_BlogFA_ProcessFA",
                        column: x => x.ProcessFAForeignKey,
                        principalTable: "ProcessFA",
                        principalColumn: "ProcessFAPrimaryKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupFA",
                columns: table => new
                {
                    GroupFAPrimaryKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessFAForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupFA", x => x.GroupFAPrimaryKey);
                    table.ForeignKey(
                        name: "ForeignKey_GroupFA_ProcessFA",
                        column: x => x.ProcessFAForeignKey,
                        principalTable: "ProcessFA",
                        principalColumn: "ProcessFAPrimaryKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BloggerFA",
                columns: table => new
                {
                    BloggerFAPrimaryKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogFAForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloggerFA", x => x.BloggerFAPrimaryKey);
                    table.ForeignKey(
                        name: "ForeignKey_BloggerFA_BlogFA",
                        column: x => x.BlogFAForeignKey,
                        principalTable: "BlogFA",
                        principalColumn: "BlogFAPrimaryKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostFA",
                columns: table => new
                {
                    PostFAPrimaryKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogFAForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostFA", x => x.PostFAPrimaryKey);
                    table.ForeignKey(
                        name: "ForeignKey_PostFA_BlogFA",
                        column: x => x.BlogFAForeignKey,
                        principalTable: "BlogFA",
                        principalColumn: "BlogFAPrimaryKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PointFA",
                columns: table => new
                {
                    PointFAPrimaryKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupFAForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointFA", x => x.PointFAPrimaryKey);
                    table.ForeignKey(
                        name: "ForeignKey_PointFA_GroupFA",
                        column: x => x.GroupFAForeignKey,
                        principalTable: "GroupFA",
                        principalColumn: "GroupFAPrimaryKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressFA",
                columns: table => new
                {
                    AddressFAPrimaryKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloggerFAForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressFA", x => x.AddressFAPrimaryKey);
                    table.ForeignKey(
                        name: "ForeignKey_AddressFA_BloggerFA",
                        column: x => x.BloggerFAForeignKey,
                        principalTable: "BloggerFA",
                        principalColumn: "BloggerFAPrimaryKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    PostListPostFAPrimaryKey = table.Column<int>(type: "int", nullable: false),
                    TagListTagFAPrimaryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => new { x.PostListPostFAPrimaryKey, x.TagListTagFAPrimaryId });
                    table.ForeignKey(
                        name: "FK_PostTags_PostFA_PostListPostFAPrimaryKey",
                        column: x => x.PostListPostFAPrimaryKey,
                        principalTable: "PostFA",
                        principalColumn: "PostFAPrimaryKey",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_TagFA_TagListTagFAPrimaryId",
                        column: x => x.TagListTagFAPrimaryId,
                        principalTable: "TagFA",
                        principalColumn: "TagFAPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressFA_BloggerFAForeignKey",
                table: "AddressFA",
                column: "BloggerFAForeignKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogFA_ProcessFAForeignKey",
                table: "BlogFA",
                column: "ProcessFAForeignKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BloggerFA_BlogFAForeignKey",
                table: "BloggerFA",
                column: "BlogFAForeignKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GroupFA_ProcessFAForeignKey",
                table: "GroupFA",
                column: "ProcessFAForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_PointFA_GroupFAForeignKey",
                table: "PointFA",
                column: "GroupFAForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_PostFA_BlogFAForeignKey",
                table: "PostFA",
                column: "BlogFAForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagListTagFAPrimaryId",
                table: "PostTags",
                column: "TagListTagFAPrimaryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressFA");

            migrationBuilder.DropTable(
                name: "PointFA");

            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "BloggerFA");

            migrationBuilder.DropTable(
                name: "GroupFA");

            migrationBuilder.DropTable(
                name: "PostFA");

            migrationBuilder.DropTable(
                name: "TagFA");

            migrationBuilder.DropTable(
                name: "BlogFA");

            migrationBuilder.DropTable(
                name: "ProcessFA");
        }
    }
}
