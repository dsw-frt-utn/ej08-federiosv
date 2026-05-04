namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper pH = new ProductHelper();
            string prueba1 = pH.ObtenerEtiquetaProducto(123456789, "Producto de prueba", 100);
            Console.WriteLine(prueba1);
        }
    }
}
