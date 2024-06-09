using AutoMapper;
using Microsoft.AspNetCore.Identity.Data;
using Parcial_2.Dal.Entities;
using Parcial_2.DTO;
using Parcial_2.DTO.Cancion;
using Parcial_2.DTO.Disco;
using Parcial_2.DTO.Login;

namespace Parcial_2
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            //usuario
            CreateMap<Usuario, LoginRequestDTO>()
                .ForMember(dest => dest.Username, org => org.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Password, org => org.MapFrom(src => src.Password))
            ;
            //cancion
            CreateMap<Cancion, CancionResponseDTO>()
                .ForMember(dest => dest.NombreCancion, org => org.MapFrom(src => src.TituloCancion))
                .ForMember(dest => dest.GeneroDelDisco, org => org.MapFrom(src => src.Disco.Genero))
                .ForMember(dest => dest.Banda, org => org.MapFrom(src => src.Disco.Banda))
                .ForMember(dest => dest.FechaLanzamientoDelDisco, org => org.MapFrom(src => src.Disco.FechaLanzamiento))
            ;
            CreateMap<CancionFilterRequestDTO, Cancion>()
                .ForMember(dest => dest.TituloCancion, org => org.MapFrom(src => src.NombreCancion))
                .ForMember(dest => dest.TiempoDuracion, org => org.MapFrom(src => src.DuracionCancion))
                .AfterMap((src, dest, context) =>
                {
                    var discoId = context.Items["DiscoId"] as int?;
                    if (discoId != null)
                    {
                        dest.Disco = context.Mapper.Map<Disco>(context.Items["DiscoId"]);
                    }
                })
            ;

            //disco
            CreateMap<Disco, DiscoResponseDTO>()
                .ForMember(dest => dest.TituloDisco, org => org.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Genero, org => org.MapFrom(src => src.Genero))
                .ForMember(dest => dest.Banda, org => org.MapFrom(src => src.Banda))
                .ForMember(dest => dest.CantidadVendida, org => org.MapFrom(src => src.UnidadesVendidas))
                .ForMember(dest => dest.FechaLanzamiento, org => org.MapFrom(src => src.FechaLanzamiento))
                .ForMember(dest => dest.CantidadCanciones, org => org.MapFrom(src => src.Canciones.Count()))
            ;
            CreateMap<DiscoUpdateRequestDTO, Disco>()
                .ForMember(dest => dest.Nombre, org => org.MapFrom(src => src.Titulo))
                .ForMember(dest => dest.Genero, org => org.MapFrom(src => src.Genero))
                .ForMember(dest => dest.FechaLanzamiento, org => org.MapFrom(src => src.FechaLanzamiento))
                .ForMember(dest => dest.Banda, org => org.MapFrom(src => src.Banda))
                .ForMember(dest => dest.UnidadesVendidas, org => org.MapFrom(src => src.CantidadVendidas))
            ;
            CreateMap<DiscoFilterRequestDTO, Disco>()
                .ForMember(dest => dest.Nombre, org => org.MapFrom(src => src.TituloDisco))
                .ForMember(dest => dest.Banda, org => org.MapFrom(src => src.Banda))
                .ForMember(dest => dest.UnidadesVendidas, org => org.MapFrom(src => src.CantidadVendida))
                .ForMember(dest => dest.Genero, org => org.MapFrom(src => src.Genero))
            ;
            CreateMap<DiscoCreateRequestDTO, Disco>()
                .ForMember(dest => dest.SKU, org => org.MapFrom(src => src.SKU))
                .ForMember(dest => dest.UnidadesVendidas, org => org.MapFrom(src => src.UnidadesVendidas))
                .ForMember(dest => dest.Genero, org => org.MapFrom(src => src.Genero))
                .ForMember(dest => dest.FechaLanzamiento, org => org.MapFrom(src => src.FechaLanzamiento))
                .ForMember(dest => dest.Banda, org => org.MapFrom(src => src.Banda))
                .ForMember(dest => dest.Nombre, org => org.MapFrom(src => src.Nombre))
            ;
        }
    }
}
