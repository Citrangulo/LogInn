using System;
using System.Collections.Generic;
using System.Text;

namespace LogInn.Domain.Entities
{
    public class Room 
    {
        public string Type { get; set; }
        public decimal Price { get; set; }
        public Room(string type, decimal price)
        {
            Type = type;
            Price = price;
        }
    }
}
