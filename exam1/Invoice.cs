using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1
{
    internal class Invoice
    {
        static void Main(String[] args)
        {
            List<IBillable> items = new List<IBillable>
            {
                new Part(144425, "8GB RAM", 2, 45.99m),
                new Part(166788, "Heat Sink", 1, 75.89m),
                new Service("Configure", "Application", 35.89m),
                new Service("Format", "Windows", 25.89m),
                new Part(191162, "Keyboard", 1, 75.89m),
                new Service("Restore", "Windows", 25.89m)
            };


            Console.WriteLine("This Month's Accounts Payable");
            decimal grandTotal = 0;

            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());

                if (item.Validate())
                {
                    decimal itemTotal = item.Bill();
                    grandTotal += itemTotal;
                    Console.WriteLine($"Total Cost: {itemTotal:C}");
                }
                else
                {
                    Console.WriteLine("Error: Invalid ID.");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Grand Total: {grandTotal:C}");
        }
    }
}
