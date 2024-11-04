using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CustomerCRUD.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    Budget = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Adress", "Budget", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Zwyciestwa 13/5", 60000, "AleksanderJaruga@gmail.com", "Aleksander Jaruga", 638456736L },
                    { 2, "Al.Piastow 12/7", 5000, "MichałZielony@gmail.com", "Michał Zielony", 823462374L },
                    { 3, "Michałów 98/8", 25000, "BartekLubelski@gmail.com", "Bartek Lubelski", 837282737L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
