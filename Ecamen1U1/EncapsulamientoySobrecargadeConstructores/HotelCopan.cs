namespace Ecamen1U1.EncapsulamientoySobrecargadeConstructores
{
    public class HotelCopan
    {
        private decimal _tarifaPorNoche;

        public decimal TarifaPorNoche
        {
            get {return _tarifaPorNoche;}
            set
            {
                if (value > 0)
                {
                    _tarifaPorNoche = value;
                }
                else
                {
                    _tarifaPorNoche = 500m;
                }
            }
        }

        public string Nombre { get; set; }
        public int NumeroHabitacion { get; set; }
        public int NumeroNoches { get; set; }

        public HotelCopan(string nombre, int habitacion) : this(nombre, habitacion, 1, 500m)
        {
        }

        public HotelCopan(string nombre, int habitacion, int noches) : this(nombre, habitacion, noches, 500m)
        {
        }

        public HotelCopan(string nombre, int habitacion, int noches, decimal tarifa)
        {
            Nombre = nombre;
            NumeroHabitacion = habitacion;
            NumeroNoches = noches;
            TarifaPorNoche = tarifa;
        }

        public decimal CalcularTotal()
        {
            return TarifaPorNoche * NumeroNoches;
        }

        public string ObtenerResumen()
        {
            return $"Huésped: {Nombre} | Hab: {NumeroHabitacion} | Noches: {NumeroNoches} | Tarifa/noche: L. {TarifaPorNoche:F2} | Total: L. {CalcularTotal():F2}";
        }
    }
}