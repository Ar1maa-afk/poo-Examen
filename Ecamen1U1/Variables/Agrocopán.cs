namespace Ecamen1U1.Variables
{
    public class VariablesTiposdeDatoseInterpolacióndeStrings
    {
        public VariablesTiposdeDatoseInterpolacióndeStrings()
        {
            string nombreProducto = "Fertilizante NPK";
            decimal precioPorKg = 35.75m;
            int cantidadKg = 12;
            int descuentoPorcentaje = 10;

            decimal subtotal = precioPorKg * cantidadKg;
            decimal descuento = subtotal * descuentoPorcentaje / 100;
            decimal totalFinal = subtotal - descuento;

            Console.WriteLine("FACTURA AGROCOPÁN");
            Console.WriteLine($"Producto:  {nombreProducto}");
            Console.WriteLine($"Cantidad:  {cantidadKg} kg");
            Console.WriteLine($"Precio/kg: L. {precioPorKg:F2}");
            Console.WriteLine($"Subtotal:  L. {subtotal:F2}");
            Console.WriteLine($"Descuento: L. {descuento:F2}");
            Console.WriteLine($"Total:     L. {totalFinal:F2}");
        }
    }
}