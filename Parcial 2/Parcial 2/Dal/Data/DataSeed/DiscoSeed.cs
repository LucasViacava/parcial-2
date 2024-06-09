using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parcial_2.Dal.Entities;

namespace Parcial_2.Dal.Data.DataSeed
{
    public class DiscoSeed : IEntityTypeConfiguration<Disco>
    {
        public void Configure(EntityTypeBuilder<Disco> builder) 
        {
            builder.HasData(new Disco
            {
                Id = 1,
                Nombre = "Test",
                Banda = "Test",
                FechaLanzamiento = new DateTime(1999, 1, 1),
                Genero = "Test",
                UnidadesVendidas = 1,
                SKU = "Test"
            }, new Disco
            {
                Id = 2,
                Nombre = "Test2",
                Banda = "Test2",
                FechaLanzamiento = new DateTime(1999, 2, 2),
                Genero = "Test2",
                UnidadesVendidas = 2,
                SKU = "Test2"
            }, new Disco
            {
                Id = 3,
                Nombre = "Revolution Road",
                Banda = "The Midnight Riders",
                FechaLanzamiento = new DateTime(1975, 6, 20),
                Genero = "Rock",
                UnidadesVendidas = 500000,
                SKU = "RR1975"
            }, new Disco
            {
                Id = 4,
                Nombre = "Echoes of Time",
                Banda = "The Rolling Thunder",
                FechaLanzamiento = new DateTime(1969, 11, 11),
                Genero = "Classic Rock",
                UnidadesVendidas = 1000000,
                SKU = "EOT1969"
            }, new Disco
            {
                Id = 5,
                Nombre = "Wildfire Dreams",
                Banda = "The Phoenix Effect",
                FechaLanzamiento = new DateTime(1982, 3, 15),
                Genero = "Rock",
                UnidadesVendidas = 750000,
                SKU = "WD1982"
            }, new Disco
            {
                Id = 6,
                Nombre = "Starlight Symphony",
                Banda = "The Cosmic Cadence",
                FechaLanzamiento = new DateTime(1978, 9, 30),
                Genero = "Progressive Rock",
                UnidadesVendidas = 300000,
                SKU = "SS1978"
            }, new Disco
            {
                Id = 7,
                Nombre = "Moonshine Melodies",
                Banda = "The Silver Shadows",
                FechaLanzamiento = new DateTime(1972, 5, 12),
                Genero = "Blues Rock",
                UnidadesVendidas = 450000,
                SKU = "MM1972"
            }, new Disco
            {
                Id = 8,
                Nombre = "Sunset Serenade",
                Banda = "The Twilight Riders",
                FechaLanzamiento = new DateTime(1967, 8, 25),
                Genero = "Psychedelic Rock",
                UnidadesVendidas = 700000,
                SKU = "SS1967"
            }, new Disco
            {
                Id = 9,
                Nombre = "Thunder Road",
                Banda = "The Electric Storm",
                FechaLanzamiento = new DateTime(1971, 3, 8),
                Genero = "Hard Rock",
                UnidadesVendidas = 850000,
                SKU = "TR1971"
            }, new Disco
            {
                Id = 10,
                Nombre = "Fire and Fury",
                Banda = "The Inferno Band",
                FechaLanzamiento = new DateTime(1965, 11, 3),
                Genero = "Rock 'n' Roll",
                UnidadesVendidas = 1200000,
                SKU = "FF1965"
            });
        }
    }
}
