using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float priceItem;
            int Qnty;

            Console.Write("Enter price of item: ");
            priceItem = float.Parse(Console.ReadLine());

            Console.Write("Enter quantity: ");
            Qnty = int.Parse(Console.ReadLine());

            if (priceItem >= 0 && Qnty >= 0)
            {
                float total = priceItem * Qnty;

                Console.WriteLine($"Total cost: Php {total}");
            }
           else
            {
                if (Qnty <= 0)
                {
                    Console.WriteLine("Quantity must be a positive integer.");
                }
                if (priceItem <= 0)
                {
                    Console.WriteLine("Price must be a positive number.");
                }
            }
        }
    }
}







