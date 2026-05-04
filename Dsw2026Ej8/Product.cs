using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Product
    {
        private string _description;

        public Product(string desciption)
        {
            _description = desciption;
        }

        public string Description 
        { get => _description ?? "No description"; set => _description = value; 
        }
    }
}
