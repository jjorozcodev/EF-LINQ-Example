using System;
using System.Collections.Generic;

namespace InsertingShipperWithLINQandEF
{
    class Program
    {
        private static DataShippers dShippers = new DataShippers();

        static void Main(string[] args)
        {
            char k = char.MinValue;
            bool bContinue = false;

            do
            {
                PrintShippers();
                k = CatchKey();
                bContinue = WantRegister(k);
                if (bContinue)
                {
                    InsertShipper();
                }
            } while (bContinue);
        }

        private static void PrintShippers()
        {
            Console.Clear();

            Console.WriteLine("++++++++++ NORTHWIND'S SHIPPERS ++++++++++");
            Console.WriteLine();

            List<Shipper> shippers = dShippers.GetShippers();

            Console.WriteLine("--- ID ------- NAME ------- PHONE -------");

            foreach (Shipper s in shippers)
            {
                Console.WriteLine("|  " + s.ShipperID + "   " + s.CompanyName + "    " + s.Phone + "  |");
            }
        }

        private static char CatchKey()
        {
            Console.WriteLine();
            Console.WriteLine("Press (R) to insert new Shipper or any key to quit...");
            
            return Console.ReadKey().KeyChar;
        }

        private static bool WantRegister(char k)
        {
            return (k.Equals('r') || k.Equals('R'));
        }

        private static void InsertShipper()
        {
            Shipper s = new Shipper();

            Console.Clear();

            Console.WriteLine("++++++++++ NORTHWIND'S SHIPPERS ++++++++++");
            Console.WriteLine();

            Console.WriteLine("Name Company:");
            s.CompanyName = Console.ReadLine();

            Console.WriteLine("Phone:");
            s.Phone = Console.ReadLine();

            int IdGenerated = dShippers.InsertShipper(s);

            Console.WriteLine();
            Console.WriteLine("ID generated: " + IdGenerated);
            Console.ReadKey();
        }
    }
}
