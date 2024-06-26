using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_asm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input customer details
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter last month's water meter reading (m3): ");
            double lastMonthReading = double.Parse(Console.ReadLine());

            Console.Write("Enter this month's water meter reading (m3): ");
            double thisMonthReading = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter type of customer (1: Household, 2: Administrative agency, public services, 3: Production units, 4: Business services): ");
            int customerType = int.Parse(Console.ReadLine());

            double consumption = thisMonthReading - lastMonthReading;
            double pricePerM3 = 0;
            double environmentProtectionFee = 0;
            double vat = 0.10;
            double totalBill = 0;

            if (customerType == 1)
            {
                Console.Write("Enter number of people in household: ");
                int numberOfPeople = int.Parse(Console.ReadLine());
                double consumptionPerPerson = consumption / numberOfPeople;

                if (consumptionPerPerson <= 10)
                {
                    pricePerM3 = 5.973;
                    environmentProtectionFee = 597.30;
                }
                else if (consumptionPerPerson <= 20)
                {
                    pricePerM3 = 7.052;
                    environmentProtectionFee = 705.20;
                }
                else if (consumptionPerPerson <= 30)
                {
                    pricePerM3 = 8.699;
                    environmentProtectionFee = 866.90;
                }
                else
                {
                    pricePerM3 = 15.929;
                    environmentProtectionFee = 1592.90;
                }
            }
            else if (customerType == 2)
            {
                pricePerM3 = 9.955;
                environmentProtectionFee = 995.50;
            }
            else if (customerType == 3)
            {
                pricePerM3 = 11.615;
                environmentProtectionFee = 1161.50;
            }
            else if (customerType == 4)
            {
                pricePerM3 = 22.068;
                environmentProtectionFee = 2206.80;
            }
            else
            {
                Console.WriteLine("Invalid customer type.");
                return;
            }

            totalBill = (consumption * pricePerM3) + environmentProtectionFee;
            totalBill += totalBill * vat; // Adding 10% VAT

            // Output the bill details
            Console.WriteLine("\n--- Water Bill Details ---");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Last Month's Reading: {lastMonthReading} m3");
            Console.WriteLine($"This Month's Reading: {thisMonthReading} m3");
            Console.WriteLine($"Consumption: {consumption} m3");
            Console.WriteLine($"Total Water Bill: {totalBill} VND");
        }
    }
}
