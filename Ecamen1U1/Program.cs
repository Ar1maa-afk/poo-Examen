using Ecamen1U1.Variables;
using Ecamen1U1.EstructurasdeControl;
using Ecamen1U1.Ciclos;
using Ecamen1U1.ClasesPropiedadesyMetodos;
using Ecamen1U1.EncapsulamientoySobrecargadeConstructores;

namespace Ecamen1U1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Ejercicios");
                Console.WriteLine("1 = AgroCopán");
                Console.WriteLine("2 = Banco de Copán");
                Console.WriteLine("3 = Tablas de Multiplicar");
                Console.WriteLine("4 = FerreOccidente");
                Console.WriteLine("5 = Hotel Copán");
                Console.WriteLine("0 = Salir");
                Console.WriteLine();
                Console.Write("Seleccione una opción: ");

                int.TryParse(Console.ReadLine(), out int opcion);

                switch (opcion)
                {
                    case 1:
                        VariablesTiposdeDatoseInterpolacióndeStrings variablesTiposdeDatoseInterpolacióndeStrings = new VariablesTiposdeDatoseInterpolacióndeStrings();
                        break;
                    case 2:
                        BancodeCopan bancodeCopan = new BancodeCopan();
                        break;
                    case 3:
                        TablasMultiplicar tablasMultiplicar = new TablasMultiplicar();
                        break;
                    case 4:
                        Console.WriteLine("INVENTARIO FERREOCCIDENTE");
                        Console.WriteLine();
                        FerreOccidente producto1 = new FerreOccidente("Martillo", 85.00m, 40);
                        FerreOccidente producto2 = new FerreOccidente("Cemento 50 lb", 320.00m, 150);
                        Console.WriteLine(producto1.ObtenerInfo());
                        Console.WriteLine($"Valor en inventario: L. {producto1.CalcularValorInventario():F2}");
                        Console.WriteLine();
                        Console.WriteLine(producto2.ObtenerInfo());
                        Console.WriteLine($"Valor en inventario: L. {producto2.CalcularValorInventario():F2}");
                        Console.WriteLine();
                        producto1.AplicarDescuento(15);
                        Console.WriteLine("Después de descuento del 15%:");
                        Console.WriteLine(producto1.ObtenerInfo());
                        break;
                    case 5:
                        Console.WriteLine("REGISTRO HOTEL COPÁN");
                        Console.WriteLine();
                        HotelCopan huesped1 = new HotelCopan("Ana López", 101);
                        HotelCopan huesped2 = new HotelCopan("Carlos Mejía", 205, 3);
                        HotelCopan huesped3 = new HotelCopan("María Ramos", 310, 5, 850m);
                        Console.WriteLine(huesped1.ObtenerResumen());
                        Console.WriteLine(huesped2.ObtenerResumen());
                        Console.WriteLine(huesped3.ObtenerResumen());
                        Console.WriteLine();
                        Console.WriteLine("Prueba de validación tarifa negativa:");
                        HotelCopan huesped4 = new HotelCopan("Pedro Cruz", 182, 2, -100m);
                        Console.WriteLine(huesped4.ObtenerResumen());
                        break;
                    case 0:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine();
                    Console.WriteLine("Presione ENTER para volver al menú o 0 para salir...");
                    Console.ReadLine();
                }
            }
        }
    }
}