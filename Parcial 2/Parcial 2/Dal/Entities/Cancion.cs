namespace Parcial_2.Dal.Entities
{
    public class Cancion : ClaseBase
    {
        public int DiscoId { get; set; }
        public Disco Disco { get; set; }
        public string TituloCancion { get; set; }
        public int TiempoDuracion { get; set; }
    }
}
