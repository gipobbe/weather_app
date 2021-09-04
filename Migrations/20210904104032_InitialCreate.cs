using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace weather_app.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CurrentForecast",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Dt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Sunrise = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Sunset = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Temperature = table.Column<double>(type: "double precision", nullable: false),
                    FeelsLike = table.Column<double>(type: "double precision", nullable: false),
                    Pressure = table.Column<double>(type: "double precision", nullable: false),
                    Umidity = table.Column<int>(type: "integer", nullable: false),
                    DewPoint = table.Column<double>(type: "double precision", nullable: false),
                    Uvi = table.Column<double>(type: "double precision", nullable: false),
                    Clouds = table.Column<int>(type: "integer", nullable: false),
                    Visibility = table.Column<int>(type: "integer", nullable: false),
                    WindSpeed = table.Column<double>(type: "double precision", nullable: false),
                    WindDeg = table.Column<int>(type: "integer", nullable: false),
                    WindGust = table.Column<double>(type: "double precision", nullable: true),
                    Rain = table.Column<double>(type: "double precision", nullable: true),
                    Snow = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentForecast", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeelsLikes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Day = table.Column<double>(type: "double precision", nullable: false),
                    Night = table.Column<double>(type: "double precision", nullable: false),
                    Eve = table.Column<double>(type: "double precision", nullable: false),
                    Morn = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeelsLikes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Temperatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Day = table.Column<double>(type: "double precision", nullable: false),
                    Min = table.Column<double>(type: "double precision", nullable: false),
                    Max = table.Column<double>(type: "double precision", nullable: false),
                    Nigh = table.Column<double>(type: "double precision", nullable: false),
                    Eve = table.Column<double>(type: "double precision", nullable: false),
                    Morn = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temperatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OneCallForecasts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    Timezone = table.Column<string>(type: "text", nullable: true),
                    TimezoneOffset = table.Column<double>(type: "double precision", nullable: false),
                    CurrentForecastId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneCallForecasts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OneCallForecasts_CurrentForecast_CurrentForecastId",
                        column: x => x.CurrentForecastId,
                        principalTable: "CurrentForecast",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DailyForecasts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Dt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Sunrise = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Sunset = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Moonrise = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Moonset = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    MoonPhase = table.Column<double>(type: "double precision", nullable: false),
                    TemperatureId = table.Column<Guid>(type: "uuid", nullable: true),
                    FeelsLikeId = table.Column<Guid>(type: "uuid", nullable: true),
                    Pressure = table.Column<double>(type: "double precision", nullable: false),
                    Humidity = table.Column<double>(type: "double precision", nullable: false),
                    DewPoint = table.Column<double>(type: "double precision", nullable: false),
                    WindSpeed = table.Column<double>(type: "double precision", nullable: false),
                    WindDeg = table.Column<double>(type: "double precision", nullable: false),
                    WindGust = table.Column<double>(type: "double precision", nullable: false),
                    Clouds = table.Column<double>(type: "double precision", nullable: false),
                    Pop = table.Column<double>(type: "double precision", nullable: false),
                    Rain = table.Column<double>(type: "double precision", nullable: true),
                    Uvi = table.Column<double>(type: "double precision", nullable: false),
                    OneCallForecastId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyForecasts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyForecasts_FeelsLikes_FeelsLikeId",
                        column: x => x.FeelsLikeId,
                        principalTable: "FeelsLikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyForecasts_OneCallForecasts_OneCallForecastId",
                        column: x => x.OneCallForecastId,
                        principalTable: "OneCallForecasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyForecasts_Temperatures_TemperatureId",
                        column: x => x.TemperatureId,
                        principalTable: "Temperatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HourlyForecasts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Dt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Temperature = table.Column<double>(type: "double precision", nullable: false),
                    FeelsLike = table.Column<double>(type: "double precision", nullable: false),
                    Pressure = table.Column<double>(type: "double precision", nullable: false),
                    Humidity = table.Column<double>(type: "double precision", nullable: false),
                    DewPoint = table.Column<double>(type: "double precision", nullable: false),
                    Uvi = table.Column<double>(type: "double precision", nullable: false),
                    Clouds = table.Column<double>(type: "double precision", nullable: false),
                    Visibility = table.Column<double>(type: "double precision", nullable: false),
                    WindSpeed = table.Column<double>(type: "double precision", nullable: false),
                    WindDeg = table.Column<double>(type: "double precision", nullable: false),
                    WindGust = table.Column<double>(type: "double precision", nullable: false),
                    Pop = table.Column<double>(type: "double precision", nullable: false),
                    OneCallForecastId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourlyForecasts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HourlyForecasts_OneCallForecasts_OneCallForecastId",
                        column: x => x.OneCallForecastId,
                        principalTable: "OneCallForecasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeteoAlerts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SenderName = table.Column<string>(type: "text", nullable: true),
                    Event = table.Column<string>(type: "text", nullable: true),
                    StartAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Tags = table.Column<string>(type: "text", nullable: true),
                    OneCallForecastId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeteoAlerts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeteoAlerts_OneCallForecasts_OneCallForecastId",
                        column: x => x.OneCallForecastId,
                        principalTable: "OneCallForecasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MinutelyForecasts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Dt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Precipitation = table.Column<double>(type: "double precision", nullable: false),
                    OneCallForecastId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinutelyForecasts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MinutelyForecasts_OneCallForecasts_OneCallForecastId",
                        column: x => x.OneCallForecastId,
                        principalTable: "OneCallForecasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Main = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    CurrentForecastId = table.Column<Guid>(type: "uuid", nullable: true),
                    DailyForecastId = table.Column<Guid>(type: "uuid", nullable: true),
                    HourlyForecastId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weather_CurrentForecast_CurrentForecastId",
                        column: x => x.CurrentForecastId,
                        principalTable: "CurrentForecast",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weather_DailyForecasts_DailyForecastId",
                        column: x => x.DailyForecastId,
                        principalTable: "DailyForecasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weather_HourlyForecasts_HourlyForecastId",
                        column: x => x.HourlyForecastId,
                        principalTable: "HourlyForecasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DailyForecasts_FeelsLikeId",
                table: "DailyForecasts",
                column: "FeelsLikeId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyForecasts_OneCallForecastId",
                table: "DailyForecasts",
                column: "OneCallForecastId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyForecasts_TemperatureId",
                table: "DailyForecasts",
                column: "TemperatureId");

            migrationBuilder.CreateIndex(
                name: "IX_HourlyForecasts_OneCallForecastId",
                table: "HourlyForecasts",
                column: "OneCallForecastId");

            migrationBuilder.CreateIndex(
                name: "IX_MeteoAlerts_OneCallForecastId",
                table: "MeteoAlerts",
                column: "OneCallForecastId");

            migrationBuilder.CreateIndex(
                name: "IX_MinutelyForecasts_OneCallForecastId",
                table: "MinutelyForecasts",
                column: "OneCallForecastId");

            migrationBuilder.CreateIndex(
                name: "IX_OneCallForecasts_CurrentForecastId",
                table: "OneCallForecasts",
                column: "CurrentForecastId");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_CurrentForecastId",
                table: "Weather",
                column: "CurrentForecastId");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_DailyForecastId",
                table: "Weather",
                column: "DailyForecastId");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_HourlyForecastId",
                table: "Weather",
                column: "HourlyForecastId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeteoAlerts");

            migrationBuilder.DropTable(
                name: "MinutelyForecasts");

            migrationBuilder.DropTable(
                name: "Weather");

            migrationBuilder.DropTable(
                name: "DailyForecasts");

            migrationBuilder.DropTable(
                name: "HourlyForecasts");

            migrationBuilder.DropTable(
                name: "FeelsLikes");

            migrationBuilder.DropTable(
                name: "Temperatures");

            migrationBuilder.DropTable(
                name: "OneCallForecasts");

            migrationBuilder.DropTable(
                name: "CurrentForecast");
        }
    }
}
