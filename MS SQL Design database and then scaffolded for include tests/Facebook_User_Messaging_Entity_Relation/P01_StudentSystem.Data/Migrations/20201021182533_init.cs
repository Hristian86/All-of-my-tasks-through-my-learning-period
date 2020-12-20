using Microsoft.EntityFrameworkCore.Migrations;

namespace P01_StudentSystem.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    user_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(fixedLength: true, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "Conversations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_one = table.Column<int>(nullable: false),
                    user_two = table.Column<int>(nullable: false),
                    ip = table.Column<string>(fixedLength: true, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversations", x => x.id);
                    table.ForeignKey(
                        name: "FK_Conversation_User1",
                        column: x => x.user_one,
                        principalTable: "User",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conversation_User",
                        column: x => x.user_two,
                        principalTable: "User",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "conversation_reply",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reply = table.Column<string>(fixedLength: true, maxLength: 100, nullable: true),
                    user_id = table.Column<int>(nullable: false),
                    conversationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conversation_reply", x => x.id);
                    table.ForeignKey(
                        name: "FK_conversation_reply_conversation_reply",
                        column: x => x.conversationId,
                        principalTable: "Conversations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_conversation_reply_User",
                        column: x => x.user_id,
                        principalTable: "User",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_conversation_reply_conversationId",
                table: "conversation_reply",
                column: "conversationId");

            migrationBuilder.CreateIndex(
                name: "IX_conversation_reply_user_id",
                table: "conversation_reply",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_user_one",
                table: "Conversations",
                column: "user_one");

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_user_two",
                table: "Conversations",
                column: "user_two");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "conversation_reply");

            migrationBuilder.DropTable(
                name: "Conversations");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
