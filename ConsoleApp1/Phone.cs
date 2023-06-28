using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Phone
    {
        string name;
        string model;
        int price;

        public Phone() { }

        public Phone(string name, string model, int price)
        {
            this.name = name;
            this.model = model;
            this.price = price;
        }

        public string getData()
        {
            return $"{name} - {model} for {price}";
        }
    }
}
