using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddFuel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8863ffe6-2d9d-42d4-baec-be0f9634bb4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45a30aca-374b-49e5-be56-def84f45ce46"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("4c1bb7b7-5f44-4e9c-a4a8-0a0de83a155c"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 115, 52, 184, 104, 104, 255, 114, 175, 242, 101, 151, 134, 231, 88, 40, 221, 164, 113, 106, 19, 129, 139, 93, 44, 42, 129, 149, 143, 163, 4, 39, 241, 186, 92, 92, 31, 60, 82, 35, 159, 173, 160, 37, 17, 139, 224, 134, 92, 67, 240, 249, 149, 226, 123, 37, 70, 77, 23, 66, 5, 107, 216, 114, 109 }, new byte[] { 53, 99, 178, 37, 77, 199, 178, 33, 219, 77, 119, 168, 249, 39, 54, 194, 57, 173, 53, 18, 195, 237, 251, 150, 233, 49, 201, 20, 228, 133, 1, 72, 147, 250, 189, 96, 239, 157, 40, 235, 109, 25, 22, 204, 107, 110, 234, 226, 102, 192, 252, 90, 210, 102, 234, 172, 14, 241, 248, 193, 203, 186, 128, 195, 129, 2, 201, 30, 219, 140, 140, 134, 250, 97, 50, 72, 135, 41, 142, 205, 70, 222, 140, 254, 189, 176, 193, 19, 57, 38, 99, 57, 162, 137, 67, 138, 221, 25, 109, 142, 87, 48, 217, 8, 73, 150, 239, 75, 64, 127, 187, 120, 107, 197, 218, 124, 36, 130, 148, 201, 80, 82, 54, 110, 197, 76, 153, 110 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("7cd27c10-54cb-4e30-ac7a-1c0b876254a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("4c1bb7b7-5f44-4e9c-a4a8-0a0de83a155c") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7cd27c10-54cb-4e30-ac7a-1c0b876254a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c1bb7b7-5f44-4e9c-a4a8-0a0de83a155c"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("45a30aca-374b-49e5-be56-def84f45ce46"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 142, 118, 111, 249, 99, 236, 79, 216, 254, 72, 158, 37, 71, 16, 93, 9, 9, 198, 157, 97, 252, 48, 9, 244, 44, 75, 210, 183, 130, 3, 11, 206, 216, 231, 238, 90, 187, 69, 54, 37, 117, 174, 130, 158, 191, 185, 199, 162, 229, 14, 213, 227, 21, 207, 117, 255, 114, 4, 171, 172, 19, 44, 136, 105 }, new byte[] { 0, 95, 16, 45, 254, 219, 189, 205, 8, 133, 195, 69, 217, 246, 100, 115, 148, 250, 134, 149, 64, 235, 185, 211, 87, 30, 70, 143, 13, 240, 141, 234, 45, 232, 9, 136, 41, 27, 163, 142, 67, 7, 42, 152, 108, 157, 188, 21, 152, 26, 118, 111, 138, 253, 4, 127, 124, 59, 48, 110, 204, 92, 163, 90, 202, 29, 168, 159, 87, 64, 238, 244, 76, 238, 69, 209, 233, 78, 123, 41, 223, 139, 121, 229, 169, 40, 110, 174, 153, 212, 83, 13, 196, 105, 68, 160, 24, 110, 75, 170, 227, 206, 253, 194, 171, 8, 48, 112, 138, 87, 203, 55, 101, 22, 88, 212, 79, 30, 224, 69, 6, 3, 241, 218, 22, 78, 48, 52 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("8863ffe6-2d9d-42d4-baec-be0f9634bb4f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("45a30aca-374b-49e5-be56-def84f45ce46") });
        }
    }
}
