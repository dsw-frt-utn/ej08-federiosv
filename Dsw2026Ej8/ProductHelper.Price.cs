using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Dsw2026Ej8
{
    internal partial class ProductHelper
    {
        private string PriceFormatter(decimal price)
        {
            return price.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
