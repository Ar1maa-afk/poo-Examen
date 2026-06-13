namespace Ecamen1U1.EstructurasdeControl
{
    public class BancodeCopan
    {
        public BancodeCopan()
        {
            decimal saldo;

            Console.Write("Ingrese el saldo de la cuenta: L. ");
            saldo = Convert.ToDecimal(Console.ReadLine());

            while (saldo <= 0)
            {
                Console.WriteLine("Error: el saldo debe ser mayor que 0.");
                Console.Write("Ingrese nuevamente el saldo: L. ");
                saldo = Convert.ToDecimal(Console.ReadLine());
            }

            string categoria;

            if (saldo < 1000)
            {
                categoria = "Básico";
            }
            else if (saldo <= 4999)
            {
                categoria = "Plata";
            }
            else if (saldo <= 19999)
            {
                categoria = "Oro";
            }
            else
            {
                categoria = "Platino";
            }

            Console.WriteLine();
            Console.WriteLine($"Saldo: L. {saldo:F2}");
            Console.WriteLine($"Categoría asignada: {categoria}");

            if (categoria == "Básico")
            {
                Console.WriteLine("Abra un CDT para mejorar su categoría.");
            }
            else if (categoria == "Plata")
            {
                Console.WriteLine("Tiene acceso a tarjeta de débito sin comisión.");
            }
            else if (categoria == "Oro")
            {
                Console.WriteLine("¡Felicidades! Accede a tasas preferenciales.");
            }
            else
            {
                Console.WriteLine("¡Cliente VIP! Accede a todos los beneficios del banco.");
            }
        }
    }
}