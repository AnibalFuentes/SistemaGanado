namespace Entidad
{
    public class Ganado
    {
        public int IdGanado { get; set; }
        public string Referencia { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }
        public decimal Peso { get; set; }
        public int MesesRecuperacion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PesoVenta { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
