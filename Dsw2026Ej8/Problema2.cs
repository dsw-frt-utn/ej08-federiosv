using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total = quantity > 0 ? quantity * unitPrice : 0;

            var anonymous = new {Code = productCode, Description = productDescription, Quantity = quantity, Total = total};

            return $"{anonymous.Code}-{anonymous.Description}-{anonymous.Total:C}";

        }
    }
}
