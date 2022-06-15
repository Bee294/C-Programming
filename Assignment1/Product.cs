using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Product
    {
        private string _name;
        private string _description;
        private decimal _price;

        public Product(string name, string description, decimal price)
        {
            _name = name;
            _description = description;
            _price = price;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public override string ToString()
        {
            return "Product name: " + _name + "||| Product Description: " + _description + " |||Product Price: " + _price;
        }
    }

}
