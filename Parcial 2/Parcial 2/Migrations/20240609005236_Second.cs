using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Parcial_2.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Canciones",
                columns: new[] { "Id", "DiscoId", "TiempoDuracion", "TituloCancion" },
                values: new object[,]
                {
                    { 3, 1, 180, "Rockin' Revolution" },
                    { 4, 1, 240, "Midnight Rider" },
                    { 5, 1, 210, "Guitar Gods" },
                    { 6, 2, 300, "Echoes of Time" },
                    { 7, 2, 280, "Rolling Thunder" },
                    { 8, 2, 420, "Stairway to Heaven" }
                });

            migrationBuilder.InsertData(
                table: "Discos",
                columns: new[] { "Id", "Banda", "FechaLanzamiento", "Genero", "Nombre", "SKU", "UnidadesVendidas" },
                values: new object[,]
                {
                    { 3, "The Midnight Riders", new DateTime(1975, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock", "Revolution Road", "RR1975", 500000 },
                    { 4, "The Rolling Thunder", new DateTime(1969, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic Rock", "Echoes of Time", "EOT1969", 1000000 },
                    { 5, "The Phoenix Effect", new DateTime(1982, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock", "Wildfire Dreams", "WD1982", 750000 },
                    { 6, "The Cosmic Cadence", new DateTime(1978, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Progressive Rock", "Starlight Symphony", "SS1978", 300000 },
                    { 7, "The Silver Shadows", new DateTime(1972, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blues Rock", "Moonshine Melodies", "MM1972", 450000 },
                    { 8, "The Twilight Riders", new DateTime(1967, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psychedelic Rock", "Sunset Serenade", "SS1967", 700000 },
                    { 9, "The Electric Storm", new DateTime(1971, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard Rock", "Thunder Road", "TR1971", 850000 },
                    { 10, "The Inferno Band", new DateTime(1965, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock 'n' Roll", "Fire and Fury", "FF1965", 1200000 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Name", "Password", "UserName" },
                values: new object[,]
                {
                    { 3, "Test3@Test3.com", "Test3", "string", "string" },
                    { 4, "Test4@Test4.com", "Test4", "password", "user" }
                });

            migrationBuilder.InsertData(
                table: "Canciones",
                columns: new[] { "Id", "DiscoId", "TiempoDuracion", "TituloCancion" },
                values: new object[,]
                {
                    { 9, 3, 320, "Starlight Symphony" },
                    { 10, 3, 280, "Galactic Groove" },
                    { 11, 3, 240, "Celestial Serenade" },
                    { 12, 4, 260, "Moonshine Melodies" },
                    { 13, 4, 290, "Bluesy Breeze" },
                    { 14, 4, 220, "Grit and Grace" },
                    { 15, 5, 330, "Wildfire Dreams" },
                    { 16, 5, 270, "Burning Bridges" },
                    { 17, 5, 310, "Fevered Fantasies" },
                    { 18, 6, 290, "Electric Elegy" },
                    { 19, 6, 250, "Cosmic Cadence" },
                    { 20, 6, 280, "Nebula Nocturne" },
                    { 21, 7, 240, "Silver Shadows" },
                    { 22, 7, 270, "Shadow Shuffle" },
                    { 23, 7, 310, "Bluesy Ballad" },
                    { 24, 8, 330, "Sunset Serenade" },
                    { 25, 8, 270, "Psychedelic Sunset" },
                    { 26, 8, 310, "Twilight Tango" },
                    { 27, 9, 240, "Thunder Road" },
                    { 28, 9, 270, "Electric Storm" },
                    { 29, 9, 310, "Hard Rockin' Highway" },
                    { 30, 10, 330, "Fire and Fury" },
                    { 31, 10, 270, "Inferno Jam" },
                    { 32, 10, 310, "Rock 'n' Roll Riot" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Canciones",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
