using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopEase.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a7cbf8d-fe7e-44d2-b692-1ef3790eb117", "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "67f1383a-ef63-4e6d-9429-f6da8582e5b3", "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cdc2b542-0081-4945-a307-7d6b312fa36f", "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "244a5166-1ec8-4609-8353-9f7239f01e1a", "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6dae4b32-ee04-4ff6-8dcb-27e72842eecd", "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "127c63e7-ef33-496d-adef-8cf25e092520", "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "524200bc-dbef-4e52-b563-0c010024219e", "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "886daeed-3d50-4227-b1f7-1da89f278b2d", "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be433660-e2c4-4939-879c-473bc2c3f10e", "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3254871f-52a7-4c4e-9e09-8b441538e5ee", "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de36d7f7-38dd-4af1-8d88-5ec795678a8a", "AQAAAAIAAYagAAAAEN3xWzF/C9QdU6dGr//ZlT++albdGLEDm3D7Yr07o6JzlYM+8Xq0t7Mn2nXJupWcyQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "db40d7f5-f256-4697-bf27-449c7afe5f34", "AQAAAAIAAYagAAAAEAuXRFkWPK+S8Qf6x7UHwQ87dfb9002aG0B18NUv7ZuYQEWwZCmMor/UHcUZzqx5Cw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "025e27b5-ba92-48d6-a192-5b9d8291754b", "AQAAAAIAAYagAAAAEMEZFflA7pFOywVs/6gXMDt8uZh4CZtn0Mpf5cr6iu/KbyVwUyfQ6JUl2InLY0mqkg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "472842cc-b3da-47fa-8b79-c09903aa087b", "AQAAAAIAAYagAAAAEKX7Tjc3zWxQ9n9ZhpJ0kp+DMoVOeJcXMPksxF3eEEiZtLQdFgfpOwg9ppzOMUhy9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74a044ae-231b-4469-ad15-6c34034aef66", "AQAAAAIAAYagAAAAEBmCSbQpFByYoARwIRr8Up69XMe3XVi6Qeqg9S6b3vakVmAAOTVynrVa5dWXb2P7vg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8e3360c-ee8f-4703-a884-4c47bdf95637", "AQAAAAIAAYagAAAAENANqDa0w9BkqbPRbEGGcs+E/t8lzyNbze7wN696FjNsWaBteyJdWauIqIkcf4+R1w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3edb4466-b67d-46c2-8ced-479d75072c94", "AQAAAAIAAYagAAAAEEPqNJNHF5LCbQk//2+RnbPOCZIXjr6LCnBbtOtha3SL9O3dxYSXwmtree8pmhhVZg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40aac5bc-7dbb-4178-9aa3-c1253092f58c", "AQAAAAIAAYagAAAAEF77Ndij29N+BzEczSn25G5mK87odJw5JsSXRHcDwnIlYjq913xw1+A96wm45chzjw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f6a53d9-45ef-4437-b080-fd9d568f1d6f", "AQAAAAIAAYagAAAAEAB7amPMsjmkyRQULjlkQbIy5lXTk1/3DQB/yNqHWC/D4YNWxBUZ+nAl2suNsfBVgQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9924bee6-6f9a-4c35-a61b-d2d1b1c11eab", "AQAAAAIAAYagAAAAEB5ICy+RLcVvx2OhggQ16mqmKyNW7DqIY99HI5P21uEJfzoxQKUO+/cAKXLbbgDmiw==" });
        }
    }
}
