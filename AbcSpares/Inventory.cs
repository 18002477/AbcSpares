using System;
using System.Collections.Generic;
using System.Text;

namespace AbcSpares
{
    class Inventory
    {
        private string name;
        private string description;
        private string type;
        private string brand;
        private double price;

        public Inventory()
        {
        }

        public Inventory(string name, string description, string type, string brand, double price)
        {
            this.name = name;
            this.description = description;
            this.type = type;
            this.brand = brand;
            this.price = price;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Type { get => type; set => type = value; }
        public string Brand { get => brand; set => brand = value; }
        public double Price { get => price; set => price = value; }
    }


}
