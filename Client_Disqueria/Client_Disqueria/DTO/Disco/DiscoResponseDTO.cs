namespace Client_Disqueria.DTO.Disco
{
    public class DiscoResponseDTO
    {
        public string TituloDisco { get; set; }
        public string Genero { get; set; }
        public string Banda { get; set; }
        public int CantidadVendida { get; set; }
        public int CantidadCanciones { get; set; }
        public DateTime FechaLanzamiento { get; set; }
    }
}
