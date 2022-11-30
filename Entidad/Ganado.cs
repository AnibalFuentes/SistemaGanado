namespace Entidad
{
    public class Ganado
    {
        public Ganado()
        {
            CalcularPrecioCompra();
            CalcularPrecioVenta();
            CalcularPesoVenta();
        }

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

        public decimal CalcularPrecioCompra()
        {
            decimal ValorKgFlaco;
            if (Sexo == "Macho")
            {
                ValorKgFlaco = 7000;
                PrecioCompra = Peso * ValorKgFlaco;
            }
            else
            {
                if (Sexo == "Hembra")
                {
                    ValorKgFlaco = 6000;
                    PrecioCompra = Peso * ValorKgFlaco;
                }
            }
            return PrecioCompra;
        }
        public decimal CalcularPrecioVenta()
        {
            decimal ValorKgGordo;
            if (Sexo == "Macho")
            {
                ValorKgGordo = 8000;
                Peso = Peso + (MesesRecuperacion * 20);
                PrecioVenta = (Peso * ValorKgGordo) - (MesesRecuperacion * 100000);
            }
            else
            {
                if (Sexo == "Hembra")
                {
                    ValorKgGordo = 7000;
                    Peso = Peso + (MesesRecuperacion * 20);
                    PrecioVenta = (Peso * ValorKgGordo) - (MesesRecuperacion * 100000);
                }
            }
            return PrecioVenta;
        }
        public decimal CalcularPesoVenta()
        {
            if (Sexo == "Macho")
            {
                PesoVenta = Peso + (MesesRecuperacion * 25);
            }
            else
            {
                if (Sexo == "Hembra")
                {
                    PesoVenta = Peso + (MesesRecuperacion * 20);
                }
            }

            return PesoVenta;
        }
    }
}
