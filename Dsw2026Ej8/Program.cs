namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ProductHelper pH = new ProductHelper();
            string prueba1 = pH.ObtenerEtiquetaProducto(123456789, "Producto de prueba", 100);
            Console.WriteLine(prueba1);*/

            /*Problema2 prob2 = new Problema2();
            string prueba2 = prob2.CrearResumenVenta(123456789, "Producto de prueba", 50, 1000);
            Console.WriteLine(prueba2);*/

            Problema3 prob3 = new Problema3();
            Product p = new Product("Producto de prueba");
            string prueba3 = prob3.CompararCopias(11, p);
            Console.WriteLine(prueba3);
        }
    }
}
