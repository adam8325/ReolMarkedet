using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string? Description { get; set; }
        public int Barcode { get; set; }
        public double Price { get; set; }

        public Item(string? description, int barcode, double price)
        {
            Description = description;
            Barcode = barcode;
            Price= price;
        }

    }
}
