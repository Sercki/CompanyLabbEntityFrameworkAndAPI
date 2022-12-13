using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "CompanyName", "OrganisationsNumber" },
                values: new object[] { 1, "Min första Sverige AB", "1-234567890" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "PositionName" },
                values: new object[,]
                {
                    { 1, "Manager" },
                    { 2, "Junior Kvalitetsansvarig" },
                    { 3, "Master Kock" },
                    { 4, "Kock" },
                    { 5, "Praktikant" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "CompanyId", "SectionName" },
                values: new object[] { 1, 1, "HR Sverige" });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "CompanyId", "SectionName" },
                values: new object[] { 2, 1, "Kvalitetskontroll Sverige" });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "CompanyId", "SectionName" },
                values: new object[] { 3, 1, "Kök Sverige" });

            migrationBuilder.InsertData(
                table: "Personnel",
                columns: new[] { "Id", "Name", "Salary", "SectionId", "Surname", "UnionMember" },
                values: new object[,]
                {
                    { 1, "Anders", 20000.0, 1, "Svensson", true },
                    { 2, "Anna", 25000.0, 2, "Svensdotter", true },
                    { 3, "Lars", 25000.0, 2, "Lindkvist", false },
                    { 4, "Erik", 23000.0, 3, "Nilsson", false },
                    { 5, "Karin", 25000.0, 3, "Berglund", true },
                    { 6, "Peter", 24000.0, 3, "Jonsson", true }
                });

            migrationBuilder.InsertData(
                table: "PersonnelPosition",
                columns: new[] { "PersonnelId", "PositionsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 4 },
                    { 5, 3 },
                    { 6, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonnelPosition",
                keyColumns: new[] { "PersonnelId", "PositionsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PersonnelPosition",
                keyColumns: new[] { "PersonnelId", "PositionsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PersonnelPosition",
                keyColumns: new[] { "PersonnelId", "PositionsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "PersonnelPosition",
                keyColumns: new[] { "PersonnelId", "PositionsId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "PersonnelPosition",
                keyColumns: new[] { "PersonnelId", "PositionsId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "PersonnelPosition",
                keyColumns: new[] { "PersonnelId", "PositionsId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
