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

            /*Problema3 prob3 = new Problema3();
            Product p = new Product("Producto de prueba");
            string prueba3 = prob3.CompararCopias(11, p);
            Console.WriteLine(prueba3);*/

            /*Problema4 prob4 = new Problema4();
            Console.WriteLine(prob4.CalcularPromedio(10, 8, 7));          
            Console.WriteLine(prob4.CalcularPromedio(5, null, 6));      
            Console.WriteLine(prob4.CalcularPromedio(null, null, 6));    
            Console.WriteLine(prob4.CalcularPromedio(null, null, null));  
            Console.WriteLine(prob4.CalcularPromedio(10, -2, 15));*/

            /*Problema5 prob5 = new Problema5();
            Sale v1 = new RetailSale(1000);
            Sale v2 = new WholesaleSale(1000);
            Console.WriteLine(prob5.ObtenerImporteFinal(v1));
            Console.WriteLine(prob5.ObtenerImporteFinal(v2));*/

            Problema6 prob6 = new Problema6();
            Console.WriteLine(prob6.NormalizarCodigoProducto(" ab 123 x "));
            Console.WriteLine(prob6.NormalizarCodigoProducto(null));
        }
    }
}
