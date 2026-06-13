namespace Ecamen1U1.Ciclos
{
    public class TablasMultiplicar
    {
        public TablasMultiplicar()
        {
            int tabla;
            int limite;

            Console.Write("Ingrese el número de la tabla: ");
            while (!int.TryParse(Console.ReadLine(), out tabla) || tabla <= 0)
            {
                Console.WriteLine("Error: el número de la tabla debe ser mayor que 0.");
                Console.Write("Ingrese nuevamente el número de la tabla: ");
            }

            Console.Write("Ingrese el límite: ");
            while (!int.TryParse(Console.ReadLine(), out limite) || limite <= 0)
            {
                Console.WriteLine("Error: el límite debe ser mayor que 0.");
                Console.Write("Ingrese nuevamente el límite: ");
            }

            Console.WriteLine();
            Console.WriteLine($"Tabla de multiplicar del {tabla}");

            for (int i = 1; i <= limite; i++)
            {
                Console.WriteLine($"{tabla} x {i} = {tabla * i}");
            }
        }
    }
}