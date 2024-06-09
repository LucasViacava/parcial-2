using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parcial_2.Dal.Entities;

namespace Parcial_2.Dal.Data.DataSeed
{
    public class CancionSeed : IEntityTypeConfiguration<Cancion>
    {
        public void Configure(EntityTypeBuilder<Cancion> builder)
        {
            builder.HasData(
                new Cancion { Id = 1, DiscoId = 1, TituloCancion = "Test", TiempoDuracion = 123 }, 
                new Cancion { Id = 2, DiscoId = 2, TituloCancion = "Test2", TiempoDuracion = 321 },
                new Cancion { Id = 3, DiscoId = 1, TituloCancion = "Rockin' Revolution", TiempoDuracion = 180 },
                new Cancion { Id = 4, DiscoId = 1, TituloCancion = "Midnight Rider", TiempoDuracion = 240 },
                new Cancion { Id = 5, DiscoId = 1, TituloCancion = "Guitar Gods", TiempoDuracion = 210 },
                new Cancion { Id = 6, DiscoId = 2, TituloCancion = "Echoes of Time", TiempoDuracion = 300 },
                new Cancion { Id = 7, DiscoId = 2, TituloCancion = "Rolling Thunder", TiempoDuracion = 280 },
                new Cancion { Id = 8, DiscoId = 2, TituloCancion = "Stairway to Heaven", TiempoDuracion = 420 },
                new Cancion { Id = 9, DiscoId = 3, TituloCancion = "Starlight Symphony", TiempoDuracion = 320 },
                new Cancion { Id = 10, DiscoId = 3, TituloCancion = "Galactic Groove", TiempoDuracion = 280 },
                new Cancion { Id = 11, DiscoId = 3, TituloCancion = "Celestial Serenade", TiempoDuracion = 240 },
                new Cancion { Id = 12, DiscoId = 4, TituloCancion = "Moonshine Melodies", TiempoDuracion = 260 },
                new Cancion { Id = 13, DiscoId = 4, TituloCancion = "Bluesy Breeze", TiempoDuracion = 290 },
                new Cancion { Id = 14, DiscoId = 4, TituloCancion = "Grit and Grace", TiempoDuracion = 220 },
                new Cancion { Id = 15, DiscoId = 5, TituloCancion = "Wildfire Dreams", TiempoDuracion = 330 },
                new Cancion { Id = 16, DiscoId = 5, TituloCancion = "Burning Bridges", TiempoDuracion = 270 },
                new Cancion { Id = 17, DiscoId = 5, TituloCancion = "Fevered Fantasies", TiempoDuracion = 310 },
                new Cancion { Id = 18, DiscoId = 6, TituloCancion = "Electric Elegy", TiempoDuracion = 290 },
                new Cancion { Id = 19, DiscoId = 6, TituloCancion = "Cosmic Cadence", TiempoDuracion = 250 },
                new Cancion { Id = 20, DiscoId = 6, TituloCancion = "Nebula Nocturne", TiempoDuracion = 280 },
                new Cancion { Id = 21, DiscoId = 7, TituloCancion = "Silver Shadows", TiempoDuracion = 240 },
                new Cancion { Id = 22, DiscoId = 7, TituloCancion = "Shadow Shuffle", TiempoDuracion = 270 },
                new Cancion { Id = 23, DiscoId = 7, TituloCancion = "Bluesy Ballad", TiempoDuracion = 310 },
                new Cancion { Id = 24, DiscoId = 8, TituloCancion = "Sunset Serenade", TiempoDuracion = 330 },
                new Cancion { Id = 25, DiscoId = 8, TituloCancion = "Psychedelic Sunset", TiempoDuracion = 270 },
                new Cancion { Id = 26, DiscoId = 8, TituloCancion = "Twilight Tango", TiempoDuracion = 310 },
                new Cancion { Id = 27, DiscoId = 9, TituloCancion = "Thunder Road", TiempoDuracion = 240 },
                new Cancion { Id = 28, DiscoId = 9, TituloCancion = "Electric Storm", TiempoDuracion = 270 },
                new Cancion { Id = 29, DiscoId = 9, TituloCancion = "Hard Rockin' Highway", TiempoDuracion = 310 },
                new Cancion { Id = 30, DiscoId = 10, TituloCancion = "Fire and Fury", TiempoDuracion = 330 },
                new Cancion { Id = 31, DiscoId = 10, TituloCancion = "Inferno Jam", TiempoDuracion = 270 },
                new Cancion { Id = 32, DiscoId = 10, TituloCancion = "Rock 'n' Roll Riot", TiempoDuracion = 310 }
            );
        }
    }
}
