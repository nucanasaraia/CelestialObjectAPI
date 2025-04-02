using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CelestialObject.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CelestialObjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlternateDesignation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Constellation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistanceFromEarth = table.Column<double>(type: "float", nullable: false),
                    Magnitude = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mass = table.Column<double>(type: "float", nullable: false),
                    Radius = table.Column<double>(type: "float", nullable: false),
                    Temperature = table.Column<double>(type: "float", nullable: true),
                    Age = table.Column<double>(type: "float", nullable: false),
                    Composition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpectralType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RightAscension = table.Column<double>(type: "float", nullable: false),
                    Declination = table.Column<double>(type: "float", nullable: false),
                    DiscoveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscoveredBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscoveryMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResearchHistory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Characteristics = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrbitingBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrbitalPeriod = table.Column<double>(type: "float", nullable: true),
                    OrbitalEccentricity = table.Column<double>(type: "float", nullable: true),
                    RotationPeriod = table.Column<double>(type: "float", nullable: true),
                    HasExoplanets = table.Column<bool>(type: "bit", nullable: false),
                    ExoplanetCount = table.Column<int>(type: "int", nullable: true),
                    IsInteresting = table.Column<bool>(type: "bit", nullable: false),
                    InterestingFacts = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CelestialObjects", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CelestialObjects");
        }
    }
}
