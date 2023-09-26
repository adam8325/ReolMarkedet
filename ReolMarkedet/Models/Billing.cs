using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Models
{
    public class Billing
    {
        public int BillingId; 
        public double Sale { get; set; }
        public int Commission;
        public double Payout { get; set; }

        public List<Item> Items { get; set; }

        public Billing()
        {
            Items = new List<Item>();
        }


        public void SetSale()
        {
            // Calculate the total sale amount by summing up the prices of all items
            Sale = 0;

            foreach (Item item in Items)
            {
                Sale += item.Price;
            }
            // Update the Payout (if Commission has been calculated previously)
            if (Commission < 0)
            {
                Payout = Sale - Commission;
            }
        }

        public void SetCommission()
        {
            // Calculate the commission as 15% of the total sale amount
            Commission = (int)(Sale * 0.15);

            // Update the Payout (if Sale has been calculated previously)
            if (Sale > 0)
            {
                Payout = Sale - Commission;
            }
        }
    }
}
