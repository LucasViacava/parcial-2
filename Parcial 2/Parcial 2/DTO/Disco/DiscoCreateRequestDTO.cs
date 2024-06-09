namespace Parcial_2.DTO.Disco
{
    public class DiscoCreateRequestDTO
    {
        public string Nombre { get; set; }
        public string Banda { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public string Genero { get; set; }
        public int UnidadesVendidas { get; set; }
        public string SKU { get; set; }
    }
}
