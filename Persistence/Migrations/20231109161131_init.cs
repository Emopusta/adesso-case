using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Draws",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Picker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Draws", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MatchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("2fafbee5-f65d-48a5-8637-270a9ae5cd4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fransa", null },
                    { new Guid("34a9d6f9-26aa-4cc6-96fc-7cf6f46e13eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hollanda", null },
                    { new Guid("35cd46ac-8347-48c1-8e5b-c631eb655d79"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Italya", null },
                    { new Guid("4067b3e2-d378-46a4-a25b-cc5be4c24472"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Belcika", null },
                    { new Guid("a7170631-6b14-4e7e-b2a9-22bb1403ab8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ispanya", null },
                    { new Guid("d2bc1850-e738-49a2-b262-08dbe128c8cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Turkiye", null },
                    { new Guid("d3749aac-ed3e-442e-8206-d508b1b94dcc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Almanya", null },
                    { new Guid("f5f76ad1-25ba-452c-90c0-2c1f33df58db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Portekiz", null }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CountryId", "CreatedDate", "DeletedDate", "GroupId", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("022ab864-3586-4165-8676-591ab1f53bda"), new Guid("35cd46ac-8347-48c1-8e5b-c631eb655d79"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Venedik", null },
                    { new Guid("0477a0ac-53ef-466b-a81c-63025c44c5fe"), new Guid("34a9d6f9-26aa-4cc6-96fc-7cf6f46e13eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Lahey", null },
                    { new Guid("07a1b3ec-962b-467d-9c24-4bb7ba36685e"), new Guid("a7170631-6b14-4e7e-b2a9-22bb1403ab8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Sevilla", null },
                    { new Guid("07f9f324-b19b-4c0d-acd0-47876161f808"), new Guid("f5f76ad1-25ba-452c-90c0-2c1f33df58db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Coimbra", null },
                    { new Guid("14b32de5-ad3e-4450-af32-238206e2a8b8"), new Guid("34a9d6f9-26aa-4cc6-96fc-7cf6f46e13eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Eindhoven", null },
                    { new Guid("211efb8d-ee8d-44a2-8fdc-f00261261b57"), new Guid("35cd46ac-8347-48c1-8e5b-c631eb655d79"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Roma", null },
                    { new Guid("284c4838-228d-4dd6-8331-d8c809c22829"), new Guid("d3749aac-ed3e-442e-8206-d508b1b94dcc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Munih", null },
                    { new Guid("3353bfc0-53de-4401-be0d-1b32fa25af4e"), new Guid("2fafbee5-f65d-48a5-8637-270a9ae5cd4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Nice", null },
                    { new Guid("36c3648d-82b2-4174-a745-8011639ba1d9"), new Guid("a7170631-6b14-4e7e-b2a9-22bb1403ab8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Granada", null },
                    { new Guid("4045aa7a-1cd8-495e-9390-5ec188a44a73"), new Guid("d3749aac-ed3e-442e-8206-d508b1b94dcc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Dortmund", null },
                    { new Guid("434be56e-579e-4f7c-aa1d-fe91cc841ef9"), new Guid("2fafbee5-f65d-48a5-8637-270a9ae5cd4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Lyon", null },
                    { new Guid("53266fea-1146-47d8-b961-058706404230"), new Guid("f5f76ad1-25ba-452c-90c0-2c1f33df58db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Porto", null },
                    { new Guid("537fef6d-e3ae-4f85-8119-75a465400800"), new Guid("4067b3e2-d378-46a4-a25b-cc5be4c24472"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Bruksel", null },
                    { new Guid("5cc166dd-d502-4afd-807b-8e2fbf4b84c2"), new Guid("a7170631-6b14-4e7e-b2a9-22bb1403ab8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Madrid", null },
                    { new Guid("678e6608-cf1a-44fd-9150-42812cb14746"), new Guid("34a9d6f9-26aa-4cc6-96fc-7cf6f46e13eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Rotterdam", null },
                    { new Guid("6f0cf9ff-aca1-4cc1-8829-05eb66c2bf2e"), new Guid("35cd46ac-8347-48c1-8e5b-c631eb655d79"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Napoli", null },
                    { new Guid("74b7c9f5-0b42-47e1-9d6f-f4759b7cc242"), new Guid("2fafbee5-f65d-48a5-8637-270a9ae5cd4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Paris", null },
                    { new Guid("841911c9-272d-493f-8360-5d2f417909e9"), new Guid("34a9d6f9-26aa-4cc6-96fc-7cf6f46e13eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Amsterdam", null },
                    { new Guid("8bc137f5-5be4-401c-a983-e3e4ee3d4603"), new Guid("d3749aac-ed3e-442e-8206-d508b1b94dcc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Berlin", null },
                    { new Guid("9964bc4a-4f4b-4210-84a0-13c4e1f7857a"), new Guid("4067b3e2-d378-46a4-a25b-cc5be4c24472"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Brugge", null },
                    { new Guid("a36170b9-9840-4dca-9988-b21d8c70b5ad"), new Guid("d2bc1850-e738-49a2-b262-08dbe128c8cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Izmir", null },
                    { new Guid("a6cdf9b2-f271-4223-af38-2cb160361acb"), new Guid("f5f76ad1-25ba-452c-90c0-2c1f33df58db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Braga", null },
                    { new Guid("a89468b5-c7ed-4239-b34f-2e0ad1d3cbf3"), new Guid("d3749aac-ed3e-442e-8206-d508b1b94dcc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Frankfurt", null },
                    { new Guid("c3bd1bf9-43d4-473a-a22e-c1bd02ae4eed"), new Guid("a7170631-6b14-4e7e-b2a9-22bb1403ab8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Barselona", null },
                    { new Guid("c81b3b57-ba3d-4e49-8798-ed9ac7bece4b"), new Guid("4067b3e2-d378-46a4-a25b-cc5be4c24472"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Anvers", null },
                    { new Guid("cfa7c2f1-39b3-459a-b73f-5feb5a026b02"), new Guid("d2bc1850-e738-49a2-b262-08dbe128c8cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Ankara", null },
                    { new Guid("d2980c99-b4ca-4098-8bc5-31af7007510b"), new Guid("35cd46ac-8347-48c1-8e5b-c631eb655d79"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Milano", null },
                    { new Guid("d98b22de-7d55-4086-b9a3-bc0cd5da75ca"), new Guid("f5f76ad1-25ba-452c-90c0-2c1f33df58db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Lisbon", null },
                    { new Guid("dae0a81b-1005-4556-9a79-bbc2d87d9025"), new Guid("d2bc1850-e738-49a2-b262-08dbe128c8cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Antalya", null },
                    { new Guid("e13736f1-238a-4c89-85ce-e99e832b445d"), new Guid("2fafbee5-f65d-48a5-8637-270a9ae5cd4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Marsilya", null },
                    { new Guid("ed3e891b-9446-4103-a523-6df0aa36f1b7"), new Guid("4067b3e2-d378-46a4-a25b-cc5be4c24472"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Gent", null },
                    { new Guid("fca106a6-a9ad-46eb-9db9-40f13ce9e0fc"), new Guid("d2bc1850-e738-49a2-b262-08dbe128c8cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adesso Istanbul", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_GroupId",
                table: "Teams",
                column: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Draws");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
