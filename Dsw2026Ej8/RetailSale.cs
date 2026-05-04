using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class RetailSale : Sale
    {
        public RetailSale(decimal amount) : base(amount)
        {
        }

        public override decimal CalculateTotal()
        {
            Console.WriteLine("Ejecutando RetailSale.CalculateTotal");
            return _amount;
        }
    }
}
