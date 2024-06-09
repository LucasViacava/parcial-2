using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parcial_2.Dal.Entities;

namespace Parcial_2.Dal.Data.DataSeed
{
    public class UsuarioSeed : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasData(new Usuario
            {
                Id = 1,
                UserName = "Test",
                Password = "Test",
                Name = "Test",
                Email = "Test@Test.com"
            }, new Usuario
            {
                Id = 2,
                UserName = "Test2",
                Password = "Test2",
                Name = "Test2",
                Email = "Test2@Test2.com"
            }, new Usuario
            {
                Id = 3,
                UserName = "string",
                Password = "string",
                Name = "Test3",
                Email = "Test3@Test3.com"
            }, new Usuario
            {
                Id = 4,
                UserName = "user",
                Password = "password",
                Name = "Test4",
                Email = "Test4@Test4.com"
            });
        }
    }
}
