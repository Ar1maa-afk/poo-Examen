namespace Ecamen1U1.ClasesPropiedadesyMetodos
{
    public class FerreOccidente
    {
        public string Nombre{ get; set;}
        public decimal Precio{ get; set;}
        public int Stock{ get; set;}

        public FerreOccidente(string nombre, decimal precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public string ObtenerInfo()
        {
            return $"{Nombre} -- Precio: L. {Precio:F2} -- Stock: {Stock} unidades";
        }

        public decimal CalcularValorInventario()
        {
            return Precio * Stock;
        }

        public void AplicarDescuento(decimal porcentaje)
        {
            Precio = Precio - (Precio * porcentaje / 100);
        }
    }
}
