namespace Client_Disqueria.DTO.Cancion
{
    public class CancionResponseDTO
    {
        public string NombreCancion { get; set; }
        public string GeneroDelDisco { get; set; }
        public string Banda { get; set; }
        public DateTime FechaLanzamientoDelDisco { get; set; }
    }
}