namespace Client_Disqueria.DTO.Disco;
public class DiscoUpdateRequestDTO
{
    public string? Titulo { get; set; }
    public string? Genero { get; set; }
    public DateTime? FechaLanzamiento { get; set; }
    public string? Banda { get; set; }
    public int? CantidadVendidas { get; set; }
}